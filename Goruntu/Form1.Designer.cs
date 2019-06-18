namespace Goruntu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Resim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Negatif = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(388, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Resim
            // 
            this.Resim.Location = new System.Drawing.Point(44, 31);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(319, 38);
            this.Resim.TabIndex = 2;
            this.Resim.Text = "Resim Seç";
            this.Resim.UseVisualStyleBackColor = true;
            this.Resim.Click += new System.EventHandler(this.Resim_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gri Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Negatif
            // 
            this.Negatif.Location = new System.Drawing.Point(44, 90);
            this.Negatif.Name = "Negatif";
            this.Negatif.Size = new System.Drawing.Size(150, 38);
            this.Negatif.TabIndex = 4;
            this.Negatif.Text = "Negatif Alma";
            this.Negatif.UseVisualStyleBackColor = true;
            this.Negatif.Click += new System.EventHandler(this.Negatif_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ters Çevir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Aynalama";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(319, 36);
            this.button5.TabIndex = 7;
            this.button5.Text = "90 Derece";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(44, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "parlaklık(+)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(213, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 37);
            this.button7.TabIndex = 9;
            this.button7.Text = "parlaklık(-)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Negatif);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resim);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Resim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Negatif;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

