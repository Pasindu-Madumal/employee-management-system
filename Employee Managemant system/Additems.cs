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
    public partial class Additems : Form
    {
        OpenFileDialog opf = new OpenFileDialog();
        MySqlConnection con = new MySqlConnection("server=localhost;database=cart_system;username=root;password=;");
        MySqlCommand cmd;
        public Additems()
        {
            InitializeComponent();
        }
        public byte[] Getimagedata()
        {
            FileStream fs = new FileStream(openFileDialog1.FileName,FileMode.Open, FileAccess.Read);
            byte[] bimagedata = new byte[fs.Length];
            fs.Read(bimagedata, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return bimagedata;

        }
       

        private void btn_browser_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                tb_imgename.Text = Path.GetFileName(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
           
        }

        private void btn_add1_Click(object sender, EventArgs e)
        {

            byte[] bimagedata = Getimagedata();
            con.Open();
            String insertquery = "INSERT INTO product(product_name,product_price,product_qty,product_image,img,product_code,description ) VALUES('"+tb_itemname.Text+"','"+tb_iprice.Text+"','"+tb_qntity.Text+"','"+tb_imgename.Text+"','"+bimagedata+"','"+tb_itemcode.Text+"','"+tb_descrip.Text+"')";
            MySqlCommand cmd = new MySqlCommand(insertquery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Product");
            tb_descrip.Clear();
            tb_imgename.Clear();
            tb_iprice.Clear();
            tb_itemcode.Clear();
            tb_qntity.Clear();
            tb_itemname.Clear();
            pictureBox1.Image = null;





        }
    }
}
