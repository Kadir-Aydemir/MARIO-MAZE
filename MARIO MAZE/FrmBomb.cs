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
    public partial class FrmBomb : Form
    {
        public FrmBomb()
        {
            InitializeComponent();
        }
        int sayac=0;
        private void FrmBomb_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 2)
            {
                pictureBox3.Visible = false;               
                pictureBox16.Visible = true;
            }           
            if (sayac == 4)
            {
                pictureBox15.Visible = true;
                pictureBox16.Visible = false;
                pictureBox46.Visible = true;
            }
            if (sayac == 6)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
