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
    public partial class ProjectAdvisor : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlDataAdapter Adopt;
        public ProjectAdvisor()
        {
            InitializeComponent();
        }

        private void ProjectAdvisor_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ada = new SqlDataAdapter("Select Title FROM Project", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TCB.Items.Add(dt.Rows[i]["Title"]);
            }
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            if (ATB.Text != "")
            {
                conn.Open();


                string query = "INSERT into ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES ( (SELECT Id FROM Advisor WHERE Advisor.Id = '" + ATB.Text + "' ), (Select Id FROM Project WHERE Title = '" + TCB.Text + "'), (SELECT Id FROM Lookup WHERE Category = 'ADVISOR_ROLE' AND Value = '" + ACB.Text + "'), '" + DateTime.Now + "')";
                //(SELECT Advisor.Id FROM (Person JOIN Advisor ON Advisor.Id = Person.Id)  WHERE FirstName =  @fname And LastName = @lname) 
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@fname", fName.Text);
                //cmd.Parameters.AddWithValue("@advisor", adv.Text);
                //cmd.Parameters.AddWithValue("@title", title.Text);
                //cmd.Parameters.AddWithValue("@desig", comboBox1.Text);
                //cmd.Parameters.AddWithValue("@assignment", DateTime.Now);

                cmd.ExecuteNonQuery();
                conn.Close();
                if (MessageBox.Show("Do You want to save Advisor Role?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Advisor role is Saved");
                }
                else
                {
                    MessageBox.Show("Advisor role is not saved", "Save it Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
                MessageBox.Show("Empty boxes are not valid. Please Fill them!");
        }
    }
}
