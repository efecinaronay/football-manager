using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace football_manager.data
{
    class Mesaj
    {
        string mesaj;
        string konu;
        public Mesaj(string veri)
        {
            konu = veri.Split('|')[0];
            mesaj = veri.Split('|')[1];
            degerleri_duzelt();
        }
        private void degerleri_duzelt()
        {
            string takim_A = Kul_data.My_team.takimim.siradaki_Mac;
            string takim_B = takim_A.Split('.')[1];
            takim_A = takim_A.Split('.')[0];
            konu = konu.Replace("<t1>", takim_A);
            konu = konu.Replace("<t2>", takim_B);
            mesaj = mesaj.Replace("<t1>", takim_A);
            mesaj = mesaj.Replace("<t2>", takim_B);
        }
        public string Konu
        {
            get
            {
                return konu;
            }
        }
        public string Mesaji
        {
            get
            {
                return mesaj;
            }
        }
    }
}
