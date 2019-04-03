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
using System.Text.RegularExpressions;

namespace ProjectA
{
    public partial class Group : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlDataAdapter Adopt;
        public Group()
        {
            InitializeComponent();
        }

        private void FN_Click(object sender, EventArgs e)
        {

        }

        private void GTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Group_Load(object sender, EventArgs e)
        {


        }

        private void CBN_Click(object sender, EventArgs e)
        { 
            conn.Open();
            DateTime dt = DateTime.Today;
            string cmd = "INSERT INTO [Group] (Created_On) VALUES (@Created_On)";
            SqlCommand sql1 = new SqlCommand(cmd, conn);
            sql1.Parameters.Add(new SqlParameter("@Created_On", dt));
            int i = sql1.ExecuteNonQuery();
            if (i < 0)
                MessageBox.Show("Error");
            conn.Close();
            MessageBox.Show("Data is Created!");
        }
    }
}
