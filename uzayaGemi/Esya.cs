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

        public static List<Esya> esyalar = new List<Esya>();
        public static List<Esya> alinacaklar = new List<Esya>();

        public static double toplamKilo = 0.0;
        public static int toplamDeger = 0;

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
