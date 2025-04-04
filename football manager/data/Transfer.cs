using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace football_manager.data
{
    class Transfer
    {
        public static void TransferYap(Oyuncu o, Takým kime)
        {
            kime.Oyuncu_ekle(o);
            for (int i = 0; i < 100; i++)
            {//0100104
              
                string id = kime.Id;
                string oyuncu_id = "0" + i;
                oyuncu_id = oyuncu_id.Substring(oyuncu_id.Length - 2, 2);
                id = id + oyuncu_id;
                bool durum = true;
                for (int z = 0; z < kime.Oyunculari.Count; z++)
                {
                    if (kime.Oyunculari[z].Id == id)
                    {
                        durum = false;
                        break;
                    }
                }
                if (durum)
                {
                    o.Id = id;
                    
                    break;
                }
            }
        }
       
    }
}
