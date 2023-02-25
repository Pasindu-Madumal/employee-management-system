using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Managemant_system
{
    public partial class FormView : Form
    {

        public FormView()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"data source=LAPTOP-A3DA1N2J;initial catalog=Employee_management;user id=admin;password=admin");
        private void fetchempdata()
        {
            string sql = "select * from Employee where Employee_ID='" + tb_Employeid.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                lbl_eid.Text = dr["Employee_ID"].ToString();
                lbl_name.Text = dr["Employee_name"].ToString();
                lbl_eadd.Text = dr["Employee_address"].ToString();
                lbl_gender.Text = dr["Employee_gender"].ToString();
                lbl_eposi.Text = dr["Employee_position"].ToString();
                lbl_dob.Text = dr["Employee_DOB"].ToString();
                lbl_phone.Text = dr["Employee_phone"].ToString();
                lbl_edu.Text = dr["Employee_education"].ToString();

            }
        }
        private void FormView_Load(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=======EMPLOYEE SUMMARY=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("Employee Id : " + lbl_eid.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10,140));
            e.Graphics.DrawString("Employee Name : " + lbl_name.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 180));
            e.Graphics.DrawString("Employee Address : " + lbl_eadd.Text + "\tEmployee Gender : " + lbl_gender.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 220));
            e.Graphics.DrawString("Employee Position : " + lbl_eposi.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 260));
            e.Graphics.DrawString("Employee DOB : " + lbl_dob.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 300));
            e.Graphics.DrawString("Employee Phone : " + lbl_phone.Text + "\tEmployee Education : " + lbl_edu.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 340));
            e.Graphics.DrawString("=======OV Developers=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180,400));

        }
    }
}
