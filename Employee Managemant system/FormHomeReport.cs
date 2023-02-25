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
    public partial class FormHomeReport : Form
    {
        public FormHomeReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=LAPTOP-A3DA1N2J;initial catalog=Employee_management;user id=admin;password=admin");
       private void getdata()
        {
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("select COUNT(*) from Employee where Employee_position='"+"Manager"+"'", con);
            DataTable dt1 = new DataTable();
            ada.Fill(dt1);
            int manager = Convert.ToInt32(dt1.Rows[0][0].ToString());
            lbl_manader.Text = "" + manager;
            gunaCircleProgressBar1.Value = Convert.ToInt32(manager);

            SqlDataAdapter ada1 = new SqlDataAdapter("select COUNT(*) from Employee where Employee_position='" + "Senior Developer" + "'", con);
            DataTable dt2 = new DataTable();
            ada1.Fill(dt2);
            int SD = Convert.ToInt32(dt2.Rows[0][0].ToString());
            lbl_sd.Text = "" + SD;
            gunaCircleProgressBar2.Value = Convert.ToInt32(SD);

            SqlDataAdapter ada2 = new SqlDataAdapter("select COUNT(*) from Employee where Employee_position='" + "Junior Developer" + "'", con);
            DataTable dt3 = new DataTable();
            ada2.Fill(dt3);
            int JD = Convert.ToInt32(dt3.Rows[0][0].ToString());
            lbl_jd.Text = "" + JD;
            gunaCircleProgressBar3.Value = Convert.ToInt32(JD);

            SqlDataAdapter ada3 = new SqlDataAdapter("select COUNT(*) from Employee where Employee_position='" + "Accountant" + "'", con);
            DataTable dt4 = new DataTable();
            ada3.Fill(dt4);
            int ACC = Convert.ToInt32(dt4.Rows[0][0].ToString());
            lbl_acc.Text = "" + ACC;
            gunaCircleProgressBar4.Value = Convert.ToInt32(ACC);

            SqlDataAdapter ada4 = new SqlDataAdapter("select COUNT(*) from Employee where Employee_position='" + "Receptionist" + "'", con);
            DataTable dt5 = new DataTable();
            ada4.Fill(dt5);
            int REC = Convert.ToInt32(dt5.Rows[0][0].ToString());
            lbl_rec.Text = "" + REC;
            gunaCircleProgressBar5.Value = Convert.ToInt32(REC);

            SqlDataAdapter ada5 = new SqlDataAdapter("select COUNT(*) from Employee", con);
            DataTable dt6 = new DataTable();
            ada5.Fill(dt6);
            int TOT = Convert.ToInt32(dt6.Rows[0][0].ToString());
            label7.Text = "" + TOT;
            gunaCircleProgressBar6.Value = Convert.ToInt32(TOT);



            con.Close();

        }
        private void FormHomeReport_Load(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
