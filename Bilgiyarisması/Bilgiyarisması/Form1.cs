using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgiyarisması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sorusayisi = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnB.Text;


            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }

            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnC.Text;


            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }

            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnD.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }

            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            sorusayisi++;
            LblSoruno.Text = sorusayisi.ToString();
            BtnSonraki.Enabled = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (sorusayisi == 1)
            {
                BtnSonraki.Text = "Sonraki";
                richTextBox1.Text = "Türkiye'de kaç tane şehir vardır?";
                BtnA.Text = "80";
                BtnB.Text = "81";
                BtnC.Text = "82";
                BtnD.Text = "83";
                label4.Text = "81";
            }

            if (sorusayisi == 2)
            {
                BtnSonraki.Text = "Sonraki";
                richTextBox1.Text = "Türkiye hangi yarım kürede bulunmaktadır?";
                BtnA.Text = "Kuzey";
                BtnB.Text = "Güney";
                BtnC.Text = "Doğu";
                BtnD.Text = "Batı";
                label4.Text = "Kuzey";
            }

            if (sorusayisi == 3)
            {
                BtnSonraki.Text = "Sonuçlar";
                richTextBox1.Text = "Türkiye hangi yönetim sistemiyle yönetilmektedir?";
                BtnA.Text = "Başkanlık";
                BtnB.Text = "Parlamental";
                BtnC.Text = "Dikdatörlük";
                BtnD.Text = "Yönetim sistemi yok";
                label4.Text = "Başkanlık";
            }

            if (sorusayisi == 4)
            {
                BtnSonraki.Enabled = false;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;

                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnA.Text;


            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }

            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}