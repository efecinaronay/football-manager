using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace football_manager.Kul_data
{
    static class Fonts
    {
        static Font mesaj_konusu;
        static Font mesaj_yazisi;
        static Fonts()
        {
            mesaj_konusu = new Font(FontFamily.GenericSerif, 16, FontStyle.Bold);
            mesaj_yazisi = new Font(FontFamily.GenericSerif, 12, FontStyle.Regular);
        }
        public static Font Mesaj_yazisi
        {
            get
            {
                return mesaj_yazisi;
            }
        }
        public static Font Mesaj_konusu
        {
            get
            {
                return mesaj_konusu;
            }
        }
    }
}
