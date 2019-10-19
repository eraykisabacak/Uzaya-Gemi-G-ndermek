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
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
            
            List<Esya> esyalar = new List<Esya>();
            List<Esya> alinacaklar = new List<Esya>();
            double toplamKilo = 0.0;
            int toplamDeger = 0;

            string yazi = sr.ReadLine();
            while(yazi != null)
            {
                string[] dosyaEsya = yazi.Split('|');
                esyalar.Add(new Esya(dosyaEsya[0], double.Parse(dosyaEsya[1]), int.Parse(dosyaEsya[2])));
                yazi = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
           
            esyalar = esyalar.OrderBy(x => x.DereceKg).ToList();
            esyalar.Reverse();
            

            int i = 0;
            Console.WriteLine("***********************Alınan Eşyalar***********************");
            do
            {
                alinacaklar.Add(esyalar[i]);
                Console.WriteLine(esyalar[i].EsyaAdi + " " + esyalar[i].Kg + " " + esyalar[i].Derece);
                toplamKilo += esyalar[i].Kg;
                toplamDeger += esyalar[i].Derece;
                for (int j = i+1 ; j < esyalar.Count;j++)
                {
                    if (esyalar[i].EsyaAdi.Equals(esyalar[j].EsyaAdi))
                    {
                        esyalar.RemoveAt(j);
                    }
                }
                if(toplamKilo > 150)
                {
                    esyalar.RemoveAt(i);
                    toplamKilo -= esyalar[i].Kg;
                    toplamDeger -= esyalar[i].Derece;
                    break;
                }
                i++;
            } while (toplamKilo <= 150 && i < esyalar.Count);
            Console.WriteLine("Toplam Kilo : " + toplamKilo);
            Console.WriteLine("Toplam Deger : " + toplamDeger);
        }
    }
}
