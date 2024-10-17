using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }

        int soruNo = 0, dogruSayisi = 0, yanlisSayisi = 0;


        private void buttonB_Click(object sender, EventArgs e)
        {
            labelButondanGelenCevap.Text = buttonB.Text;

            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSiradakiSoru.Enabled = true;

            if (labelButondanGelenCevap.Text == labelDogruCevap.Text)
            {
                dogruSayisi++;
                labelDogruSayisi.Text = dogruSayisi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisSayisi++;
                labelYanlisSayisi.Text = yanlisSayisi.ToString();
                pictureBox2.Visible = true;
            }

            if (soruNo == 3)
            {
                buttonSiradakiSoru.Text = "Sonuçlar";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            labelButondanGelenCevap.Text = buttonC.Text;

            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSiradakiSoru.Enabled = true;

            if (labelButondanGelenCevap.Text == labelDogruCevap.Text)
            {
                dogruSayisi++;
                labelDogruSayisi.Text = dogruSayisi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisSayisi++;
                labelYanlisSayisi.Text = yanlisSayisi.ToString();
                pictureBox2.Visible = true;
            }

            if (soruNo == 3)
            {
                buttonSiradakiSoru.Text = "Sonuçlar";
            }

        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            labelButondanGelenCevap.Text = buttonD.Text;

            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSiradakiSoru.Enabled = true;

            if (labelButondanGelenCevap.Text == labelDogruCevap.Text)
            {
                dogruSayisi++;
                labelDogruSayisi.Text = dogruSayisi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisSayisi++;
                labelYanlisSayisi.Text = yanlisSayisi.ToString();
                pictureBox2.Visible = true;
            }

            if (soruNo == 3)
            {
                buttonSiradakiSoru.Text = "Sonuçlar";
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            labelButondanGelenCevap.Text = buttonA.Text;

            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSiradakiSoru.Enabled = true;

            if (labelButondanGelenCevap.Text == labelDogruCevap.Text)
            {
                dogruSayisi++;
                labelDogruSayisi.Text = dogruSayisi.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisSayisi++;
                labelYanlisSayisi.Text = yanlisSayisi.ToString();
                pictureBox2.Visible = true;
            }

            if (soruNo == 3)
            {
                buttonSiradakiSoru.Text = "Sonuçlar";
            }
        }

        private void buttonSiradakiSoru_Click(object sender, EventArgs e)
        {
            soruNo++;
            labelSoruNo.Text = soruNo.ToString();

            buttonSiradakiSoru.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;

            if (soruNo == 1)
            {
                richTextBox1.Text = "Osmanlı Devleti kaç yılında kurulmuştur?";
                buttonA.Text = "1299";
                buttonB.Text = "1305";
                buttonC.Text = "1289";
                buttonD.Text = "1321";
                labelDogruCevap.Text = "1299";
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Antalya ili hangi bölgede yer alır?";
                buttonA.Text = "Marmara";
                buttonB.Text = "Akdeniz";
                buttonC.Text = "Ege";
                buttonD.Text = "Karadeniz";
                labelDogruCevap.Text = "Akdeniz";
            }

            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                buttonA.Text = "Sait Faik";
                buttonB.Text = "Cemal Süreyya";
                buttonC.Text = "Atilla İlhan";
                buttonD.Text = "Reşat Nuri";
                labelDogruCevap.Text = "Sait Faik";
            }

            if (soruNo == 4)
            {
                MessageBox.Show("Doğru Sayısı: " + dogruSayisi + "\n" + "Yanlış Sayısı: " + yanlisSayisi);

                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }

        }



    }
}
