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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 3)
            {
                pictureBoxhome.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("HH:mm");
            labelsec.Text = DateTime.Now.ToString("ss");
            labelyear.Text = DateTime.Now.ToString("MMM dd yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd");
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
