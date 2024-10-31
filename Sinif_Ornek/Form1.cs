using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Araba rb = new Araba();
            rb.renk = "Kırmızı";
            rb.hiz = 160;
            rb.motorGucu = 1234.56;
            rb.fiyat = 50000;
            rb.durum = 's';
            rb.Yil = 1986;

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motorGucu.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.Yil.ToString();

            BackColor = Color.Red;

        }
    }
}
