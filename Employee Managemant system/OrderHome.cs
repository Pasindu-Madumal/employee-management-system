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
    public partial class OrderHome : Form
    {
        public OrderHome()
        {
            InitializeComponent();
            customizedesing();

        }
        private void customizedesing()
        {
            panel3.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panel3.Visible == true)
                panel3.Visible = false;
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
            panel_home1.Controls.Add(childForm);
            panel_home1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            
            openchiledForm(new itemview());
            showsubmenu(panel3);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            openchiledForm(new FormHome());
        }

        private void OrderHome_Load(object sender, EventArgs e)
        {

            openchiledForm(new FormHome());
        }

        private void btn_sala_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchiledForm(new Additems());


            hidesubmenu();
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

        private void Menupanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openchiledForm(new deleteitems());

            hidesubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchiledForm(new metirail());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchiledForm(new edititems());
            hidesubmenu();
        }
    }
}
