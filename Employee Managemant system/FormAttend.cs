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
    public partial class FormAttend : Form
    {
        public FormAttend()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"data source=LAPTOP-A3DA1N2J;initial catalog=Employee_management;user id=admin;password=admin");

        private void fetchempdata1()
        {

            if (tb_EAid.Text == "")
            {
                MessageBox.Show("Enter Employeee Id");

            }
            else
            {
                string sql = "select * from Employee where Employee_ID='" + tb_EAid.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataTable dt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb_EAid.Text = dr["Employee_ID"].ToString();
                    
                   


                }
            }

        }

        private void populate1()
        {
            con.Open();
            string sql = "select Employee.Employee_ID,Employee.Employee_name,Attendance.Date,Attendance.Attend from Attendance join Employee on Attendance.EID = Employee.Employee_ID; ";
            SqlDataAdapter ada = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            gunaDataGridViewEA.DataSource = ds.Tables[0];
            con.Close();
        }
        private void FormAttend_Load(object sender, EventArgs e)
        {
            populate1();
        }

        private void btn_EAadd_Click(object sender, EventArgs e)
        {
            if(tb_EAid.Text == "" || cmb_EAattend.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = @"insert into  Attendance (Date,Attend,EID)
                values('" + gunaDateTimePickerEA.Value.Date + "','"+cmb_EAattend.SelectedItem.ToString()+"','"+tb_EAid.Text+"');";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    con.Close();
                    populate1();
                   
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_EAsearch_Click(object sender, EventArgs e)
        {
            fetchempdata1();
        }

        private void btn_EAupdate_Click(object sender, EventArgs e)
        {
            if(tb_EAid.Text == "")
            {
                MessageBox.Show("Check Employee Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "update Attendance set  Date='" + gunaDateTimePickerEA.Value.Date + "', Attend='"+cmb_EAattend.SelectedItem.ToString()+ "',EID='"+tb_EAid.Text+ "' where Date='" + gunaDateTimePickerEA.Value.Date + "'; ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Update Successfully");

                    con.Close();
                    populate1();
                    tb_EAid.Text = "";
                    
                    cmb_EAattend.Items.Clear();
                    gunaDateTimePickerEA.Value = DateTime.Now;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gunaDataGridViewEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_EAid.Text = gunaDataGridViewEA.SelectedRows[0].Cells[0].Value.ToString();
            gunaDateTimePickerEA.Value = Convert.ToDateTime(gunaDataGridViewEA.SelectedRows[0].Cells[2].Value);
            cmb_EAattend.SelectedItem = gunaDataGridViewEA.SelectedRows[0].Cells[3].Value.ToString();
            
            
        }

        private void btn_deletesal_Click(object sender, EventArgs e)
        {
            if (tb_EAid.Text == "")
            {
                MessageBox.Show("Enter The Employee Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "delete from Attendance where Date = '" + gunaDateTimePickerEA.Value.Date + "';";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    con.Close();
                    populate1();
                    tb_EAid.Text = "";
                    cmb_EAattend.Items.Clear();
                    gunaDateTimePickerEA.Value = DateTime.Now;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
