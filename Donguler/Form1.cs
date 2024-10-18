using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");
            //listBox1.Items.Add("Merhaba");

            //for(int i = 1; i <= 15; i++)
            //{
            //    listBox1.Items.Add(i + "-Merhaba");
            //}

            for (int i = 1; i <= 200; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    listBox1.Items.Add(i);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 2; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }

            label2.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int sayi = Convert.ToInt16(textBox1.Text);

            //for (int i = 1;i <= sayi; i++)           //girilen sayıyı listeler
            //{
            //    listBox2.Items.Add(i);
            //}

            int sayi = Convert.ToInt16(textBox1.Text);

            for (int i = 1; i <= sayi; i++)      //girilen sayının tam bölenlerini verir
            {
                if (sayi % i == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox2.Text);
            int faktoriyel = 1;

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }

            listBox3.Items.Add(faktoriyel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 1;

            while (i <= 5)
            {
                listBox4.Items.Add("While Döngüsü Çıktısı");
                i++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int j = 5;
            do
            {
                listBox4.Items.Add("Selamunaleyküm");
            } while (j > 6);
        }
    }
}
