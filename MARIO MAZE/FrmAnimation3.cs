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
    public partial class FrmAnimation3 : Form
    {
        public FrmAnimation3()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void FrmAnimation3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            if (sayac == 6)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
