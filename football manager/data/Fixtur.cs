using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace football_manager.data
{
    public  class Fixtur
    {
        int[] t1;
        int[] t2;
        int[] y1 ;
        int[] y2 ;
        Lig ligimiz;
        int takim_Sayisi;
        Mac_haftası[] mac_haftasi;
        int hafta = 0;
        int lig_haftası;
        List<Takım> liste;
        Random rastg = new Random();
        string[] takm;
        public Fixtur(Lig ligi)
        {
            lig_haftası = 1;
            liste = new List<Takım>();
            ligimiz = ligi;
            takim_Sayisi = ligimiz.takim_sayisi;

            takm = new string[takim_Sayisi];
            mac_haftasi = new Mac_haftası[ligimiz.takim_sayisi - 1];
        }
        public void Fixtur_cek()
        {//
            //
            while (hafta < mac_haftasi.Length)
            {
                if (hafta == 0)
                {
                    Fixtur_Cek_ilk_hafta();
                }
                else
                {
                    Fixtur_Devamla();
                }
                mac_haftasi[hafta] = new Mac_haftası();
                for (int i = 0; i < takim_Sayisi / 2; i++)
                {
                    Mac new_mac = new Mac();
                    new_mac.Takim_a = takm[t1[i]];
                    new_mac.Takim_b = takm[t2[i]];
                    new_mac.Zaman = ligimiz.baslangıc_zaman.AddDays(hafta * 7);
                    mac_haftasi[hafta].ekle_mac(new_mac);
                }
                hafta++;
            }
        }
        private void Fixtur_Cek_ilk_hafta()
        {
            for (int i = 0; i < takim_Sayisi; i++)
            {
                liste.Add(ligimiz.get_takim_by_id(i));
            }
            liste.Add(new Takım("d", "s"));
            liste.RemoveAt(liste.Count - 1);
            t1 = new int[ligimiz.takim_sayisi / 2];
            t2 = new int[ligimiz.takim_sayisi / 2];
            for (int i = 0; i < ligimiz.takim_sayisi; i++)
            {
                int x = rastg.Next(0, liste.Count);
                takm[i] = liste[x];
                liste.RemoveAt(x);
                if (i % 2 == 0)
                {
                    t1[i / 2] = i;
                }
                else
                {
                    t2[i / 2] = i;
                }
            }

        }
        private void Fixtur_Devamla()
        {
            y1 = duzenle(t1);
            y2 = duzenle(t2);
            for (int i = 0; i < ligimiz.takim_sayisi / 2; i++)
            {
                if (i == 0)
                {
                    t1[1] = y2[0];
                }
                else if (i + 1 == ligimiz.takim_sayisi / 2)
                {
                    t2[i] = y1[i];
                    t2[i - 1] = y2[i];
                }
                else
                {
                    t1[i + 1] = y1[i];
                    t2[i - 1] = y2[i];
                }
            }

        }
        private int[] duzenle(int[] ax)
        {   //
            //
            int[] ds = new int[ax.Length];
            int i=0;
            foreach (int item in ax)
            {
                ds[i] = item;
                i++;
            }
            return ds;
        }
        public Mac_haftası[] mac__haftasi
        {
            get 
            {
                return mac_haftasi;
            }
        }
        public int Hafta
        {
            get 
            {
                return lig_haftası;
            }
        }
        public void Haftayi_ilerlet()
        {
            if (lig_haftası < mac_haftasi.Length)
            {
                lig_haftası++;
            }
            else 
            {
            //ligin bitme kodları
            }
        }
    }
   
  public  class Mac_haftası
    {
        List<Mac> maclar;
        public Mac_haftası()
        {
            maclar = new List<Mac>();
        }
        public void ekle_mac(Mac a)
        {
            maclar.Add(a);
        }
        public List<Mac> Maclar
        {
            get 
            {
                return maclar;
            }
        }
    }
    public class Mac
    {
        string takim_a;
        string takim_b;
        DateTime zaman;
        Skor skorumuz;
        public Mac()
        { 
        
        }
        public Skor Mac_Oynat()
        {
            skorumuz = Oynatici.Oynat(this);

            //paunları ekle
            int puan_a, puanb;
            if (skorumuz.Gol_ev > skorumuz.Gol_dep)
            {
                puan_a = 3;
                puanb = 0;
            }
            else if (skorumuz.Gol_ev < skorumuz.Gol_dep)
            {
                puan_a = 0;
                puanb = 3;
            }
            else 
            {
                puan_a = 1;
                puanb = 1;
            }
            veri.okuma.takim(takim_a).Puan += puan_a;
            veri.okuma.takim(takim_a).Atilan_gol += skorumuz.Gol_ev;
            veri.okuma.takim(takim_a).Yenen_gol += skorumuz.Gol_dep;
            veri.okuma.takim(takim_b).Puan += puanb;
            veri.okuma.takim(takim_b).Atilan_gol += skorumuz.Gol_dep;
            veri.okuma.takim(takim_b).Yenen_gol += skorumuz.Gol_ev;
            return skorumuz;
        }
        public string Takim_a
        {
            get
            {
                return takim_a;
            }
            set
            {
                takim_a = value;
            }
        }
        public string Takim_b
        {
            get
            {
                return takim_b;
            }
            set
            {
                takim_b = value;
            }
        }
        public DateTime Zaman
        {
            get
            {
                return zaman;
            }
            set
            {
                zaman = value;
            }
        }
        public Skor Skora
        {
            get 
            {
                return skorumuz;
            }
        }
    }
}
