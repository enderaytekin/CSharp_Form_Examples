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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonKirmizi.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();

            if (sayac == 30)
            {
                buttonKirmizi.BackColor = this.BackColor;
                buttonSari.BackColor = Color.Yellow;
            }
            if(sayac == 40)
            {
                buttonSari.BackColor = this.BackColor;
                buttonYesil.BackColor = Color.Green;
            }
            if(sayac == 70)
            {
                buttonYesil.BackColor = this.BackColor;
                buttonKirmizi.BackColor = Color.Red;
                sayac = 0;
            }
        }
    }
}
