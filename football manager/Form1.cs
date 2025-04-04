using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using football_manager.data;
using System.IO;
namespace football_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            System.Text.Encoding.GetEncoding("utf-8");
        }
        Size panel_Size = new Size(1320, 600);
        Point panel_Loc = new Point(30, 50);
        static bool tasima = false;
        static string mevki = "";
        public static bool durum
        {
            get 
            {
                return tasima;
            }
            set 
            {
                tasima = value; 
            }
        }
        public static string id
        {

            get 
            {
                return mevki;
            }
            set 
            {
                mevki = value;
            }
        }
        List<Lig> ligler;
        public void Yeni_oyun()
        {
            pnl_visible_kapat();
            pnl_visible_ac(pnl_yeni_oyun);
            button1.Enabled = false;
            menuStrip1.Enabled = false;
             ligler = veri.okuma.ligleri;
            foreach (var item in ligler)
            {
                combo_lig.Items.Add((string)item);
            }
            takim_doldur(ligler[0]);
            combo_lig.SelectedIndex = 0;
            combo_takim.SelectedIndex = 0;
        }
        public void takim_doldur(Lig ligg)
        {
            foreach (var item in ligg.get_takimlar)
            {
                combo_takim.Items.Add((string)item);
            }
        }
        public void Yeni_menajer()
        {
            Kul_data.My_team.takimim = ligler[combo_lig.SelectedIndex].get_takimlar[combo_takim.SelectedIndex];
            menuStrip1.Enabled = true;
            Kul_data.My_team.takimim.Ligi.Lig_Fixtur_Cek();
          
            string[] taktikler = veri.okuma.tatikleri_al(@"data\\tak");
            this.cont_taktik_pozisyon1 = new football_manager.controller.cont_taktik_pozisyon(taktikler);
            this.cont_taktik_pozisyon1.Location = new System.Drawing.Point(550, 84);
            this.cont_taktik_pozisyon1.Name = "cont_taktik_pozisyon1";
            this.cont_taktik_pozisyon1.Size = new System.Drawing.Size(551, 518);
            this.cont_taktik_pozisyon1.TabIndex = 1;
            this.pnl_taktik.Controls.Add(this.cont_taktik_pozisyon1);
            this.fixtur1.Location = new System.Drawing.Point(26, 14);
            this.fixtur1.Name = "fixtur1";
            this.fixtur1.Size = new System.Drawing.Size(864, 525);
            this.fixtur1.TabIndex = 0;
            this.pnl_Fixtur.Controls.Add(this.fixtur1);
            lbl_time.Text = data.Zaman.Time.ToShortDateString();
            Zaman.Mac_gunundeyiz += new d_Macgunu_EventHandler(Zaman_Mac_gunundeyiz);
            this.pnl_taktik.Controls.Add(this.cont_taktik_oyuncu_listesi1);
            Kul_data.My_team.takimim.Maclari_al();
            button1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Yeni_oyun();
        }

        public void Zaman_Mac_gunundeyiz()
        {

            Mesaj msj = new Mesaj(veri.okuma.mesaj_oku("mac_gunu"));
            Kul_data.Mesaj_kutusu.mesaj_ekle(msj);
            Mac_taktigi_git();
            mesajlarToolStripMenuItem.PerformClick();
        }
        public void Mac_taktigi_git()
        {
            button1.Text = "Taktik Onayla";
            button1.Tag = "taktik";
           
        }
        
        private void pnl_visible_kapat()
        {
            pnl_taktik.Visible = false;
            pnl_Fixtur.Visible = false;
            pnl_mesaj.Visible = false;
            pnl_lig_t.Visible = false;
            pnl_transfer.Visible = false;
            pnl_yeni_oyun.Visible = false;
        }
        private void pnl_visible_ac(Panel pnl)
        {
            pnl.Visible = true;
            pnl.Size = panel_Size;
            pnl.Location = panel_Loc;
        }
        private void pnl_taktik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fixturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_visible_kapat();
            pnl_visible_ac(pnl_Fixtur);
            fixtur1.fixtur_ac();
        }

        private void taktikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_visible_kapat();
            pnl_visible_ac(pnl_taktik);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Tag == "zaman")
            {
                data.Zaman.Zaman_ilerlet();
            }
            else if (button1.Tag == "taktik")
            {
                pnl_visible_kapat();
                pnl_visible_ac(pnl_taktik);
                button1.Tag = "mac";
                button1.Text = "Maça Git";
            }
            else if (button1.Tag == "mac")
            {
                if (!mac_oncesi_taktik_kontrol())
                {
                    MessageBox.Show("Lütfen tüm pozisyonları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnl_visible_kapat();
                    pnl_visible_ac(pnl_taktik);
                }
                else 
                {
                    int hafta = Kul_data.My_team.takimim.Ligi.fixturr.Hafta;
                    Mac_haftası maclar = Kul_data.My_team.takimim.Ligi.fixturr.mac__haftasi[hafta-1];
                    foreach (Mac item in maclar.Maclar)
                    {
                        Skor s = item.Mac_Oynat();
                    }
                    Kul_data.My_team.takimim.Ligi.fixturr.Haftayi_ilerlet();
                    button1.Tag = "zaman";
                    button1.Text = "İlerlet";
                    Zaman.mac_oynandi = true;
                    Zaman.Zaman_ilerlet();
                }
            }
            lbl_time.Text = data.Zaman.Time.ToShortDateString();
        }

        private void mesajlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_visible_kapat();
            pnl_visible_ac(pnl_mesaj);
            mesajlari_yükle();
        }

        private void mesajlari_yükle()
        {
            pnl_mesaj.Controls.Clear();
            Size size = new Size(panel_Size.Width - 50, 90);
            int x = 0;
            for (int a = Kul_data.Mesaj_kutusu.Mesajlar.Count-1; a >=0; a--)
            {
                Mesaj item = Kul_data.Mesaj_kutusu.Mesajlar[a];
            
                Panel pnl = new Panel();
                pnl.Name = "mesaj";
                pnl.Size = size;
                pnl.Location = new Point(10, 10 +x * size.Height);
                pnl_mesaj.Controls.Add(pnl);
                pnl.BorderStyle = BorderStyle.FixedSingle;
                Label lbl = new Label();
                lbl.Location = new Point(50, 10);
                lbl.Text = item.Konu;
                lbl.Size = new Size(size.Width,30);
                lbl.Font = Kul_data.Fonts.Mesaj_konusu;
                pnl.Controls.Add(lbl);
                Label lblz = new Label();
                lblz.Location = new Point(50, 50);
                lblz.Text = item.Mesaji;
                lblz.Size = new Size(size.Width, 30);
                lblz.Font = Kul_data.Fonts.Mesaj_yazisi;
                pnl.Controls.Add(lblz);
                x++;
            }
            if (x == 0)
            { 
              
            }
        }
        public static void oyuncu_Goster(Oyuncu o)
        { 
           
        }
        public bool mac_oncesi_taktik_kontrol()
        {
            if (controller.cont_taktik_pozisyon.pozisyonlar == null || controller.cont_taktik_pozisyon.pozisyonlar.Count == 0)
            {
                return false;
            }

            foreach (Button item in controller.cont_taktik_pozisyon.pozisyonlar)
            {
                if (item == null || string.IsNullOrWhiteSpace(item.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void ligTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_visible_kapat();
            pnl_visible_ac(pnl_lig_t);
            lig_tablosu_ac();
        }
        public void lig_tablosu_ac()
        {
            //bjk 3
            //fb 1
            //ts 1
            //gs 0 

            List<Takım> takimlar = Kul_data.My_team.takimim.Ligi.get_takimlar;
            takimlar.Sort();
            dataGridView1.Rows.Clear();
            for (int i = 0; i <takimlar.Count ; i++)
            {
                Takım t = takimlar[takimlar.Count-i-1];
                dataGridView1.Rows.Add(i+1,(string)t, t.Puan,t.Atilan_gol-t.Yenen_gol, t.Atilan_gol, t.Yenen_gol);
            }
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_visible_kapat();
            pnl_visible_ac(pnl_transfer);
            listView1.Items.Clear();
            foreach (Oyuncu o in veri.okuma.oyunculari)
            {
                if (o._Takım != Kul_data.My_team.takimim)
                {
                    string[] oyuncu_veri = new string[3];
                    oyuncu_veri[0] = o.Id;
                    oyuncu_veri[1] = (string)o;
                    oyuncu_veri[2] = (string)o._Takım;
                    ListViewItem item = new ListViewItem(oyuncu_veri);
                    listView1.Items.Add(item);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.selecte
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text + " oyuncusunu transfer etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Transfer.TransferYap(veri.okuma.Oyuncu_cek(listView1.SelectedItems[0].Text), Kul_data.My_team.takimim);
                cont_taktik_oyuncu_listesi1.Guncelle();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                Yeni_menajer();
            
            }
        }
       

    }
}
