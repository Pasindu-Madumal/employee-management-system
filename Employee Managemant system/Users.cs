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
   
    public partial class Users : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=cart_system;username=root;password=;");
        public Users()
        {
            InitializeComponent();
        }
        private void populate6()
        {
            con.Open();
            string sql = "SELECT name,email,phone,address FROM orders";
            MySqlDataAdapter ada = new MySqlDataAdapter(sql, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            gunaDataGridViewusers.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Users_Load(object sender, EventArgs e)
        {
            populate6();
        }
    }
}
