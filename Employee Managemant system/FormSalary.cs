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
    public partial class FormSalary : Form
    {
        public FormSalary()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"data source=LAPTOP-A3DA1N2J;initial catalog=Employee_management;user id=admin;password=admin");
        private void fetchempdata()
        {

            if (tb_EmployeId.Text == "")
            {
                MessageBox.Show("Enter Employeee Id");

            }
            else
            {
                string sql = "select * from Employee where Employee_ID='" + tb_EmployeId.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataTable dt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb_EmployeId.Text = dr["Employee_ID"].ToString();
                    tb_Name.Text = dr["Employee_name"].ToString();
                    tb_pos.Text = dr["Employee_position"].ToString();


                }
            }
            
        }

        private void fetchempdata1()
        {
           
            con.Open();
                string sql = "select Count(*) from Attendance where Date between'"+gunaDateTimePicker1.Value.ToString()+ "' AND '"+gunaDateTimePicker2.Value.ToString()+"' AND EID='"+tb_EmployeId.Text+"' AND Attend=1";
            
            SqlCommand cmd = new SqlCommand(sql, con);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            tb_workday.Text = count.ToString();
                



        }


        private void FormSalary_Load(object sender, EventArgs e)
        {

        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            fetchempdata();
            fetchempdata1();
        }

        int dailybase;
        int total;
        private void btn_view_Click(object sender, EventArgs e)
        {
            if(tb_pos.Text == "")
            {
                MessageBox.Show("Select An Employee");
            }
            else if(tb_workday.Text == "" || Convert.ToInt32( tb_workday.Text) > 28)
            {
                MessageBox.Show("Enter A Valid Number of Days");
            }
            else
            {
                if(tb_pos.Text == "Manager")
                {
                    dailybase = 250;
                }
                else if(tb_pos.Text == "Senior Developer")
                {
                    dailybase = 230;
                }
                else if(tb_pos.Text == "Junior Developer")
                {
                    dailybase = 200;
                }
                else if(tb_pos.Text == "Accountant")
                {
                    dailybase = 240;
                }
                else if(tb_pos.Text == "Receptionist")
                {
                    dailybase = 190;
                }
                total = dailybase * Convert.ToInt32(tb_workday.Text) ;
                tb_totsal.Text = total.ToString();
                Salaryslip.Text = "Employee ID : " + tb_EmployeId.Text + "\n"+"Employee Name : " + tb_Name.Text + "\n" +"Employee Position : "+ tb_pos.Text + "\n" +"Employee Worked Days : "+ tb_workday.Text + "\n" +"Employee Daily basic : "+ dailybase + "\n" +"Employee Total Salary : "+ total;
            }
        }

        private void btn_print1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=======SALARY DOCUMENT=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("Employee Id : " + tb_EmployeId.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 140));
            e.Graphics.DrawString("Employee Position : " + tb_pos.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 180));
            e.Graphics.DrawString("Employee Worked Days : " + tb_workday.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 220));
            e.Graphics.DrawString("Employee Name : " + tb_Name.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 260));
            e.Graphics.DrawString("Employee Daily Pay : " + dailybase , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 300));
            e.Graphics.DrawString("Employee Total Salary : " + total , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Red, new Point(10, 340));
            e.Graphics.DrawString("=======OV Developers=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180, 420));

        }

        private void btn_Addempl_Click(object sender, EventArgs e)
        {
            if (tb_EmployeId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = @"insert into  Salary (Worked_days,Total_Salary,Saldate, EIDSal)
                values('" + tb_workday.Text+"','"+tb_totsal.Text+"','"+gunaDateTimePicker1.Value.Date+"','"+tb_EmployeId.Text+"');";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    con.Close();
                    tb_EmployeId.Text = "";
                    tb_Name.Text = "";
                    tb_pos.Text = "";
                    tb_totsal.Text = "";
                    tb_workday.Text = "";
                    Salaryslip.Clear();
                    gunaDateTimePicker1.Value = DateTime.Now;
                    gunaDateTimePicker2.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tb_pos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SalClesr_Click(object sender, EventArgs e)
        {
            tb_EmployeId.Text = "";
            tb_Name.Text = "";
            tb_pos.Text = "";
            tb_totsal.Text = "";
            tb_workday.Text = "";
            Salaryslip.Clear();
            gunaDateTimePicker1.Value = DateTime.Now;
            gunaDateTimePicker2.Value = DateTime.Now;
        }
    }
}
