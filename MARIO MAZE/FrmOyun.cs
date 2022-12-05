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
using System.Runtime.InteropServices;

namespace MARIO_MAZE
{
    public partial class FrmOyun : Form
    {
        public FrmOyun()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox75.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox65.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox87.Visible = true;
            pictureBox87.Left += 5;
            if (pictureBox87.Left >= 255)
            {                                
                pictureBox19.Visible = false;                
            }
            if (pictureBox87.Left >= 550)
            {
                timer1.Stop();
                pictureBox87.Visible = false;
                pictureBox54.Visible = true;
                pictureBox44.Visible = true;
                pictureBox45.Visible = true;
                panel9.Visible = true;
                panel6.Visible = true;
                panel20.Visible = true;
            }
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox54.Visible = false;
            pictureBox45.Visible = false;
            pictureBox44.Visible = false;
            pictureBox87.Visible = true;
            pictureBox87.Left += 5;
            if (pictureBox87.Left >= 1111)
            {
                pictureBox20.Visible = false;
            }
            if (pictureBox87.Left >= 1374)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox87.Top += 5;
            if (pictureBox87.Top >= 134)
            {
                timer3.Stop();
                pictureBox87.Visible = false;
                pictureBox13.Visible = true;
                pictureBox36.Visible = true;
                pictureBox37.Visible = true;
                panel27.Visible = true;
                panel29.Visible = true;
                panel20.Visible = true;
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox64.Visible = true;
            pictureBox64.Left -= 5;
            if (pictureBox64.Left <= 648)
            {
                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox64.Top += 5;
            if (pictureBox64.Top >= 240)
            {
                timer5.Stop();
                pictureBox64.Visible = false;
                pictureBox55.Visible = true;
                pictureBox38.Visible = true;
                pictureBox39.Visible = true;
                pictureBox47.Visible = true;
                panel28.Visible = true;
                panel30.Visible = true;
                panel24.Visible = true;
            }
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox55.Visible = false;
            pictureBox47.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox66.Visible = true;
            pictureBox66.Left += 5;
            if (pictureBox66.Left >= 746)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox66.Top += 5;
            if (pictureBox66.Top >= 343)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox66.Left += 5;
            if (pictureBox66.Left >= 941)
            {
                timer8.Stop();
                pictureBox66.Visible = false;
                pictureBox63.Visible = true;
                pictureBox11.Visible = true;
                panel33.Visible = true;
                timer50.Start();
                sayac = 0;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            timer9.Start();
            pictureBox75.Visible = false;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox65.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 541)
            {
                timer9.Stop();
                pictureBox1.Visible = false;
                pictureBox49.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;                
                panel8.Visible = true;
                panel10.Visible = true;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            timer10.Start();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            pictureBox49.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 238)
            {                
                pictureBox17.Visible = false;               
            }
            if (pictureBox1.Left >= 550)
            {
                timer10.Stop();
                pictureBox1.Visible = false;
                pictureBox50.Visible = true;
                pictureBox40.Visible = true;
                pictureBox41.Visible = true;
                panel18.Visible = true;
                panel36.Visible = true;
                panel12.Visible = true;
                panel37.Visible = true;
            }
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            timer11.Start();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            pictureBox50.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 791)
            {
                timer11.Stop();
                pictureBox1.Visible = false;
                pictureBox51.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                panel16.Visible = true;
                panel17.Visible = true;
                panel22.Visible = true;
                panel21.Visible = true;
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            timer12.Start();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            pictureBox51.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 1111)
            {
                pictureBox18.Visible = false;
            }
            if (pictureBox1.Left >= 1374)
            {
                timer12.Stop();
                timer13.Start();
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 679)
            {
                timer13.Stop();
                pictureBox1.Visible = false;
                pictureBox53.Visible = true;
                pictureBox34.Visible = true;
                pictureBox35.Visible = true;
                panel26.Visible = true;
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            timer14.Start();
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            pictureBox51.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox70.Visible = true;
            pictureBox70.Top += 5;
            if (pictureBox70.Top >= 640)
            {
                timer14.Stop();
                timer15.Start();
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            pictureBox70.Left -= 5;
            if (pictureBox70.Left <= 525)
            {
                timer15.Stop();
                timer16.Start();
            }
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            pictureBox70.Top += 5;
            if (pictureBox70.Top >= 740)
            {
                timer16.Stop();
                pictureBox70.Visible = false;
                pictureBox52.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                panel23.Visible = true;
                panel25.Visible = true;
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            timer17.Start();
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            pictureBox52.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox73.Visible = true;
            pictureBox73.Left -= 5;
            if (pictureBox73.Left <= 292)
            {               
                pictureBox67.Visible = false;               
            }
            if (pictureBox73.Left <= 199)
            {
                timer17.Stop();
                pictureBox73.Visible = false;
                pictureBox71.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                panel23.Visible = true;
                panel25.Visible = true;
                panel19.Visible = true;
                panel15.Visible = true;
            }
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            timer18.Start();
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            pictureBox54.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox87.Visible = true;
            pictureBox87.Top += 5;
            if (pictureBox87.Top >= 194)
            {
                timer18.Stop();
                pictureBox87.Visible = false;
                pictureBox74.Visible = true;
                pictureBox42.Visible = true;
                panel34.Visible = true;
                timer19.Start();
            }
        }
        int sayac = 0;
        private void timer19_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {                
                pictureBox74.Visible = false;
                pictureBox43.Visible = true;
            }
            if (sayac == 5)
            {
                timer19.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();
                this.Hide();
            }
        }

        private void btnesc_Click(object sender, EventArgs e)
        {
            FrmPause fr = new FrmPause();
            fr.fro = this;
            fr.Show();
            FrmOyun fro = new FrmOyun();
            fro.Enabled = false;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            timer20.Start();
        }

        private void timer20_Tick(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox87.Visible = true;
            pictureBox87.Top += 5;
            if (pictureBox87.Top >= 381)
            {
                timer20.Stop();
                pictureBox87.Visible = false;
                pictureBox76.Visible = true;
                pictureBox33.Visible = true;
                panel35.Visible = true;
                timer21.Start();
            }
        }

        private void timer21_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {
                pictureBox76.Visible = false;
                pictureBox32.Visible = true;
            }
            if (sayac == 5)
            {
                timer21.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();
                this.Hide();
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            timer22.Start();
        }

        private void timer22_Tick(object sender, EventArgs e)
        {
            pictureBox49.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 679)
            {
                timer22.Stop();
                pictureBox1.Visible = false;
                pictureBox77.Visible = true;
                pictureBox6.Visible = true;
                panel15.Visible = true;
                panel19.Visible = true;
                timer23.Start();
            }
        }

        private void timer23_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {
                pictureBox77.Visible = false;
                pictureBox8.Visible = true;
            }
            if (sayac == 5)
            {
                timer23.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();
                this.Hide();
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            timer24.Start();
        }

        private void timer24_Tick(object sender, EventArgs e)
        {
            pictureBox71.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox73.Visible = true;
            pictureBox73.Left -= 5;
            if (pictureBox73.Left <= 126)
            {
                timer24.Stop();               
                timer25.Start();
            }
        }

        private void timer25_Tick(object sender, EventArgs e)
        {
            pictureBox73.Top -= 5;
            if (pictureBox73.Top <= 641)
            {
                timer25.Stop();
                timer26.Start();
            }
        }

        private void timer26_Tick(object sender, EventArgs e)
        {
            pictureBox73.Visible = false;
            pictureBox78.Visible = true;
            pictureBox78.Left += 5;
            if (pictureBox78.Left >= 347)
            {
                timer26.Stop();
                pictureBox78.Visible = false;
                pictureBox79.Visible = true;
                pictureBox9.Visible = true;               
                timer27.Start();
            }
        }

        private void timer27_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {
                pictureBox79.Visible = false;
                pictureBox57.Visible = true;
            }
            if (sayac == 6)
            {
                timer27.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();
                this.Hide();
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {                       
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;            
            timer28.Start();
        }

        private void timer28_Tick(object sender, EventArgs e)
        {
            pictureBox71.Visible = false;
            pictureBox73.Visible = true;
            pictureBox73.Left -= 5;
            pictureBox71.Left -= 5;
            if (pictureBox73.Left <= 133)
            {
                timer28.Stop();
                pictureBox71.Visible = true;
                pictureBox73.Visible = false;
                timer29.Start();
            }           
        }

        private void timer29_Tick(object sender, EventArgs e)
        {
            sayac++;
            pictureBox7.Visible = true;
            if (sayac == 4)
            {
                timer29.Stop();
                pictureBox7.Visible = false;
                FrmAnimation fr = new FrmAnimation();
                fr.Show();
                sayac = 0;
                timer30.Start();
            }
        }

        private void timer30_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 9)
            {
                timer30.Stop();
                pictureBox71.Visible = false;
                pictureBox77.Visible = true;
                pictureBox6.Visible = true;
                sayac = 0;
                timer23.Start();
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            timer31.Start();
        }

        private void timer31_Tick(object sender, EventArgs e)
        {
            pictureBox52.Visible = false;
            pictureBox31.Visible = false;
            pictureBox30.Visible = false;
            pictureBox72.Visible = true;
            pictureBox72.Left += 5;
            if (pictureBox72.Left >= 727)
            {
                timer31.Stop();
                pictureBox72.Visible = false;               
                pictureBox80.Visible = true;
                pictureBox5.Visible = true;
                panel38.Visible = true;
                timer32.Start();
            }
        }

        private void timer32_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {
                pictureBox80.Visible = false;
                pictureBox81.Visible = true;
            }
            if (sayac == 6)
            {
                timer32.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();
                this.Hide();
            }
        }
     
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            timer33.Start();
        }

