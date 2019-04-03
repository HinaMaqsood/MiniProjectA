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
    public partial class GroupProject : Form
    {
        public GroupProject()
        {
            InitializeComponent();
           
        }


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlDataAdapter Adopt;

        private void GroupProject_Load(object sender, EventArgs e)
        {
            SqlDataAdapter s = new SqlDataAdapter("Select Title FROM Project", conn);
            DataTable dt = new DataTable();
            s.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                TPCB.Items.Add(dt.Rows[i]["Title"]);
            }
            SqlDataAdapter sd = new SqlDataAdapter("Select Id FROM [Group]", conn);
            DataTable d = new DataTable();
            sd.Fill(d);
            for (int i = 0; i < d.Rows.Count; i++)
            {
                GCB.Items.Add(d.Rows[i]["Id"]);
            }
        }

        private void DisplayData()
        {

            DataTable dt = new DataTable();
            Adopt = new SqlDataAdapter("select  Project.Title, GroupProject.GroupId , GroupProject.AssignmentDate FROM Project join GroupProject on Project.Id = GroupProject.ProjectId  ", conn);
            Adopt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            if (GCB.Text != "" && TPCB.Text != "")
            {
                conn.Open();


                string q = "INSERT into GroupProject(ProjectId,GroupId,AssignmentDate) VALUES (  (Select Id FROM Project WHERE Title = '" + TPCB.Text + "'), (SELECT Id FROM [Group] WHERE Id = '" + GCB.Text + "'), '" + DateTime.Now + "')";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();

            }
            else
                MessageBox.Show("Enter Data to insert");
        }
    }
}
