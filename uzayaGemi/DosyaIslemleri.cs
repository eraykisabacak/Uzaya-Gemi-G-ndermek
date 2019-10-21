using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzayaGemi
{
    class DosyaIslemleri
    {
        public static void DosyaOkuma(string dosya_yolu)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));

            string yazi = sr.ReadLine();
            while (yazi != null)
            {
                string[] dosyaEsya = yazi.Split('|');
                Esya.esyalar.Add(new Esya(dosyaEsya[0], double.Parse(dosyaEsya[1]), int.Parse(dosyaEsya[2])));
                yazi = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
    }
}
