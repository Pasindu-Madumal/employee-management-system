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
using System.Drawing.Imaging;

namespace Employee_Managemant_system
{
    
    public partial class edititems : Form
    {
        OpenFileDialog opf = new OpenFileDialog();
        MySqlConnection con = new MySqlConnection("server=localhost;database=cart_system;username=root;password=;");
        MySqlCommand cmd;
        public edititems()
        {
            InitializeComponent();
        }
        public byte[] Getimagedata()
        {
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            byte[] bimagedata = new byte[fs.Length];
            fs.Read(bimagedata, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return bimagedata;

        }

        private void populate()
        {
            MySqlCommand cmd_listID = new MySqlCommand("select * from product", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd_listID);

            con.Open();
            DataTable dataset = new DataTable();
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset;

            //// cell format
            dataGridView1.RowTemplate.Height = 60;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            byte[] bimagedata = Getimagedata();
            con.Open();
            String insertquery = "INSERT INTO product(product_name,product_price,product_qty,product_image,img,product_code,description ) VALUES('" + tb_itemname.Text + "','" + tb_iprice.Text + "','" + tb_qntity.Text + "','" + tb_imgename.Text + "','" + bimagedata + "','" + tb_itemcode.Text + "','" + tb_descrip.Text + "')";
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

        private void edititems_Load(object sender, EventArgs e)
        {
            byte[] bimagedata = Getimagedata();
            populate();
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_imgename.Text = Path.GetFileName(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_itemname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_iprice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_qntity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_imgename.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            tb_itemcode.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_descrip.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();



        }
    }
}
