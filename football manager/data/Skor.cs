using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football_manager.data
{
    public class Skor
    {
        int e_atilan_gol;
        int d_aitlan_gol;
        public Skor()
        {
            e_atilan_gol = 0;
            d_aitlan_gol = 0;
        }
        public void Ev_gol_at()
        {
            e_atilan_gol++;
        }
        public void Dep_gol_at()
        {
            d_aitlan_gol++;
        }
        public int Gol_ev
        {
            get
            {
                return e_atilan_gol;
            }
        }
        public int Gol_dep
        {
            get
            {
                return d_aitlan_gol;
            }
        }
        public static implicit operator string(Skor s)
        {
            if (s == null)
            {
                return "-";
            }
            return s.e_atilan_gol + "-" + s.d_aitlan_gol;
        }

    }
}
