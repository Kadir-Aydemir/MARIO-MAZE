using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARIO_MAZE
{
    public partial class FrmGameover : Form
    {
        public FrmGameover()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOyun fr = new FrmOyun();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            fr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            fr.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string path2 = Application.StartupPath;
        private void FrmGameover_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path2+@"\Music\MARIO MAZE GAME OVER.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play() ;
            axWindowsMediaPlayer1.settings.volume = 20;
        }
    }
}
