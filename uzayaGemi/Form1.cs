using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uzayaGemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dosya_yolu = @"../../esyalar.txt";
            
            DosyaIslemleri.DosyaOkuma(dosya_yolu);

            Esya.esyalar = Esya.esyalar.OrderBy(x => x.DereceKg).ToList();
            Esya.esyalar.Reverse();
            

            int i = 0;
            Console.WriteLine("***********************Alınan Eşyalar***********************");
            do
            {
                Esya.alinacaklar.Add(Esya.esyalar[i]);
                alinanlar.Items.Add(Esya.esyalar[i].EsyaAdi);
                Console.WriteLine(Esya.esyalar[i].EsyaAdi + " " + Esya.esyalar[i].Kg + " " + Esya.esyalar[i].Derece);
                Esya.toplamKilo += Esya.esyalar[i].Kg;
                Esya.toplamDeger += Esya.esyalar[i].Derece;
                for (int j = i+1 ; j < Esya.esyalar.Count;j++)
                {
                    if (Esya.esyalar[i].EsyaAdi.Equals(Esya.esyalar[j].EsyaAdi))
                    {
                        Esya.esyalar.RemoveAt(j);
                    }
                }
                if(Esya.toplamKilo > 150)
                {
                    Esya.esyalar.RemoveAt(i);
                    Esya.toplamKilo -= Esya.esyalar[i].Kg;
                    Esya.toplamDeger -= Esya.esyalar[i].Derece;
                    break;
                }
                i++;
            } while (Esya.toplamKilo <= 150 && i < Esya.esyalar.Count);
            Console.WriteLine("Toplam Kilo : " + Esya.toplamKilo);
            Console.WriteLine("Toplam Deger : " + Esya.toplamDeger);
            topKilo.Text = "Toplam Kilo: " + Esya.toplamKilo;
            topDeger.Text = "Toplam Deger: " + Esya.toplamDeger;
        }
    }
}
