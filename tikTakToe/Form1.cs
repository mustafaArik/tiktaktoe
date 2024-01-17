using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tikTakToe
{
    public partial class Form1 : Form
    {
        char siraKimde = 'x';
        public Form1()
        {
            InitializeComponent();
        }

        // O ==> tikTakToe.Properties.Resources._1;
        // X ==> tikTakToe.Properties.Resources._2;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oyna(pictureBox1);
        }

        public void oyna(PictureBox resim)
        {
                if (siraKimde == 'x')
                {
                    resim.Image = Properties.Resources._2;
                    siraKimde = 'o';
                }
                else
                {
                    resim.Image = Properties.Resources._1;
                    siraKimde = 'x';
                }
           

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            oyna(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            oyna(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            oyna(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            oyna(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            oyna(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            oyna(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            oyna(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            oyna(pictureBox9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Logo_BW;
            pictureBox2.Image = Properties.Resources.Logo_BW;
            pictureBox3.Image = Properties.Resources.Logo_BW;
            pictureBox4.Image = Properties.Resources.Logo_BW;
            pictureBox5.Image = Properties.Resources.Logo_BW;
            pictureBox6.Image = Properties.Resources.Logo_BW;
            pictureBox7.Image = Properties.Resources.Logo_BW;
            pictureBox8.Image = Properties.Resources.Logo_BW;
            pictureBox9.Image = Properties.Resources.Logo_BW;
        }
    }
}
