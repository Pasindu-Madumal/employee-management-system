using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Managemant_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            gunaCircleProgressBar1.Value = startpoint;
            if(gunaCircleProgressBar1.Value == 100)
            {
                gunaCircleProgressBar1.Value = 0;
                timer1.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
