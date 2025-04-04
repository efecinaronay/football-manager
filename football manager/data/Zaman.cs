using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace football_manager.data
{
     delegate void d_Macgunu_EventHandler();
    static class Zaman
    { 
        //
       
        public static event d_Macgunu_EventHandler Mac_gunundeyiz;
        public static bool mac_oynandi = false;
        //
      
        static DateTime time;
        static DateTime Lig_baslangic_zaman;
        static Zaman()
        {
           
            time = Kul_data.My_team.takimim.Ligi.baslangıc_zaman;
            Lig_baslangic_zaman = time;
        }

       
        public static DateTime Time
        {
            get 
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        public static void Zaman_ilerlet()
        {
            Zaman_fixtur_kontrol();
        }
        static void Zaman_dur()
        { 
        
        }
        static void Zaman_fixtur_kontrol()
        {
            foreach (var s in Kul_data.My_team.takimim.maclar_takim)
            {
                if (s.Zaman == time&&mac_oynandi==false)
                {
                      Mac_gunundeyiz();
                      return;
                }
            }
            if (mac_oynandi)
            {
                mac_oynandi = false;
            }
            time = time.AddDays(1);
        }




        
    }
}
