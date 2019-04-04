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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlDataAdapter Adopt;
        public GroupProject()
        {
            InitializeComponent();
        }

        private void GroupProject_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ui = new SqlDataAdapter("Select Title FROM Project", conn);
            DataTable load = new DataTable();
            ui.Fill(load);
            for (int i = 0; i < load.Rows.Count; i++)
            {

                TPCB.Items.Add(load.Rows[i]["Title"]);
            }
            SqlDataAdapter ui1 = new SqlDataAdapter("Select Id FROM [Group]", conn);
            DataTable load1 = new DataTable();
            ui1.Fill(load1);
            for (int i = 0; i < load1.Rows.Count; i++)
            {
                GCB.Items.Add(load1.Rows[i]["Id"]);
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
            if (GCB.Text == "" && TPCB.Text == "")
            {
                MessageBox.Show("Could not be Empty. Please Enter data!");
            }
            else
                conn.Open();
                string q = "INSERT into GroupProject(ProjectId,GroupId,AssignmentDate) VALUES ((Select Id FROM Project WHERE Title = '" + TPCB.Text + "'), (SELECT Id FROM [Group] WHERE Id = '" + GCB.Text + "'), '" + DateTime.Now + "')";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                if (MessageBox.Show("Do You assign this group, a project title?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Assignment of title is saved!");
                }
                else
                {
                    MessageBox.Show("Assignment of title is saved!", "Save it Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Title saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
        }
    }
}
