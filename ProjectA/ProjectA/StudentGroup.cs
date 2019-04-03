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
    public partial class StudentGroup : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlDataAdapter Adopt;
        public StudentGroup()
        {
            InitializeComponent();
        }

        private void SGTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentGroup_Load(object sender, EventArgs e)
        {

        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            if (GSTB.Text != "" && SGTB.Text != "" )
            {
                conn.Open();
               // string Status;
               // Status = string.Format("SELECT Id from Lookup WHERE Category = 'STATUS' AND Value = '{0}'", StatusCB.Text);
               // SqlCommand cmd = new SqlCommand(Status, conn);
               // int id = (Int32)cmd.ExecuteScalar();
                string q1 = ("Insert into GroupStudent(groupId, StudentId, Status, AssignmentDate)" + " VALUES (@Gid, (Select Id FROM Student WHERE RegistrationNo = @reg), (SELECT Id From Lookup WHERE Category = 'STATUS' and Value = @status), @Assigndate)");
                SqlCommand cmd1 = new SqlCommand(q1, conn);
                cmd1.Parameters.AddWithValue("@Gid", GSTB.Text);
                cmd1.Parameters.AddWithValue("@reg", SGTB.Text);
                cmd1.Parameters.AddWithValue("@status", textBox1.Text);
                cmd1.Parameters.AddWithValue("@Assigndate", DateTime.Now);
                cmd1.ExecuteNonQuery();
                cmd1.Parameters.Clear();
                MessageBox.Show("Data is inserted!");
                conn.Close();
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

        }

        private void SGTB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SGTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(SGTB.Text, "^[0-9]{4}-[A-Z]{2}-[0-9]{2,3}$"))
            {
                MessageBox.Show("Invalid Registeration number");
                SGTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
