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
    public partial class GroupEvaluation : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlDataAdapter Adopt;
        public GroupEvaluation()
        {
            InitializeComponent();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ui = new SqlDataAdapter("Select * FROM [Group]", conn);
            DataTable load = new DataTable();
            ui.Fill(load);
            for (int i = 0; i < load.Rows.Count; i++)
            {
                GCB.Items.Add(load.Rows[i]["Id"]);
            }

            SqlDataAdapter ui1 = new SqlDataAdapter("Select Name FROM Evaluation", conn);
            DataTable load1 = new DataTable();
            ui1.Fill(load1);
            for (int i = 0; i < load1.Rows.Count; i++)
            {
                EvalCB.Items.Add(load1.Rows[i]["Name"]);
            }
        }

        private void DataShow()
        {
            conn.Open();
            DataTable all = new DataTable();
            Adopt = new SqlDataAdapter("SELECT * from GroupEvaluation", conn);
            Adopt.Fill(all);
            dataGridView1.DataSource = all;
            conn.Close();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            if (OMTB.Text == "")
            {
                MessageBox.Show("Could not be empty! Please Enter data", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                
            conn.Open();
            string query = "INSERT into GroupEvaluation(GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES ((SELECT Id FROM [Group] WHERE [Group].Id = '" + GCB.Text + "' ), (Select Id FROM Evaluation WHERE Evaluation.Name = '" + EvalCB.Text + "'),'" + OMTB.Text + "', '" + DateTime.Now + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            if (MessageBox.Show("Do You want to save?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Obtained Marks are saved Saved");
            }
            else
            {
                MessageBox.Show("Obtained Marks are not saved!", "Save it Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("Entered Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataShow();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
