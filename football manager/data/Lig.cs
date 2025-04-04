using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace football_manager.data
{
   public  class Lig
    {
        string lig_ismi;
        int _takim_sayisi;
        List<Takım> takimlar;
        string id;
        Fixtur cla_fixtur;
        public  readonly DateTime baslangıc_zaman;
        public Lig(string lig_ismi, string id)
        {
            takimlar = new List<Takım>();
            baslangıc_zaman = DateTime.Now;
            this.lig_ismi = lig_ismi;
            this.id = id;
        }
        public void Takim_ekle(Takım new_takim)
        {
            takimlar.Add(new_takim);
            new_takim.Ligi = this;
        }
        public void Lig_Fixtur_Cek()
        {
            cla_fixtur = new Fixtur(this);
            cla_fixtur.Fixtur_cek();
        }
        public static implicit operator string(Lig takıma)
        {
            return takıma.lig_ismi;
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
        public Takım sd 
        {
            get {
                return takimlar[0];
            }
            
        }
        public int takim_sayisi
        {
            get
            {
                return takimlar.Count ;
            }
        }
        public List<Takım> get_takimlar
        {
            get 
            {
                return takimlar;
            }
        }
        public Takım get_takim_by_id(int a)
        {
            return takimlar[a];
        }
        public Fixtur fixturr
        {
            get
            {
                return cla_fixtur;
            }
        }

    }
}
