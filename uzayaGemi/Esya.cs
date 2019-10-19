using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzayaGemi
{
    class Esya
    {
        string esyaAdi;
        double kg;
        int derece;
        double dereceKg;

        public Esya(string esyaAdi, double kg, int derece)
        {
            this.esyaAdi = esyaAdi;
            this.Kg = kg;
            this.Derece = derece;
            this.DereceKg = derece / kg;
        }

        public string EsyaAdi { get => esyaAdi; set => esyaAdi = value; }
        public double Kg { get => kg; set => kg = value; }
        public int Derece { get => derece; set => derece = value; }
        public double DereceKg { get => dereceKg; set => dereceKg = value; }
    }
}
