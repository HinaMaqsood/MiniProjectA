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

namespace ProjectA
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True;");
        SqlCommand command;
        SqlDataAdapter prog;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select * from Person", conn);
            prog.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void ClearData()
        {
            FNTB.Text = "";
            LNTB.Text = "";
            ContactNoTB.Text = "";
            EmailTB.Text = "";
            DOBTB.Text = "";
            Id = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gendercombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void createbutton_Click(object sender, EventArgs e)
        {
            if (FNTB.Text != "" && LNTB.Text != "" && ContactNoTB.Text != "" && EmailTB.Text != "" && DOBTB.Text != "")
            {
                command = new SqlCommand("insert into Person(FirstName,LastName,Contact,Email,DateOfBirth) values(@FirstName,@LastName,@Contact,@Email,@DateOfBirth)", conn);
                conn.Open();
                command.Parameters.AddWithValue("@FirstName", FNTB.Text);
                command.Parameters.AddWithValue("@LastName", LNTB.Text);
                command.Parameters.AddWithValue("@Contact", ContactNoTB.Text);
                command.Parameters.AddWithValue("@Email", EmailTB.Text);
                command.Parameters.AddWithValue("@DateOfBirth", DOBTB.Text);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted Successfully");
                DisplayData();
                ClearData();
               
            }
            else
            {
                MessageBox.Show("Please Enter Details!");
            }
        }
       
        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (FNTB.Text != "" && LNTB.Text != "" && ContactNoTB.Text != "" && EmailTB.Text != "" && DOBTB.Text != "")
            {
                command = new SqlCommand("update Person set FirstName=@FN,LastName=@LN, Contact=@Cont, Email=@EM, DateOfBirth=@DOB where Id=@id", conn);
                conn.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@FN", FNTB.Text);
                command.Parameters.AddWithValue("@LN", LNTB.Text);
                command.Parameters.AddWithValue("@Cont", ContactNoTB.Text);
                command.Parameters.AddWithValue("@EM", EmailTB.Text);
                command.Parameters.AddWithValue("@DOB", DOBTB.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Data to Update");
            }
        }
        
        private void FN_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            FNTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LNTB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ContactNoTB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            EmailTB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            DOBTB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                command = new SqlCommand("delete Person where ID=@id", conn);
                conn.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Data to Delete");
            }
        }
       
    }
}
