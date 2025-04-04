using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace football_manager.Kul_data
{
    static class My_team
    {
        static data.Takım takimim_;
        static My_team() 
        {
            try
            {
                takimim_ = new data.Takım("ads", "213");
            }
            catch 
            { 
            
            }
        }

        public static data.Takım takimim 
        {
            get { return takimim_; }
            set { takimim_ = value; }
        }
    }
}
