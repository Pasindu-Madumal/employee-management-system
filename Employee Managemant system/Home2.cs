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
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ordermsystemhome oh1 = new Ordermsystemhome();
            oh1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderHome Ohome = new OrderHome();
            Ohome.Show();
        }
    }
}
