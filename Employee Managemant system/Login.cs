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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_userid.Text == "Admin" && tb_password.Text == "Admin")
            {
                this.Hide();
                Home2 home2 = new Home2();
                home2.Show();
                
            }
            else if (tb_userid.Text == "Store" && tb_password.Text == "1234")
            {
                this.Hide();
                OrderHome od = new OrderHome();
                od.Show();
                

            }
            else
            {
                MessageBox.Show("Check Again User Id and Password");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_userid.Clear();
            tb_password.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
