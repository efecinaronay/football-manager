using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using football_manager.data;

namespace football_manager.Kul_data
{
    static class Mesaj_kutusu
    {
        static List<Mesaj> mesajlar;
        static int max_buyukluk = 10;
        static Mesaj_kutusu()
        {
            mesajlar = new List<Mesaj>();
        }
        public static void mesaj_ekle(Mesaj msj)
        {
            if (mesajlar.Count > max_buyukluk)
            {
                mesaj_sil();
            }
            mesajlar.Add(msj);
        }
        public static void mesaj_sil(Mesaj msj)
        {
            mesajlar.Remove(msj);
        }
        public static void mesaj_sil()
        {
            if (mesajlar.Count > 1)
            {
                mesajlar.RemoveAt(0);
            }
        }
        public static void mesajları_Temizle()
        {
            mesajlar.Clear();
        }
        public static List<Mesaj> Mesajlar
        {
            get
            {
                return mesajlar;
            }
        }
    }
}
