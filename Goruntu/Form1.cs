using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goruntu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // resim ekleme
        private void Resim_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "Picture | *.jpg";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = sfd.FileName;
        }

        // gri_yapma
        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = GriYap(image);
            pictureBox1.Image = gri;
        }
        private Bitmap GriYap(Bitmap bmp)
        {

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int yeni = bmp.GetPixel(i,j) / 3;

                    Color renk;
                    renk = Color.FromArgb(yeni, yeni, yeni);

                    bmp.SetPixel(i, j, renk);

                }

            }
            return bmp;
        }
        // negatif yapma
        private void Negatif_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = negatif(image);
            pictureBox1.Image = gri;
        }
        private Bitmap negatif(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int degerR = 255 - bmp.GetPixel(i, j).R;
                    int degerB = 255 - bmp.GetPixel(i, j).B;
                    int degerG = 255 - bmp.GetPixel(i, j).G;
                    Color color;
                    color = Color.FromArgb(degerR, degerG, degerB);
                    bmp.SetPixel(i, j, color);

                }
            }
            return bmp;
        }
        // ters çevirme
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = Ters(image);
            pictureBox1.Image = gri;
        }
        private Bitmap Ters(Bitmap bmp)
        {
            Bitmap bmp1 = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    bmp1.SetPixel(i, j, bmp.GetPixel(i, ((bmp1.Height - 1) - j)));
                }
            }
            return bmp1;
        }
        // aynalama
        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = Ayna(image);
            pictureBox1.Image = gri;
        }
        private Bitmap Ayna(Bitmap bmp)
        {
            Bitmap bmp1 = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    bmp1.SetPixel(i, j, bmp.GetPixel(((bmp1.Width - 1) - i), j));
                }
            }
            return bmp1;
        }
        // -90 DÖNDÜRME
        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = Sag(image);
            pictureBox1.Image = gri;
        }
        private Bitmap Sag(Bitmap bmp)
        {
            Bitmap bmp1 = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    bmp1.SetPixel(i, j, bmp.GetPixel((bmp.Width - 1) - j, i));
                }
            }
            return bmp1;
        }
        // parlaklık(+)
        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = ParlakPozitif(image);
            pictureBox1.Image = gri;
        }
        private Bitmap ParlakPozitif(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int degerR = bmp.GetPixel(i, j).R;
                    int degerB = bmp.GetPixel(i, j).G;
                    int degerG = bmp.GetPixel(i, j).B;
                    if (degerR + 50 < 255)
                    {
                        degerR = degerR + 50;
                    }
                    else
                        degerR = 255;
                    if (degerG + 50 < 255)
                    {
                        degerG = degerG + 50;
                    }
                    else
                    {
                        degerG = 255;
                    }
                    if (degerB + 50 < 255)
                    {
                        degerB = degerB + 50;
                    }
                    else
                        degerB = 255;
                    Color color = Color.FromArgb(degerR, degerG, degerB);
                    bmp.SetPixel(i, j, color);
                }

            }

            return bmp;
        }
        // parlaklık(-)
        private void button7_Click(object sender, EventArgs e)
        {

            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = ParlaklıkNegatif(image);
            pictureBox1.Image = gri;

        }
        private Bitmap ParlaklıkNegatif(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int degerR = bmp.GetPixel(i, j).R;
                    int degerB = bmp.GetPixel(i, j).G;
                    int degerG = bmp.GetPixel(i, j).B;
                    if (degerR - 50 > 0)
                        degerR = degerR - 50;
                    else
                        degerR = 0;
                    if (degerG - 50 > 0)
                        degerG = degerG - 50;
                    else
                        degerG = 0;
                    if (degerB - 50 > 0)
                        degerB = degerB - 50;
                    else
                        degerB = 0;
                    Color color = Color.FromArgb(degerR, degerG, degerB);
                    bmp.SetPixel(i, j, color);
                }

            }

            return bmp;
        }
     }
    }  
