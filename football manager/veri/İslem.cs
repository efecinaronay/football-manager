﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football_manager.veri
{
    static class İslem
    {
        public static DateTime ConverttoString(string veri)
        {
            string []prc=veri.Split('.');
            int day = Convert.ToInt32(prc[0]);
            int month = Convert.ToInt32(prc[1]);
            int year = Convert.ToInt32(prc[2]);
            DateTime tarih = new DateTime(year,month,day);
            return tarih;
        }
        public static List<data.Taktik.Mevkiler> mevkileri_doldur(string mevkiler)
        {
            List<data.Taktik.Mevkiler> list = new List<data.Taktik.Mevkiler>();
            string[] d=mevkiler.Split('.');
            foreach (string item in d)
            {
                if (item == data.Taktik.Mevkiler.K.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.K);
                }
                else if (item == data.Taktik.Mevkiler.DO.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.DO);
                }
                else if (item == data.Taktik.Mevkiler.DOS.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.DOS);
                }
                else if (item == data.Taktik.Mevkiler.DSL.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.DSL);
                }
                else if (item == data.Taktik.Mevkiler.DS.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.DS);
                }
                else if (item == data.Taktik.Mevkiler.OO.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.OO);
                }
                else if (item == data.Taktik.Mevkiler.OOS.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.OOS);
                }
                else if (item == data.Taktik.Mevkiler.OS.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.OS);
                }
                else if (item == data.Taktik.Mevkiler.OSL.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.OSL);
                }
                else if (item == data.Taktik.Mevkiler.ST.ToString())
                {
                    list.Add(data.Taktik.Mevkiler.ST);
                }
            }
            return list;
        
        }
    }
}
