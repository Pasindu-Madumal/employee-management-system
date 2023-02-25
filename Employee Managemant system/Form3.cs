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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
       
        
            SqlConnection con = new SqlConnection(@"data source=LAPTOP-A3DA1N2J;initial catalog=Employee_management;user id=admin;password=admin");
        
        private void populate4()
        {
            
            con.Open();
            string sql = "select Employee.Employee_ID, Employee.Employee_name, Employee.Employee_position,Salary.Worked_days,Salary.Total_Salary, Salary.Saldate from Salary join Employee ON Employee.Employee_ID = Salary.EIDSal where Saldate between '"+time_From.Value.ToString()+"' and '"+time_to.Value.ToString()+"'";
            SqlDataAdapter ada = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            gunaDataGridViewsalre.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            
            populate4();
        }
        Bitmap bmp;
        private void btn_print_Click(object sender, EventArgs e)
        {
            int height = gunaDataGridViewsalre.Height;
            gunaDataGridViewsalre.Height = gunaDataGridViewsalre.RowCount * gunaDataGridViewsalre.RowTemplate.Height * 2;
            bmp = new Bitmap(gunaDataGridViewsalre.Width, gunaDataGridViewsalre.Height);
            gunaDataGridViewsalre.DrawToBitmap(bmp, new Rectangle(0, 0, gunaDataGridViewsalre.Width, gunaDataGridViewsalre.Height));
            gunaDataGridViewsalre.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
