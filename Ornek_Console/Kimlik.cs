using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Kimlik
    {

        string ad, soyad, memleket;
        int yas;
        char cinsiyet;

        public string Ad
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public string Memleket
        {
            get { return memleket; }
            set { memleket = value.ToUpper(); }
        }

        public int Yas
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public char Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kimlik()
        {
            ad = "";
            soyad = "";
            yas = 18;
            cinsiyet = 'E';
            memleket = "Ankara";

        }

    }
}
