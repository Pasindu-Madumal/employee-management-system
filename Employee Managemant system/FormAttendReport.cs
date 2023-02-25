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
    public partial class FormAttendReport : Form
    {
        public FormAttendReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=LAPTOP-A3DA1N2J;initial catalog=Employee_management;user id=admin;password=admin");
        private void populate5()
        {
            con.Open();
            string sql = "select Employee.Employee_ID,Employee.Employee_name,Employee_position,Attendance.Date,Attendance.Attend from Attendance join Employee on Attendance.EID = Employee.Employee_ID where Date='"+date_Attendrep.Value.Date+"'";
            SqlDataAdapter ada = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            gunaDataGridViewAttre.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_SALRE_Click(object sender, EventArgs e)
        {
            populate5();
        }
        Bitmap bmp;
        private void btn_print_Click(object sender, EventArgs e)
        {
            int height = gunaDataGridViewAttre.Height;
            gunaDataGridViewAttre.Height = gunaDataGridViewAttre.RowCount * gunaDataGridViewAttre.RowTemplate.Height * 2;
            bmp = new Bitmap(gunaDataGridViewAttre.Width, gunaDataGridViewAttre.Height);
            gunaDataGridViewAttre.DrawToBitmap(bmp, new Rectangle(0, 0, gunaDataGridViewAttre.Width, gunaDataGridViewAttre.Height));
            gunaDataGridViewAttre.Height = height;
            printPreviewDialog1.ShowDialog();
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
    }
}
