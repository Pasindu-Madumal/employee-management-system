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
    public partial class Ordermsystemhome : Form
    {
        public Ordermsystemhome()
        {
            InitializeComponent();
            customizedesing();
        }
        private void customizedesing()
        {
            panel4.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panel4.Visible == true)
                panel4.Visible = false;
        }
        private void showsubmenu(Panel panel3)
        {
            if (panel3.Visible == false)
            {
                hidesubmenu();
                panel3.Visible = true;
            }
            else
                panel3.Visible = false;
        }

        private Form activeForm = null;
        private void openchiledForm(Form childForm)
        {
            if (activeForm != null) ;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; ;
            childForm.Dock = DockStyle.Fill;
            panel_home.Controls.Add(childForm);
            panel_home.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btn_or_Click(object sender, EventArgs e)
        {
            openchiledForm(new Users());
        }

        private void btn_attenreport_Click(object sender, EventArgs e)
        {
            openchiledForm(new vieworder());

            hidesubmenu();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            openchiledForm(new FormHome());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showsubmenu(panel4);
        }

        private void Ordermsystemhome_Load(object sender, EventArgs e)
        {
            openchiledForm(new FormHome());
        }

        private void panel_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home2 home2 = new Home2();
            home2.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
