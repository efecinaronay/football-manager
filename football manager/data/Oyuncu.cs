using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace football_manager.data
{
   
   public  class Oyuncu
    {
        string isim;
        string soyad;
        DateTime dogum_tarih;
        Takım takimim;
        int hucum;
        int defans;
        int pas;
        int kalecilik;
        int forma_numarasi;
        string id;
        List<Taktik.Mevkiler> mevkileri;
        Taktik.Mevkiler mevki_mevcut;
        public Oyuncu(string isim,string id, DateTime d_tarih)
        {
            mevkileri = new List<Taktik.Mevkiler>();
            mevki_mevcut = Taktik.Mevkiler.None;
            this.isim = isim;
            this.dogum_tarih = d_tarih;
            this.id = id;
        }
        public Takım _Takım 
        {
            get
            {
                return takimim;
            }
            
            set
            {
                takimim = value;
            }
        }
        public DateTime dogum_gunu
        {
            get {
                return dogum_tarih;
            }
        }
        public int Hucum
        {
            get 
            {
                return hucum;
            }
            set
            {
                hucum = value;
            }
        }
        public int Defans
        {
            get 
            {
                return defans;
            }
            set
            {
                defans = value;
            }
        }
        public int Pas
        {
            get 
            {
                return pas;
            }
            set
            {
                pas = value;
            }
        }
        public string Id
        {
            get 
            {
                return id;
            }
            set 
            {
                id = value;
            }
        }
        public int Kalecilik 
        {
            get
            {
                return kalecilik;
            }
            set
            {
                kalecilik = value;
            }
        }
        public void  Mevki_ekle(Taktik.Mevkiler mevki)
        {
            mevkileri.Add(mevki);
        }
        public void Mevki_cikar(Taktik.Mevkiler mevki)
        {
            mevkileri.Remove(mevki);
        }
        public List<Taktik.Mevkiler> Mevkileri 
        {
            get 
            {
                return mevkileri;
            }
            set 
            {
                mevkileri = value;
            }
        }
        public Taktik.Mevkiler Mevcut_Mevki 
        {
            get 
            {
                return mevki_mevcut;
            }
            set 
            {
                mevki_mevcut = value;
            }
        }
        public int Forma_numarasi 
        {
            get 
            {
                return forma_numarasi;
            }
            set 
            {
                forma_numarasi = value;
            }
        }
        public List<string> string_mevki_al
        {
            get 
            {
                List<string> a = new List<string>();
                foreach (var item in mevkileri)
                {
                    a.Add(item.ToString());
                }
                return a;
            }
        }
        public override string ToString()
        {
            return $"{isim} {soyad}";
        }
        public static implicit operator string(Oyuncu oyuncu)
        {
            return oyuncu.ToString();
        }
    }
}
