namespace Bilgi_Yarismasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSiradakiSoru = new System.Windows.Forms.Button();
            this.labelYanlisSayisi = new System.Windows.Forms.Label();
            this.labelDogruSayisi = new System.Windows.Forms.Label();
            this.labelSoruNo = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelDogruCevap = new System.Windows.Forms.Label();
            this.labelButondanGelenCevap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.richTextBox1.Location = new System.Drawing.Point(1, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(457, 142);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = " Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yanlış:";
            // 
            // buttonSiradakiSoru
            // 
            this.buttonSiradakiSoru.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSiradakiSoru.Location = new System.Drawing.Point(464, 110);
            this.buttonSiradakiSoru.Name = "buttonSiradakiSoru";
            this.buttonSiradakiSoru.Size = new System.Drawing.Size(171, 33);
            this.buttonSiradakiSoru.TabIndex = 4;
            this.buttonSiradakiSoru.Text = "Sıradaki Soru";
            this.buttonSiradakiSoru.UseVisualStyleBackColor = false;
            this.buttonSiradakiSoru.Click += new System.EventHandler(this.buttonSiradakiSoru_Click);
            // 
            // labelYanlisSayisi
            // 
            this.labelYanlisSayisi.AutoSize = true;
            this.labelYanlisSayisi.Location = new System.Drawing.Point(576, 77);
            this.labelYanlisSayisi.Name = "labelYanlisSayisi";
            this.labelYanlisSayisi.Size = new System.Drawing.Size(17, 19);
            this.labelYanlisSayisi.TabIndex = 7;
            this.labelYanlisSayisi.Text = "0";
            // 
            // labelDogruSayisi
            // 
            this.labelDogruSayisi.AutoSize = true;
            this.labelDogruSayisi.Location = new System.Drawing.Point(576, 44);
            this.labelDogruSayisi.Name = "labelDogruSayisi";
            this.labelDogruSayisi.Size = new System.Drawing.Size(17, 19);
            this.labelDogruSayisi.TabIndex = 6;
            this.labelDogruSayisi.Text = "0";
            // 
            // labelSoruNo
            // 
            this.labelSoruNo.AutoSize = true;
            this.labelSoruNo.Location = new System.Drawing.Point(576, 11);
            this.labelSoruNo.Name = "labelSoruNo";
            this.labelSoruNo.Size = new System.Drawing.Size(17, 19);
            this.labelSoruNo.TabIndex = 5;
            this.labelSoruNo.Text = "0";
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.DarkGray;
            this.buttonA.Location = new System.Drawing.Point(1, 162);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(227, 39);
            this.buttonA.TabIndex = 8;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.DarkGray;
            this.buttonB.Location = new System.Drawing.Point(231, 162);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(227, 39);
            this.buttonB.TabIndex = 9;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.DarkGray;
            this.buttonD.Location = new System.Drawing.Point(231, 207);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(227, 39);
            this.buttonD.TabIndex = 11;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.DarkGray;
            this.buttonC.Location = new System.Drawing.Point(1, 207);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(227, 39);
            this.buttonC.TabIndex = 10;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(553, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // labelDogruCevap
            // 
            this.labelDogruCevap.AutoSize = true;
            this.labelDogruCevap.Location = new System.Drawing.Point(143, 276);
            this.labelDogruCevap.Name = "labelDogruCevap";
            this.labelDogruCevap.Size = new System.Drawing.Size(49, 19);
            this.labelDogruCevap.TabIndex = 14;
            this.labelDogruCevap.Text = "label7";
            this.labelDogruCevap.Visible = false;
            // 
            // labelButondanGelenCevap
            // 
            this.labelButondanGelenCevap.AutoSize = true;
            this.labelButondanGelenCevap.Location = new System.Drawing.Point(207, 276);
            this.labelButondanGelenCevap.Name = "labelButondanGelenCevap";
            this.labelButondanGelenCevap.Size = new System.Drawing.Size(50, 19);
            this.labelButondanGelenCevap.TabIndex = 15;
            this.labelButondanGelenCevap.Text = "label8";
            this.labelButondanGelenCevap.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(647, 258);
            this.Controls.Add(this.labelButondanGelenCevap);
            this.Controls.Add(this.labelDogruCevap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.labelYanlisSayisi);
            this.Controls.Add(this.labelDogruSayisi);
            this.Controls.Add(this.labelSoruNo);
            this.Controls.Add(this.buttonSiradakiSoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSiradakiSoru;
        private System.Windows.Forms.Label labelYanlisSayisi;
        private System.Windows.Forms.Label labelDogruSayisi;
        private System.Windows.Forms.Label labelSoruNo;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelDogruCevap;
        private System.Windows.Forms.Label labelButondanGelenCevap;
    }
}

