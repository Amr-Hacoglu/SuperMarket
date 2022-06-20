using System;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        int startPoint = 0;  // for timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            MyProgress.Value = startPoint; // myProgress the name of the object in Spalsh form
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
