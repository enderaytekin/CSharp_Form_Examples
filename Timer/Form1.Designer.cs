namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonKirmizi = new System.Windows.Forms.Button();
            this.buttonSari = new System.Windows.Forms.Button();
            this.buttonYesil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonKirmizi
            // 
            this.buttonKirmizi.Location = new System.Drawing.Point(107, 60);
            this.buttonKirmizi.Name = "buttonKirmizi";
            this.buttonKirmizi.Size = new System.Drawing.Size(75, 63);
            this.buttonKirmizi.TabIndex = 2;
            this.buttonKirmizi.UseVisualStyleBackColor = true;
            // 
            // buttonSari
            // 
            this.buttonSari.Location = new System.Drawing.Point(189, 60);
            this.buttonSari.Name = "buttonSari";
            this.buttonSari.Size = new System.Drawing.Size(75, 63);
            this.buttonSari.TabIndex = 3;
            this.buttonSari.UseVisualStyleBackColor = true;
            // 
            // buttonYesil
            // 
            this.buttonYesil.Location = new System.Drawing.Point(271, 60);
            this.buttonYesil.Name = "buttonYesil";
            this.buttonYesil.Size = new System.Drawing.Size(75, 63);
            this.buttonYesil.TabIndex = 4;
            this.buttonYesil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 272);
            this.Controls.Add(this.buttonYesil);
            this.Controls.Add(this.buttonSari);
            this.Controls.Add(this.buttonKirmizi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonKirmizi;
        private System.Windows.Forms.Button buttonSari;
        private System.Windows.Forms.Button buttonYesil;
    }
}

