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
    public partial class vieworder : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=cart_system;username=root;password=;");
        public vieworder()
        {
            InitializeComponent();
        }
        private void populate6()
        {
            con.Open();
           
            string sql = "SELECT * FROM orders";
            MySqlDataAdapter ada = new MySqlDataAdapter(sql, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            gunaDataGridVieworde.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btn_view_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "update orders set orderdetail='"+cmb_d.SelectedItem.ToString()+ "'  where id='" + tb_id.Text + "'; ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Update Successfully");

            con.Close();
            populate6();
        }

        private void vieworder_Load(object sender, EventArgs e)
        {
            populate6();
        }

        private void gunaDataGridVieworde_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = gunaDataGridVieworde.SelectedRows[0].Cells[0].Value.ToString();
            cmb_d.SelectedItem = gunaDataGridVieworde.SelectedRows[0].Cells[9].Value.ToString();
        }
    }
}
