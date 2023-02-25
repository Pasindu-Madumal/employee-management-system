using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employee_Managemant_system
{
    public partial class metirail : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=cart_system;username=root;password=;");
        public metirail()
        {
            InitializeComponent();
        }
        private void populate()
        {
            con.Open();
            string sql = "select * from matirials";
            MySqlDataAdapter ada = new MySqlDataAdapter(sql, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_addm_Click(object sender, EventArgs e)
        {
            if (tb_mid.Text == "" || tb_mname.Text == "" || tb_mq.Text == "" || tb_mcode.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = @"insert into  matirials (id,name,quantity,code)
                values('" + tb_mid.Text + "', '" + tb_mname.Text + "', '" + tb_mq.Text + "', '" + tb_mcode.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                    con.Close();
                    populate();
                    tb_mcode.Clear();
                    tb_mid.Clear();
                    tb_mname.Clear();
                    tb_mq.Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void metirail_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_editm_Click(object sender, EventArgs e)
        {
            if (tb_mid.Text == "" || tb_mname.Text == "" || tb_mq.Text == "" || tb_mcode.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    string sql = "update matirials set id='" + tb_mid.Text + "',name='" + tb_mname.Text + "',quantity='" + tb_mq.Text + "',code='"+tb_mcode.Text+"' where id='" + tb_mid.Text + "'; ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");

                    con.Close();
                    populate();
                    tb_mid.Clear();
                    tb_mcode.Clear();
                    tb_mq.Clear();
                    tb_mname.Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_mid.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tb_mname.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tb_mq.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tb_mcode.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void btn_deletem_Click(object sender, EventArgs e)
        {
            if (tb_mid.Text == "")
            {
                MessageBox.Show("Enter The Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "delete from matirials where id = '" + tb_mid.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    con.Close();
                    populate();
                    tb_mid.Clear();
                    tb_mcode.Clear();
                    tb_mq.Clear();
                    tb_mname.Clear();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
