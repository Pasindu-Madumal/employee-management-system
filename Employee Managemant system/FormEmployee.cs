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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"data source=LAPTOP-28JJPG7V\SQLEXPRESS;initial catalog=Employee_management;user id=pasi99;password=1234");
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_Employeid.Text == "" || tb_name.Text == "" || tb_address.Text =="" || tb_phone.Text == "" || cmb_position.Text == "" || cmb_edu.Text == "" || cmb_gender.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = @"insert into  Employee (Employee_ID,Employee_name,Employee_address, Employee_gender,Employee_position,Employee_DOB,Employee_phone,Employee_education)
                values('" + tb_Employeid.Text + "', '" + tb_name.Text + "', '" + tb_address.Text + "', '" + cmb_gender.SelectedItem.ToString()+ "','"+cmb_position.SelectedItem.ToString()+"','"+emp_dob.Value.Date+"','"+tb_phone.Text+"','"+cmb_edu.SelectedItem.ToString()+"');";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    con.Close();
                    populate();
                    tb_phone.Clear();
                    tb_Employeid.Clear();
                    tb_address.Clear();
                    tb_name.Clear();
                    cmb_edu.Items.Clear();
                    cmb_position.Items.Clear();
                    cmb_gender.Items.Clear();
                    emp_dob.Value = DateTime.Now;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void populate()
        {
            con.Open();
            string sql = "select * from Employee";
            SqlDataAdapter ada = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(tb_Employeid.Text == "")
            {
                MessageBox.Show("Enter The Employee Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "delete from Employee where Employee_ID = '" + tb_Employeid.Text + "';";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    con.Close();
                    populate();
                    tb_phone.Clear();
                    tb_Employeid.Clear();
                    tb_address.Clear();
                    tb_name.Clear();
                    cmb_edu.Items.Clear();
                    cmb_position.Items.Clear();
                    cmb_gender.Items.Clear();
                    emp_dob.Value = DateTime.Now;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Employeid.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tb_name.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tb_address.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cmb_gender.SelectedItem = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cmb_position.SelectedItem = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            emp_dob.Value = Convert.ToDateTime(gunaDataGridView1.SelectedRows[0].Cells[5].Value);
            tb_phone.Text = gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cmb_edu.SelectedItem = gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tb_Employeid.Text == "" || tb_name.Text == "" || tb_address.Text == "" || tb_phone.Text == "" || cmb_position.Text == "" || cmb_edu.Text == "" || cmb_gender.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    string sql = "update Employee set  Employee_ID='" + tb_Employeid.Text + "',Employee_name='" + tb_name.Text + "',Employee_address='" + tb_address.Text + "',Employee_gender='" + cmb_gender.SelectedItem.ToString() + "',Employee_position='"+cmb_position.SelectedItem.ToString()+ "',Employee_DOB='"+emp_dob.Value.Date+ "',Employee_phone='"+tb_phone.Text+ "',Employee_education='"+cmb_edu.SelectedItem.ToString()+ "' where Employee_ID='"+tb_Employeid.Text+"'; ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Update Successfully");

                    con.Close();
                    populate();
                    tb_phone.Clear();
                    tb_Employeid.Clear();
                    tb_address.Clear();
                    tb_name.Clear();
                    cmb_edu.Items.Clear();
                    cmb_position.Items.Clear();
                    cmb_gender.Items.Clear();
                    emp_dob.Value = DateTime.Now;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
