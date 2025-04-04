using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace football_manager.controller
{
    public partial class cont_taktik_pozisyon : UserControl
    {
        public cont_taktik_pozisyon(string[] taktikler)
        {
            InitializeComponent();
            foreach (string item in taktikler)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
        }
        public static List<Button> pozisyonlar;
        private void cont_taktik_pozisyon_Load(object sender, EventArgs e)
        {
            pozisyonlar = new List<Button>();
            foreach (Control c in this.Controls)
            {
                if (c.Name.StartsWith("pz"))
                {
                    pozisyonlar.Add((Button)c);
                }
            }
            timer1.Start();
           
        }

        private void pz10_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
           
        }

        private void pz10_DragDrop(object sender, DragEventArgs e)
        {
            string alinan_isim_id = (string)e.Data.GetData(DataFormats.StringFormat);

            if (alinan_isim_id != null)
            {
                string[] parcalar = alinan_isim_id.Split(',');
                if (parcalar.Length >= 2)
                {
                    string isim = parcalar[0];
                    string id = parcalar[1];
                    Button btn = (sender as Button);
                    btn.Text = isim;
                    btn.Tag = id;
                    btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                    taktik_duzenleme(id, btn.Name);
                    veri.okuma.Oyuncu_cek(id).Mevcut_Mevki = veri.İslem.mevkileri_doldur(btn.AccessibleName)[0];
                }
            }
        }
        private void taktik_duzenleme(string id,string buton_name)
        {
            foreach (Control kontroll in this.Controls)
            {
                if (kontroll.Tag != "")
                {
                    if (kontroll.Name != buton_name && kontroll.Tag.ToString() == id)
                    {
                        kontroll.Text = "";
                        kontroll.Tag = "";
                    }
                }
            }
        }

        private void pz10_MouseHover(object sender, EventArgs e)
        {

        }

        private void pz10_MouseEnter(object sender, EventArgs e)
        {
            if ((sender as Button).Tag != "" && (sender as Button).Tag != null)
            {
                data.Oyuncu oyuncu = veri.okuma.Oyuncu_cek((sender as Button).Tag.ToString());
                if (oyuncu != null)
                {
                    (sender as Button).Text = oyuncu.Forma_numarasi.ToString();
                    (sender as Button).Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                }
            }
        }

        private void pz10_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as Button).Tag != null && (sender as Button).Tag != "")
            {
                data.Oyuncu oyuncu = veri.okuma.Oyuncu_cek((sender as Button).Tag.ToString());
                if (oyuncu != null)
                {
                    (sender as Button).Text = oyuncu.ToString();
                    (sender as Button).Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string taktik = comboBox1.SelectedItem.ToString();
                string filePath = Path.Combine("data", "tak", taktik + ".txt");
                
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Taktik dosyası bulunamadı: " + filePath, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (StreamReader oku = new StreamReader(filePath, Encoding.UTF8))
                {
                    string veri;
                    while ((veri = oku.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(veri)) continue;

                        string[] prc = veri.Split(';');
                        if (prc.Length != 4)
                        {
                            MessageBox.Show("Geçersiz taktik dosyası formatı: " + veri, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        Point konum = new Point(Convert.ToInt32(prc[1]), Convert.ToInt32(prc[2]));
                        Pozisyon_yer_Degistir(prc[0], konum, prc[3]);
                        Kul_data.My_team.takimim.Taktigi.Taktigim = taktik;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Taktik dosyası okunurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Oyuncu_yerlestir()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.Name.StartsWith("pz"))
                {   //poz3 poz10
                    Kul_data.My_team.takimim.Taktigi.Oyuncu_Pozisyonu[Convert.ToInt32(ctr.Name.Substring(2, ctr.Name.Length - 2))] = ctr.Text + ";" + ctr.Tag.ToString();
                }
            }
        }
        private void Pozisyon_yer_Degistir(string button_name,Point location,string mevki)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name == button_name)
                {
                    item.Location = location;
                    item.AccessibleName = mevki;
                }
            }
        }

        private void pz10_TextChanged(object sender, EventArgs e)
        {
            Oyuncu_yerlestir();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.durum)
            {
                foreach (Control c in this.Controls)
                {
                    data.Oyuncu o = veri.okuma.Oyuncu_cek(Form1.id);
                    if (o.string_mevki_al.Contains(c.AccessibleName)) 
                    {
                        c.BackColor = Color.Green;
                    }
                }
            }
            else 
            {
                foreach (Control c in this.Controls)
                {
                    c.BackColor = Color.SandyBrown;
                }
            }
        }
        Button bt_context_strip;
        private void pz10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                bt_context_strip = (Button)sender;
                contextMenuStrip1.Show(bt_context_strip, bt_context_strip.PointToClient(Cursor.Position));
            }
        }

        private void pozisyondanÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bt_context_strip != null)
            {
                bt_context_strip.Text = "";
                bt_context_strip.Tag = "";
            }
        }

  



        
    }
}
