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
    public partial class Evaluation : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlDataAdapter Adopt;
        SqlCommand command;
        int Norm = 0;
        public Evaluation()
        {
            InitializeComponent();
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            conn.Open();
            DataTable all = new DataTable();
            Adopt = new SqlDataAdapter("SELECT Id, Name, TotalMarks, TotalWeightage from Evaluation", conn);
            Adopt.Fill(all);
            dataGridView1.DataSource = all;
            conn.Close();
        }
        private void DataClear()
        {
            NameTB.Text = "";
            TotalMTB.Text = "";
            TotalWTB.Text = "";
            Norm = 0;
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (NameTB.Text != "" && TotalMTB.Text != "" && TotalWTB.Text != "")
            {
                string per = "INSERT into Evaluation(Name, TotalMarks, TotalWeightage) values ('" + NameTB.Text + "' , '" + TotalMTB.Text + "','"  + TotalWTB.Text + "')";
                SqlCommand persi = new SqlCommand(per, conn);
                int i = persi.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted Successfully");
                DisplayData();
                DataClear();
            }
            else
            {
                MessageBox.Show("Please Enter Details!");
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (NameTB.Text != "" && TotalMTB.Text != "" && TotalWTB.Text != "")
            {
                command = new SqlCommand("UPDATE Evaluation set Name=@name,TotalMarks=@marks, TotalWeightage = @weight where Id=@id", conn);
                conn.Open();
                command.Parameters.AddWithValue("@id", Norm);
                command.Parameters.AddWithValue("@name", NameTB.Text);
                command.Parameters.AddWithValue("@marks", TotalMTB.Text);
                command.Parameters.AddWithValue("@weight", TotalWTB.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Updated data");
                conn.Close();
                DisplayData();
                DataClear();
            }
            else
            {
                MessageBox.Show("Select Data to Update it");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (Norm != 0)
            {
                command = new SqlCommand("DELETE Evaluation where ID=@Id", conn);
                conn.Open();
                command.Parameters.AddWithValue("@id", Norm);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Deleted Successfully!");
                DisplayData();
                DataClear();
            }
            else
            {
                MessageBox.Show("Please Select Data to Delete");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Norm = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            NameTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TotalMTB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TotalWTB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(NameTB.Text, "^([A-Za-z])+( [A-Za-z]+)$").Success)
            {

                MessageBox.Show("Enter Name correctly or Enter first letter capital");
                NameTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void NameTB_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_SizeChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_Move(object sender, EventArgs e)
        {

        }

        private void NameTB_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void NameTB_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