        private void timer33_Tick(object sender, EventArgs e)
        {
            pictureBox53.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox69.Visible = true;
            pictureBox69.Top += 5;
            if (pictureBox69.Top >= 740)
            {
                timer33.Stop();
                timer34.Start();
            }
        }

        private void timer34_Tick(object sender, EventArgs e)
        {
            pictureBox69.Left -= 5;
            if (pictureBox69.Left <= 1230)
            {              
                pictureBox68.Visible = false;               
            }
            if (pictureBox69.Left <= 1081)
            {
                timer34.Stop();
                pictureBox69.Visible = false;
                pictureBox82.Visible = true;
                pictureBox14.Visible = true;
                panel32.Visible = true;
                FrmAnimation2 fr = new FrmAnimation2();
                fr.Show();
                sayac = 0;
                timer35.Start();
            }
        }

        private void timer35_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 6)
            {
                pictureBox82.Visible = false;
                pictureBox59.Visible = true;
            }
            if (sayac == 8)
            {
                timer35.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();
                this.Hide();
            }
        }

        private void timer36_Tick(object sender, EventArgs e)
        {
            pictureBox55.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox47.Visible = false;
            pictureBox66.Visible = true;
            pictureBox66.Left += 5;
            if (pictureBox66.Left >= 836)
            {
                timer36.Stop();
                pictureBox66.Visible = false;
                pictureBox83.Visible = true;
                pictureBox15.Visible = true;
                panel33.Visible = true;
                timer37.Start();
            }
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            timer36.Start();
        }

        private void timer37_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {
                pictureBox83.Visible = false;
                pictureBox58.Visible = true;
            }
            if (sayac == 6)
            {
                timer37.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();
                this.Hide();
            }
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            timer38.Start();
        }

        private void timer38_Tick(object sender, EventArgs e)
        {
            pictureBox55.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox47.Visible = false;
            pictureBox66.Visible = true;
            pictureBox66.Top += 5;
            if (pictureBox66.Top >= 381)
            {
                timer38.Stop();
                pictureBox66.Visible = false;
                pictureBox84.Visible = true;
                pictureBox16.Visible = true;
                panel39.Visible = true;
                panel31.Visible = true;
                panel37.Visible = true;
                FrmAnimation3 fr = new FrmAnimation3();
                fr.Show();
                sayac = 0;
                timer39.Start();
            }
        }

        private void timer39_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 7)
            {
                pictureBox84.Visible = false;
                pictureBox60.Visible = true;
            }
            if (sayac == 9)
            {
                timer39.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();
                this.Hide();
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            timer40.Start();
        }

        private void timer40_Tick(object sender, EventArgs e)
        {
            pictureBox53.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox69.Visible = true;
            pictureBox69.Top -= 5;
            if (pictureBox69.Top <= 641)
            {
                timer40.Stop();
                timer41.Start();
            }
        }

        private void timer41_Tick(object sender, EventArgs e)
        {
            pictureBox69.Left -= 5;
            if (pictureBox69.Left <= 888)
            {
                timer41.Stop();
                pictureBox69.Visible = false;
                pictureBox62.Visible = true;
                pictureBox12.Visible = true;
                panel32.Visible = true;
                panel38.Visible = true;
                FrmYildiz fr = new FrmYildiz();
                fr.Show();
                fr.FormClosing += Fr_FormClosing;
            }
        }

        private void Fr_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox85.Visible = true;
            pictureBox86.Visible = true;
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            pictureBox85.Visible = false;
            pictureBox86.Visible = false;
            pictureBox62.Visible = false;
            pictureBox65.Visible = true ;
            pictureBox22.Visible = true;
            pictureBox44.Visible = true;
            pictureBox37.Visible = true;
            pictureBox47.Visible = true;
            pictureBox48.Visible = true;
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            timer42.Start();
        }

        private void timer42_Tick(object sender, EventArgs e)
        {
            pictureBox50.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 355)
            {
                timer42.Stop();
                pictureBox1.Visible = false;
                pictureBox21.Visible = false;
                pictureBox88.Visible = true;               
                panel34.Visible = true;
                panel9.Visible = true;
                panel11.Visible = true;
                timer43.Start();
            }
        }

        private void timer43_Tick(object sender, EventArgs e)
        {
            pictureBox88.Left -= 5;
            if (pictureBox88.Left <= 453)
            {
                timer43.Stop();
                pictureBox4.Visible = true;
                FrmGhost frg = new FrmGhost();
                frg.Show();
                frg.FormClosing += Frg_FormClosing1;
            }
        }

        private void Frg_FormClosing1(object sender, FormClosingEventArgs e)
        {
            timer44.Start();
            timer45.Start();
        }

        private void timer44_Tick(object sender, EventArgs e)
        {
            pictureBox88.Top -= 5;
            if (pictureBox88.Top <= 133)
            {
                timer44.Stop();
                panel13.Visible = true;
                panel14.Visible = true;               
                timer46.Start();
            }
        }

        private void timer46_Tick(object sender, EventArgs e)
        {
            pictureBox88.Left -= 5;
            if (pictureBox88.Left <= 126)
            {
                timer46.Stop();
                pictureBox88.Visible = false;
                pictureBox89.Visible = true;
                pictureBox2.Visible = true;
                sayac = 0;
                timer48.Start();
            }
        }

        private void timer45_Tick(object sender, EventArgs e)
        {
            pictureBox4.Top -= 5;
            if (pictureBox4.Top <= 133)
            {
                timer45.Stop();               
                timer47.Start();
            }
        }

        private void timer47_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left -= 5;
            if (pictureBox4.Left <= 191)
            {
                timer47.Stop();   
            }
        }

        private void timer48_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                timer48.Stop();
                FrmBomb frb = new FrmBomb();
                frb.Show();
                frb.FormClosing += Frb_FormClosing;
            }
        }

        private void Frb_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox89.Visible = false;
            pictureBox56.Visible = true;
            pictureBox2.Visible = false;
            pictureBox46.Visible = true;
            sayac = 0;
            timer49.Start();
        }

        private void timer49_Tick(object sender, EventArgs e)
        {
            sayac++;           
            if (sayac == 3)
            {
                timer49.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmGameover fr = new FrmGameover();
                fr.Show();
                this.Hide();
            }
        }

        private void timer50_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 2)
            {
                timer50.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                FrmDragon frd = new FrmDragon();
                frd.fro = this;
                frd.Show();
                this.Hide();
                frd.FormClosing += Frd_FormClosing;
            }
        }       
        private void Frd_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer51.Start();
            pictureBox11.Visible = false;
            pictureBox3.Visible = true;
            sayac = 0;
        }

        private void timer51_Tick(object sender, EventArgs e)
        {
           
            pictureBox63.Visible = false;
            pictureBox66.Visible = true;
            pictureBox66.Left += 5;
            if (pictureBox66.Left >= 1271)
            {
                timer51.Stop();
                panel21.Visible = true;
                timer52.Start();
            }
        }

        private void timer52_Tick(object sender, EventArgs e)
        {
            pictureBox66.Top += 5;
            if (pictureBox66.Top >= 443)
            {
                timer52.Stop();
                pictureBox66.Visible = false;
                pictureBox90.Visible = true;
                timer53.Start();
            }
        }

        private void timer53_Tick(object sender, EventArgs e)
        {
            pictureBox90.Left -= 5;
            if (pictureBox90.Left <= 866)
            {
                timer53.Stop();
                pictureBox90.Visible = false;
                pictureBox61.Visible = true;
                pictureBox48.Visible = true;
                panel31.Visible = true;
                FrmPrenses frp = new FrmPrenses();
                frp.Show();
                frp.FormClosing += Frp_FormClosing;                
            }
        }

        private void Frp_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer54.Start();
            sayac = 0;
        }

        private void timer54_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                pictureBox10.Visible = true;
                pictureBox61.Visible = false;
                pictureBox91.Visible = true;
            }
            if (sayac == 4)
            {
                timer54.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                FrmEnd fre = new FrmEnd();
                fre.Show();
                this.Hide();
            }
        }
        string path2 = Application.StartupPath;
        private void FrmOyun_Load(object sender, EventArgs e)
        {            
            axWindowsMediaPlayer1.URL= path2+@"\Music\MARIO MAZE RUN.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.volume = 50;
            Trackbar.Value = 50;            
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            pictureBox92.Visible = false;
            pictureBox93.Visible = true;
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            pictureBox92.Visible = true;
            pictureBox93.Visible = false;
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            pictureBox94.Visible = false;
            pictureBox95.Visible = true;
            Trackbar.Visible = true;
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            pictureBox94.Visible = true;
            pictureBox95.Visible = false;
            Trackbar.Visible = false;
        }

        private void Trackbar_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = Trackbar.Value;
            if (Trackbar.Value == 0)
            {
                pictureBox92.Visible = false;
                pictureBox93.Visible = true;
            }
            else
            {
                pictureBox92.Visible = true;
                pictureBox93.Visible = false;
            }        
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
