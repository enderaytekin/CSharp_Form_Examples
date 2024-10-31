using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        void Renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.LightBlue;
            textBox3.BackColor = Color.Red;
            textBox4.BackColor = Color.HotPink;
        }

        void Doldur()
        {
            textBox1.Text = "Ender";
            textBox2.Text = "Aytekin";
            textBox3.Text = "Ardahan";
            textBox4.Text = "Mühendis";
        }

        int Topla()
        {
            int s1 = Convert.ToInt32(textBox5.Text);
            int s2 = Convert.ToInt32(textBox6.Text);
            int toplam = s1 + s2;
            return toplam;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = Topla().ToString();
        }
    }
}
