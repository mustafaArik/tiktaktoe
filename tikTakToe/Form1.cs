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
        char kazanan = '_';
        PictureBox kazananresim;
        char[,] tahta = new char[3, 3] { { '_', '_', '_' }, { '_', '_', '_' }, { '_', '_', '_' } };

        public Form1()
        {
            InitializeComponent();
        }

        // O ==> tikTakToe.Properties.Resources._1;
        // X ==> tikTakToe.Properties.Resources._2;


        public void oyna(PictureBox resim, byte x, byte y)
        {
            try
            {
                //Boş bir yere mi tıklandı ve Oyun Bitti mi?
                if (tahta[x, y] == '_' && kazanan == '_')
                {
                    //Tahtaya x veya o işareti koy
                    tahta[x, y] = siraKimde;


                    //Resmi ayarla
                    resim.Image = (siraKimde == 'x') ? Properties.Resources._2 : Properties.Resources._1;

                    // oyun bitti mi diye kontrol et.
                    kontrol();

                    //Sırayı bir sonraki kişiye aktar
                    siraKimde = (siraKimde == 'x') ? 'o' : 'x'; //Kısa if else
                    label1.Text = "Sıra : " + siraKimde;
                }
                else
                    MessageBox.Show("Buraya daha önce işaret konmuş.");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata : Oyun hatası, Tahta üzerine işlenemedi.", "Hata");
            }
           
        }


        public void kontrol()
        {
            kazanan_kontrol();
            beraberlik();
        }

        public void kazanan_kontrol()
        {
            try
            {
                // Yatay sıra kontrol
                for (int i = 0; i < 3; i++)
                {
                    if (tahta[i, 0] == tahta[i, 1] && tahta[i, 1] == tahta[i, 2] && tahta[i, 2] != '_')
                    {
                        kazanan = tahta[i, 0];
                        break;
                    }
                }

                // Dikey sıra kontrol
                for (int i = 0; i < 3; i++)
                {
                    if (tahta[0, i] == tahta[1, i] && tahta[1, i] == tahta[2, i] && tahta[2, i] != '_')
                    {

                        kazanan = tahta[0, i];
                        break;
                    }
                }

                // sol çarpraz kontrol
                if (tahta[0, 0] == tahta[1, 1] && tahta[0, 0] == tahta[2, 2])
                {
                    kazanan = tahta[0, 0];
                }

                //sağ çarpraz kontrol
                if (tahta[0, 2] == tahta[1, 1] && tahta[1, 1] == tahta[2, 0] && tahta[2, 0] != '_')
                {
                    kazanan = tahta[0, 2];
                }


                if (kazanan == 'x')
                {
                    pic_x_kazandi.Visible = true;
                    kazananresim = pic_x_kazandi;
                    timer1.Start();
                    //   MessageBox.Show("X KAZANDI");
                }

                if (kazanan == 'o')
                {
                    pic_o_kazandi.Visible = true;
                    kazananresim = pic_o_kazandi;
                    timer1.Start();
                    //    MessageBox.Show("O KAZANDI");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata : Kazanan Belirlenemedi", "Hata");
            }
          
        }

        public void beraberlik()
        {
            try
            {
                bool berabere_mi = true;
                // Berabere kontrolü
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tahta[i, j] == '_')
                        {
                            berabere_mi = false;
                            break;
                        }
                    }
                }

                if (berabere_mi && kazanan == '_')
                {
                    pic_kazanan_yok.Visible = true;
                    kazananresim = pic_kazanan_yok;
                    timer1.Start();
                    // MessageBox.Show("Oyun BERABERE Bitti");
                }            
            }
            catch (Exception)
            {

                MessageBox.Show("Hata : Beraberlik kodunda hata", "Hata");
            }
           
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oyna(pictureBox1,0,0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            oyna(pictureBox2,0,1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            oyna(pictureBox3,0,2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            oyna(pictureBox4,1,0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            oyna(pictureBox5,1,1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            oyna(pictureBox6,1,2);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            oyna(pictureBox7,2,0);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            oyna(pictureBox8,2,1);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            oyna(pictureBox9,2,2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                siraKimde = 'x';
                kazanan = '_';
                kazananresim = null;
                label1.Text = "Sıra : x";

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        tahta[i, j] = '_';
                    }
                }


                pictureBox1.Image = Properties.Resources.Logo_BW;
                pictureBox2.Image = Properties.Resources.Logo_BW;
                pictureBox3.Image = Properties.Resources.Logo_BW;
                pictureBox4.Image = Properties.Resources.Logo_BW;
                pictureBox5.Image = Properties.Resources.Logo_BW;
                pictureBox6.Image = Properties.Resources.Logo_BW;
                pictureBox7.Image = Properties.Resources.Logo_BW;
                pictureBox8.Image = Properties.Resources.Logo_BW;
                pictureBox9.Image = Properties.Resources.Logo_BW;

                pic_o_kazandi.Visible = false;
                pic_x_kazandi.Visible = false;
                pic_kazanan_yok.Visible = false;

                Size size = new Size(368, 335);
                Point konum = new Point(12, 12);

                pic_kazanan_yok.Size = size;
                pic_o_kazandi.Size = size;
                pic_x_kazandi.Size = size;

                pic_kazanan_yok.Location = konum;
                pic_o_kazandi.Location = konum;
                pic_x_kazandi.Location = konum;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata : Baştan başlatılamadı.", "Hata");
            }
           
        }

        public void boyut_kucult(PictureBox resim)
        {
            try
            {
                Size size = resim.Size;

                if (size.Height <= pictureBox1.Size.Height)
                {
                    timer1.Stop();
                }



                size.Height -= 9;
                size.Width -= 9;

                resim.Left += 14;
                resim.Top += 4;

                resim.Size = size;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata : Resim boyutlandırılamadı", "Hata");
            }
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            boyut_kucult(kazananresim);
        }

      

        private void pic_kazanan_yok_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
