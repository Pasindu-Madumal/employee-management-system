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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            customizedesing();
        }

        private void customizedesing()
        {
            panel2.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
        }

        private void showsubmenu(Panel panel2)
        {
            if (panel2.Visible == false)
            {
                hidesubmenu();
                panel2.Visible = true;
            }
            else
                panel2.Visible = false;
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

        private void btn_view_Click(object sender, EventArgs e)
        {
            openchiledForm(new FormHome());
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count < 3)
            {
                pictureBox2.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
            

        }

        private void btn_view_Click_1(object sender, EventArgs e)
        {
            openchiledForm(new FormView());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_employee_Click_1(object sender, EventArgs e)
        {
            openchiledForm(new FormEmployee());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer2.Start();
            openchiledForm(new FormHome());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_sala_Click(object sender, EventArgs e)
        {
            openchiledForm(new FormSalary());
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            

            
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("HH:mm");
            labelsec.Text = DateTime.Now.ToString("ss");
            labelyear.Text = DateTime.Now.ToString("MMM dd yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd");
        }

        private void btn_salreport_Click(object sender, EventArgs e)
        {
            openchiledForm(new FormReport());


            hidesubmenu();
        }

        private void btn_re_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_re_Click_1(object sender, EventArgs e)
        {
            openchiledForm(new FormHomeReport());
            showsubmenu(panel2);
        }

        private void btn_attends_Click(object sender, EventArgs e)
        {
            openchiledForm(new FormAttend());
        }

        private void btn_attenreport_Click(object sender, EventArgs e)
        {
            openchiledForm(new FormAttendReport());
            showsubmenu(panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home2 home2 = new Home2();
            home2.Show();
        }

        private void Menupanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
