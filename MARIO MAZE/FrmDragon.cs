using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MARIO_MAZE
{
    public partial class FrmDragon : Form
    {
        public FrmDragon()
        {
            InitializeComponent();
        }
        public FrmOyun fro;
        int sayac = 20;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer3.Start();
            sayac = 20;
            pictureBox6.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            timer1.Start();
            sayac = 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox3.Left += 5;
            if (pictureBox3.Left >= 251)
            {
                timer1.Stop();
                pictureBox3.Visible = false;
                pictureBox9.Visible = true;
                timer2.Start();
                sayac = 20;
            }
             
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac--;
            if (sayac == 7)
            {
                timer2.Stop();
                pictureBox9.Visible = false;
                pictureBox2.Visible = true;
                timer5.Start();
                sayac = 20;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sayac--;
            if (sayac == 12)
            {
                timer3.Stop();
                pictureBox8.Visible = false;
                pictureBox2.Visible = true;
                timer4.Start();
                sayac =20;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            sayac--;
            if (sayac == 19)
            {
                pictureBox1.Visible = false;
                pictureBox12.Visible = true;               
            }
            if (sayac == 18)
            {               
                pictureBox2.Visible = false;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
            }
            if (sayac == 15)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                timer5.Stop();               
                this.Close();
                fro.Show();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            sayac--;
            if (sayac == 18)
            {
                pictureBox10.Visible = true;
                pictureBox1.Visible = false;
            }
            if (sayac == 16)
            {
                pictureBox11.Visible = true;
                pictureBox2.Visible = false;
            }
            if (sayac == 12)
            {                
                pictureBox10.Visible = false;
                pictureBox1.Visible = true;
                pictureBox15.Visible = true;
            }
            if (sayac == 8)
            {
                timer4.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();               
                this.Hide();               
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            sayac--;                        
            if (sayac == 10)
            {
                timer8.Stop();
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox1.Visible = true;
            }            
        }
        string path2 = Application.StartupPath;
        private void FrmDragon_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL=path2+ @"\Music\MARIO MAZE DRAGON.wav";
            axWindowsMediaPlayer1.settings.volume = 30;
            timer8.Start();
            
            
        }

    }
}
