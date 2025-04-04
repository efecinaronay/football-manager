using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace football_manager.veri
{
    class okuma
    {
        private static readonly string DATA_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");

        public okuma()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            try
            {
                Directory.CreateDirectory(DATA_PATH);
                ligleri_oku();
                takimlari_oku();
                oyunculari_oku();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Dosya okuma hatası: {ex.Message}\nKonum: {DATA_PATH}", "Hata", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        static List<data.Lig> ligler = new List<data.Lig>();
        static List<data.Takım> takimlar = new List<data.Takım>();
        static List<data.Oyuncu> oyuncular = new List<data.Oyuncu>();

        private static string ReadFileWithEncoding(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Dosya bulunamadı: {filePath}");
            }

            // First try to detect the encoding from file content
            byte[] buffer = File.ReadAllBytes(filePath);
            if (buffer.Length >= 3 && buffer[0] == 0xEF && buffer[1] == 0xBB && buffer[2] == 0xBF)
            {
                // File has UTF-8 BOM
                return File.ReadAllText(filePath, Encoding.UTF8);
            }

            // Try different encodings
            var encodings = new[] 
            { 
                Encoding.UTF8,
                Encoding.GetEncoding("windows-1254"), // Turkish Windows
                Encoding.GetEncoding("iso-8859-9"),  // Turkish ISO
                Encoding.GetEncoding("ibm857"),      // Turkish DOS
                Encoding.Default
            };

            string content = null;
            foreach (var encoding in encodings)
            {
                try
                {
                    content = File.ReadAllText(filePath, encoding);
                    if (content.Any(c => c == 'ı' || c == 'ğ' || c == 'ü' || c == 'ş' || c == 'ö' || c == 'ç' ||
                                       c == 'İ' || c == 'Ğ' || c == 'Ü' || c == 'Ş' || c == 'Ö' || c == 'Ç'))
                    {
                        return content; // Found valid Turkish characters
                    }
                }
                catch
                {
                    continue;
                }
            }

            // If no encoding worked well with Turkish chars, return the UTF-8 content
            return File.ReadAllText(filePath, Encoding.UTF8);
        }

        private void ligleri_oku()
        {
            string filePath = Path.Combine(DATA_PATH, "lig.txt");
            string content = ReadFileWithEncoding(filePath);
            foreach (string line in content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] prc = line.Split('<');
                if (prc.Length >= 2)
                {
                    string lig_ismi = prc[0].Trim();
                    string id = prc[1].Trim();
                    data.Lig new_lig = new data.Lig(lig_ismi, id);
                    ligler.Add(new_lig);
                }
            }
        }

        private void takimlari_oku()
        {
            string filePath = Path.Combine(DATA_PATH, "takım.txt");
            string content = ReadFileWithEncoding(filePath);
            foreach (string line in content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] prc = line.Split('<');
                if (prc.Length >= 2)
                {
                    string takim_ismi = prc[0].Trim();
                    string id = prc[1].Trim();
                    data.Takım new_takim = new data.Takım(takim_ismi, id);
                    takimlar.Add(new_takim);
                    liglere_doldur(new_takim);
                }
            }
        }

        private void oyunculari_oku()
        {
            string filePath = Path.Combine(DATA_PATH, "oyuncu.txt");
            string content = ReadFileWithEncoding(filePath);
            foreach (string line in content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] prc = line.Split('<');
                if (prc.Length >= 2)
                {
                    string oyuncu_ismi = prc[0].Trim();
                    string[] prc_degerler = prc[1].Split(',');
                    if (prc_degerler.Length >= 8)
                    {
                        string id = prc_degerler[0].Trim();
                        data.Oyuncu new_oyuncu = new data.Oyuncu(oyuncu_ismi, id, İslem.ConverttoString(prc_degerler[2]));
                        new_oyuncu.Forma_numarasi = Convert.ToInt32(prc_degerler[1]);
                        new_oyuncu.Hucum = Convert.ToInt32(prc_degerler[3]);
                        new_oyuncu.Pas = Convert.ToInt32(prc_degerler[4]);
                        new_oyuncu.Defans = Convert.ToInt32(prc_degerler[5]);
                        new_oyuncu.Kalecilik = Convert.ToInt32(prc_degerler[6]);
                        new_oyuncu.Mevkileri = İslem.mevkileri_doldur(prc_degerler[7]);
                        oyuncular.Add(new_oyuncu);
                        takimlara_doldur(new_oyuncu);
                    }
                }
            }
            if (takimlar.Count > 1)
            {
                Kul_data.My_team.takimim = takimlar[1];
            }
        }

        private void takimlara_doldur(data.Oyuncu oyuncu)
        {
            string takim_id = oyuncu.Id.ToString().Substring(0, 5);
            for (int i = 0; i < takimlar.Count; i++)
            {
                if (takimlar[i].Id == takim_id)
                {
                    takimlar[i].Oyuncu_ekle(oyuncu);
                    break;
                }
            }
        }

        private void liglere_doldur(data.Takım takim)
        {
            string lig_id = takim.Id.ToString().Substring(0, 3);
            for (int i = 0; i < ligler.Count; i++)
            {
                if (ligler[i].Id == lig_id)
                {
                    ligler[i].Takim_ekle(takim);
                    break;
                }
            }
        }

        public static data.Oyuncu Oyuncu_cek(string id)
        {
            foreach (data.Oyuncu y_oyuncu in oyuncular)
            {
                if (y_oyuncu.Id == id)
                {
                    return y_oyuncu;
                }
            }
            return null;
        }

        public static string[] tatikleri_al(string yer)
        {
            try
            {
                string[] dosya = Directory.GetFiles(yer);
                for (int k = 0; k < dosya.Length; k++)
                {
                    string[] yeni_deger_dizi = dosya[k].Split('\\');
                    string yeni_Deger = yeni_deger_dizi[yeni_deger_dizi.Length - 1].Split('.')[0];
                    dosya[k] = yeni_Deger;
                }
                return dosya;
            }
            catch
            {
                throw new Exception("dsa");
            }
        }

        public static string mesaj_oku(string name)
        {
            string filePath = Path.Combine(DATA_PATH, "mes", name + ".txt");
            return ReadFileWithEncoding(filePath);
        }

        public static data.Takım takim(string takim_ismi)
        {
            foreach (var item in takimlar)
            {
                if (item == takim_ismi)
                {
                    return item;
                }
            }
            return null;
        }

        public static List<data.Oyuncu> oyunculari
        {
            get 
            {
                return oyuncular;
            }
        }

        public static List<data.Lig> ligleri
        {
            get
            {
                return ligler;
            }
        }
    }
}
