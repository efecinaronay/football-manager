using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace football_manager.data
{
    public static class Oynatici
    {

        static  int toplam_pozisyon_sayisi = 20;
        static Random rastg = new Random();
        public static Skor Oynat(Mac mc)
        {
            Skor skorumuz = new Skor();
            int aguc_h=0, aguc_p=0,aguc_d=0,akal=0,bkal=0, bguc_h=0, bguc_p=0,bguc_d = 0;
            string takim_ad = mc.Takim_a;
            string takim_bd = mc.Takim_b;
            Takım t1 = veri.okuma.takim(takim_ad);
            Takım t2 = veri.okuma.takim(takim_bd);
            t1.Oto_Kadro_Sec();
            t2.Oto_Kadro_Sec();
            //evsahibi takımın güç ortalaması
            foreach (var item in t1.Oyunculari)
            {
                if (item.Mevcut_Mevki != Taktik.Mevkiler.None)
                {
                    if (item.Mevcut_Mevki == Taktik.Mevkiler.K)
                    {
                        akal = item.Kalecilik;
                    }
                    else
                    {
                        if (item.Mevkileri.IndexOf(item.Mevcut_Mevki, 0, item.Mevkileri.Count) != -1)
                        {
                            aguc_d += item.Defans;
                            aguc_h += item.Hucum;
                            aguc_p += item.Pas;
                        }
                        else 
                        {
                            aguc_d += item.Defans/2;
                            aguc_h += item.Hucum/2;
                            aguc_p += item.Pas/2;
                        }
                    }
                }
              
            }
            aguc_d = aguc_d / 10;
            aguc_p = aguc_p / 10;
            aguc_h = aguc_h / 10;
            //deplasman güç ortalamaları
            foreach (var item in t2.Oyunculari)
            {
                if (item.Mevcut_Mevki != null)
                {
                    if (item.Mevcut_Mevki == Taktik.Mevkiler.K)
                    {
                        bkal = item.Kalecilik;
                    }
                    else
                    {
                        if (item.Mevkileri.IndexOf(item.Mevcut_Mevki, 0, item.Mevkileri.Count) != -1)
                        {
                            bguc_d += item.Defans;
                            bguc_h += item.Hucum;
                            bguc_p += item.Pas;
                        }
                        else
                        {
                            bguc_d += item.Defans/2;
                            bguc_h += item.Hucum/2;
                            bguc_p += item.Pas/2;
                        }
                    }
                }
            }
            bguc_d = bguc_d / 10;
            bguc_p = bguc_p / 10;
            bguc_h = bguc_h / 10;

            //skorlama
            int a_pos =( toplam_pozisyon_sayisi * aguc_p )/ (aguc_p + bguc_p);
            int b_pos = toplam_pozisyon_sayisi - a_pos;



            for (int i = 0; i < a_pos; i++)
            {
                int gol_sansi = 0;
                if(aguc_h+aguc_p>bguc_d)
                {
                    int hucum = ((aguc_h + aguc_p + -bguc_d+ -bkal/4) / 10);//en fazla 20 olur
                    gol_sansi = rastg.Next(0, 21 - hucum);
                    if (gol_sansi <= 1)
                    {
                        skorumuz.Ev_gol_at();
                    }
                }
            }
            for (int i = 0; i < b_pos; i++)
            {
                int gol_sansi = 0;
                if (bguc_h + bguc_p > aguc_d)
                {
                    int hucum = ((bguc_h + bguc_p + -aguc_d + -akal / 4) / 10);
                    gol_sansi = rastg.Next(0, 21 - hucum);
                    if (gol_sansi <= 1)
                    {
                        skorumuz.Dep_gol_at();
                    }
                }
            }

            return skorumuz;
        }
        
    }
}
