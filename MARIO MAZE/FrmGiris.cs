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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OYUNUMUZDA MARIO,PRENSESİ KURTARMAK İÇİN BAZI ZORLU YOLLARDAN GEÇECEKTİR.\n\nLABİRENTİN YOLLARI SİZİN KARAR VERDİĞİNİZ YÖNE DOĞRU BELİRGİNLEŞİR.\n\nÖLÜRSENİZ OYUN BİTER.\n\nPRENSESİ KURTARIRSANIZ OYUN BAŞARIYLA BİTER :)\n\nBU ZORLU GÖREVDE ŞİMDİDEN BAŞARILAR.\n\nİHTİYACINIZ OLACAK ;)", "KURALLAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrmOyun fr = new FrmOyun();
            fr.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU OYUN KADİR AYDEMİR TARAFINDAN YAPILMIŞ,\n22 SAAT SÜRMÜŞ ve 1 Mayıs 2021'de BİTİRİLMİŞTİR.", "ABOUT ME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
