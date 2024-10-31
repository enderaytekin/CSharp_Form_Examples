using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int sayi1 = rnd.Next(1, 101);
            int sayi2 = rnd.Next(1, 101);
            int sayi3 = rnd.Next(1, 101);
            int sayi4 = rnd.Next(1, 101);
            int sayi5 = rnd.Next(1, 101);
            int sayi6 = rnd.Next(1, 101);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();

            chart1.Series["Problem"].Points.AddXY("1.Bölge", sayi1);
            chart1.Series["Problem"].Points.AddXY("2.Bölge", sayi2);
            chart1.Series["Problem"].Points.AddXY("3.Bölge", sayi3);
            chart1.Series["Problem"].Points.AddXY("4.Bölge", sayi4);
            chart1.Series["Problem"].Points.AddXY("5.Bölge", sayi5);
            chart1.Series["Problem"].Points.AddXY("6.Bölge", sayi6);
        }

    }
}
