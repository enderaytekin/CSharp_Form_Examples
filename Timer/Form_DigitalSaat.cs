using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form_DigitalSaat : Form
    {
        public Form_DigitalSaat()
        {
            InitializeComponent();
        }

        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saat != 60)
                label3.Text = saniye.ToString("00");

            if (saniye == 60)
            {
                dakika++;
                if (dakika != 60)
                    label2.Text = dakika.ToString("00");
                saniye = 0;
                label3.Text = saniye.ToString("00");
            }

            if (dakika == 60)
            {
                saat++;
                label1.Text = saat.ToString("00");
                dakika = 0;
                label2.Text = dakika.ToString("00");
            }
        }
    }
}
