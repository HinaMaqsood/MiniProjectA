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
    public partial class Project : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlDataAdapter Adopt;
        SqlCommand command;
        int Norm = 0;
        public Project()
        {
            InitializeComponent();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            DataShow();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void DataShow()
        {
            conn.Open();
            DataTable all = new DataTable();
            Adopt = new SqlDataAdapter("select * from Project", conn);
            Adopt.Fill(all);
            dataGridView1.DataSource = all;
            conn.Close();
        }
        private void DataClean()
        {
            titleTB.Text = "";
            descTB.Text = "";
            Norm = 0;
        }

        private void createbutton_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand c = new SqlCommand("SELECT COUNT(*) FROM Project WHERE (Title = @user  )", conn);
            c.Parameters.AddWithValue("@user", titleTB.Text);


            int user = (int)c.ExecuteScalar();
            conn.Close();
            if (user > 0)
            {
                MessageBox.Show("Project is already Present.");
            }
            else
            {
                conn.Open();
                if (titleTB.Text != "" && descTB.Text != "")
                {
                    string insertit = "INSERT into Project(Description, Title) values ('" + descTB.Text + "' , '" + titleTB.Text + "')";
                    SqlCommand offset = new SqlCommand(insertit, conn);
                    int i = offset.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Inserted Successfully");
                    DataShow();
                    DataClean();
                }
                else
                {
                    MessageBox.Show("Please Enter Details!");
                }
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (titleTB.Text != "" && descTB.Text != "")
            {
                command = new SqlCommand("UPDATE Project set Description=@desc,Title=@title where Id=@id", conn);
                conn.Open();
                command.Parameters.AddWithValue("@id", Norm);
                command.Parameters.AddWithValue("@desc", descTB.Text);
                command.Parameters.AddWithValue("@title", titleTB.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                conn.Close();
                DataShow();
                DataClean();
            }
            else
            {
                MessageBox.Show("Please Select Data to Update");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (Norm != 0)
            {
                command = new SqlCommand("DELETE Project where ID=@id", conn);
                conn.Open();
                command.Parameters.AddWithValue("@id", Norm);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data is Deleted!");
                DataShow();
                DataClean();
            }
            else
            {
                MessageBox.Show("Select Data to Delete");
            }



        }

        private void titleTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(titleTB.Text, "^([A-Za-z])+( [A-Za-z]+)$").Success)
            {

                MessageBox.Show("Enter Name correctly or Enter first letter capital");
                titleTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void FN_Click(object sender, EventArgs e)
        {

        }

        private void titleTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

