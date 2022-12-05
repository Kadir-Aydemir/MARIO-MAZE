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
    public partial class FrmEnd : Form
    {
        public FrmEnd()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            fr.Show();
            this.Hide();
        }
        string path2 = Application.StartupPath;
        private void FrmEnd_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL =path2+ @"\Music\MARIO MAZE VICTORY.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.volume = 20;
        }
    }
}
