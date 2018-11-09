using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOMJudgeProblemCreator
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private int i = 0;
        private Random random = new Random();

        private void Splash_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.terminate = false;
            timer2.Enabled = true;
        }

        private void openNext()
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == 100)
            {
                openNext();
            }
            if(i == 0)
            {
                pictureBox1.Image = Properties.Resources.Splash1;
                i++;
            }
            else if(i == 1)
            {
                pictureBox1.Image = Properties.Resources.Splash2;
                i++;
            }
            else if(i == 2)
            {
                pictureBox1.Image = Properties.Resources.Splash3;
                i++;
            }
            else if(i == 3)
            {
                pictureBox1.Image = Properties.Resources.Splash4;
                i = 0;
            }

            try
            {
                progressBar1.Value += random.Next(0, 10);
            }
            catch
            {
                progressBar1.Value = 100;
            }

        }

        private void Splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                openNext();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.terminate)
            {
                this.Close();
            }
        }
    }
}
