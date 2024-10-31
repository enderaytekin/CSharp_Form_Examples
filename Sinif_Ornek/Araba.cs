using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek
{
    internal class Araba
    {

        public string renk;
        public int hiz;
        public double motorGucu;
        public char durum;
        public int fiyat;

        private int yil;

        public int Yil { get => yil; set => yil = value; }
    }
}
