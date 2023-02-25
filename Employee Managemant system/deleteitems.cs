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
using System.IO;

namespace Employee_Managemant_system
{
    public partial class deleteitems : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=cart_system;username=root;password=;");
        public deleteitems()
        {
            InitializeComponent();
        }
        private void populate()
        {
            con.Open();
            string sql = "select id,product_name,product_price,product_qty,product_image,product_code,description from product";
            MySqlDataAdapter ada = new MySqlDataAdapter(sql, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btn_deletei_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "delete from product where id=" +gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString()+"";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Deleted Successfully");
            con.Close();
            populate();
           
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteitems_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
