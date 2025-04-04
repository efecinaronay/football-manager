using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace football_manager.data
{
    public class Takım:IComparable
    {
        string takım_isim;
        int kurulus_yili;
        Color renkler;
        Lig ligi;
        List<Oyuncu> oyuncular;
        string id;
        Taktik taktik;
        List<Mac> maclari;
        int puan;
        int atilan_gol;
        int yenilen_gol;
        public Takım(string takım_isim,string id)
        {
            oyuncular = new List<Oyuncu>();
            this.takım_isim = takım_isim;
            this.id = id;
            maclari = new List<Mac>();
            taktik = new Taktik();
            puan = 0;
        }
        public int CompareTo(object obj)
        {
            Takım t = (Takım)obj;
            if (this.puan > t.puan)
            {
                return 1;
            }
            else if (this.puan < t.puan)
            {
                return -1;
            }
            else 
            {
                if (this.atilan_gol - this.yenilen_gol > t.atilan_gol - t.yenilen_gol)
                {
                    return 1;
                }
                else if (this.atilan_gol - this.yenilen_gol < t.atilan_gol - t.yenilen_gol)
                {
                    return -1;
                }
                else
                {
                    if (this.atilan_gol > t.atilan_gol )
                    {
                        return 1;
                    }
                    else if (this.atilan_gol < t.atilan_gol)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }
        public void Oyuncu_ekle(Oyuncu yeni_oyuncu)
        {
            oyuncular.Add(yeni_oyuncu);
            yeni_oyuncu._Takım = this;
        }
        public void Maclari_al()
        {
            foreach (Mac_haftası item in ligi.fixturr.mac__haftasi)
            {
                foreach (Mac itemd in item.Maclar)
                {
                    if (itemd.Takim_a == takım_isim || itemd.Takim_b == takım_isim)
                    {
                        maclari.Add(itemd);
                    }
                }
            }
        }
        public Lig Ligi 
        {
            get 
            {
                return ligi;
            }
            set 
            {
                ligi = value;
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
        public List<Oyuncu> Oyunculari
        {

            get 
            {
                return oyuncular;
            }
            
        }
        public static implicit operator string(Takım takıma)
        {
            return takıma.takım_isim;
        }
        public Taktik Taktigi
        {
            get 
            {
                return taktik;
            }
            set 
            {
                taktik = value;
            }
        }
        public List<Mac> maclar_takim
        {
            get 
            {
                return maclari;
            }
        }
        public int Puan
        {
            get 
            {
                return puan;
            }
            set 
            {
                puan = value;
            }
        }
        public int Yenen_gol
        {
            get
            {
                return yenilen_gol;
            }
            set
            {
                yenilen_gol = value;
            }
        }
        public int Atilan_gol
        {
            get
            {
                return atilan_gol;
            }
            set
            {
                atilan_gol = value;
            }
        }
        public List<Mac> zamanagöremaclarial(string zaman)
        {
            List<Mac> maclar = new List<Mac>();
            Fixtur c = ligi.fixturr;
            for (int i = 0; i < c.mac__haftasi.Length; i++)
            {
                if (c.mac__haftasi[i].Maclar[0].Zaman.ToShortDateString() == zaman.Trim())
                {
                    foreach (Mac item in c.mac__haftasi[i].Maclar)
                    {
                       
                        maclar.Add(item);
                       
                    }
                    break;
                }
            }
            return maclar;
         
        }
        public string siradaki_Mac
        {
            get 
            {
                string rakip = "";
                foreach (Mac item in maclari)
                {
                    if (Zaman.Time <= item.Zaman)
                    {
                        rakip = item.Takim_a + "." + item.Takim_b;
                        break;
                    }
                }
                return rakip;
            }
        }
        public void Oto_Kadro_Sec()
        {
            if (!Kadro_Secili_mi())
            {
                foreach (Oyuncu item in oyuncular)
                {
                    item.Mevcut_Mevki = item.Mevkileri[0];
                }
            }
        }
        public bool Kadro_Secili_mi()
        {
            int sayi = 0;
            foreach (Oyuncu item in oyuncular)
            {
                if (item.Mevcut_Mevki != Taktik.Mevkiler.None)
                {
                    sayi++;
                }
            }
            if (sayi == 11)
            {
                return true;
            }
            return false;
        }
    }
}
