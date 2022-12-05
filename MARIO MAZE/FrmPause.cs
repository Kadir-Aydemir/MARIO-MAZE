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
    public partial class FrmPause : Form
    {
        public FrmPause()
        {
            InitializeComponent();
        }
        public FrmOyun fro;       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOyun fr = new FrmOyun();
            fr.Show();
            fro.Close();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmGiris frg = new FrmGiris();
            frg.Show();
            fro.Close();
            this.Close();
        }
    }
}
