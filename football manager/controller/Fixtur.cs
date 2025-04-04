using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using football_manager.Kul_data;
using football_manager.data;
using static football_manager.data.Mac;

namespace football_manager.controller
{
    public partial class Fixtur : UserControl
    {
        public Fixtur()
        {
            InitializeComponent();
        }
        Font font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Italic);
        private void Fixtur_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            listele(My_team.takimim.maclar_takim);
        }
        private void listele(List<Mac> maclar)
        {
            Point pos = new Point(10, 30);
            int artis_y = 30;
            int max_x_zaman = 10;
            int max_x_takım = 40;
            int item_count = 0;
            foreach (Mac item in maclar)
            {
                Label a = new Label();
                a.Text = Boslukla(item.Zaman.ToShortDateString(), max_x_zaman);
                a.Name = "zaman" + a.Text;
                a.Location = new Point(pos.X, pos.Y + (item_count * artis_y));
                a.Font = font;
                a.Click += new EventHandler(a_Click);
                panel1.Controls.Add(a);
                Label b = new Label();
              
                b.Text = Boslukla(item.Takim_a + item.Skora + item.Takim_b, max_x_takım);
                b.Name = "mac" + a.Text;
                b.Location = new Point(pos.X + a.Size.Width, pos.Y + (item_count * artis_y));
                b.Width = b.Width + 100;
                b.Font = font;
                b.Click += new EventHandler(b_Click);
                panel1.Controls.Add(b);
                item_count++;
            }
        }
        private void a_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            listele(My_team.takimim.zamanagöremaclarial((sender as Label).Text));
        }
        public void fixtur_ac()
        {
            panel1.Controls.Clear();
            listele(My_team.takimim.maclar_takim);
        }
        private void b_Click(object sender, EventArgs e)
        {
          
        }
        public string Boslukla(string text, int max_karakter)
        {
            while (text.Length<=max_karakter)
            {
                text = text + " ";
            }
            return text;
        }
    }
}
