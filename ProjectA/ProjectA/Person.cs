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
    public partial class Person : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlCommand command;
        SqlDataAdapter prog;
        int Id = 0;
        public Person()
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
            DTTB.Text = "";
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

        int value;
        private int GetGenderFromLookup(string gen)
        {
            
            string q;
            if (gen == "Male")
                q = "SELECT Id FROM Lookup where Category = 'GENDER' AND Value = 'Male'";
            else
                q = "SELECT Id FROM Lookup where Category = 'GENDER' AND Value = 'Female'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                {
                    value = int.Parse(reader[0].ToString());
                }
            return value;
        }

        
     //   string idQuery = "SELECT SCOPE_IDENTITY() AS LastInsertedSubmissionId";
        private int RetriveID()
        {
            int value = 0;
            
                string query = "Select Id from Person where (Id = SCOPE_IDENTITY());";
                if(conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand command = new SqlCommand(query, conn);
                var val = command.ExecuteScalar().ToString();
                value = int.Parse(val);
                return value;
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            if (FNTB.Text != "" && LNTB.Text != "" && ContactNoTB.Text != "" && EmailTB.Text != "" && DTTB.Text != "" && RegnoTB.Text != "")
            {
                command = new SqlCommand("insert into Person(FirstName,LastName,Contact,Email,DateOfBirth) values(@FirstName,@LastName,@Contact,@Email,@DateOfBirth)", conn);
                conn.Open(); 
                command.Parameters.AddWithValue("@FirstName", FNTB.Text);
                command.Parameters.AddWithValue("@LastName", LNTB.Text);
                command.Parameters.AddWithValue("@Contact", ContactNoTB.Text);
                command.Parameters.AddWithValue("@Email", EmailTB.Text);
                command.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(DTTB.Text));
                string g = gendercombo.Text.ToString();
                int gender = GetGenderFromLookup(g);
                command.Parameters.AddWithValue("@Gender", gender);
              //  int value1 = 0;
              //  string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
              //  var val = command.ExecuteScalar().ToString();
              //  value1 = int.Parse(val);
                int i = command.ExecuteNonQuery();
                int id = RetriveID();
                SqlCommand command2 = new SqlCommand("insert into Student(Id,RegistrationNo) values(@id, @RegistrationNo)", conn);
                int j = command2.ExecuteNonQuery();
                if (i >=1 && j >=1)
                {
                    MessageBox.Show(i + " student Registered:" + FNTB + LNTB);
                }
                else
                {
                    MessageBox.Show(i + " Student not Registered:" + FNTB + LNTB);
                }

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
            if (FNTB.Text != "" && LNTB.Text != "" && ContactNoTB.Text != "" && EmailTB.Text != "" && DTTB.Text != "")
            {
                command = new SqlCommand("update Person set FirstName=@FN,LastName=@LN, Contact=@Cont, Email=@EM, DateOfBirth=@DOB where Id=@id", conn);
                conn.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@FN", FNTB.Text);
                command.Parameters.AddWithValue("@LN", LNTB.Text);
                command.Parameters.AddWithValue("@Cont", ContactNoTB.Text);
                command.Parameters.AddWithValue("@EM", EmailTB.Text);
                command.Parameters.AddWithValue("@DOB", DTTB.Text);
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
            DTTB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            gendercombo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
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

        private void idTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegnoTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void EmailTB_Validating_1(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (EmailTB.Text.Length > 0 && EmailTB.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(EmailTB.Text.Trim()))
                {
                    MessageBox.Show("Incorrect Email id");
                    EmailTB.SelectAll();
                    e.Cancel = true;
                }
            }
        }


       private void ContactNoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) && ContactNoTB.TextLength == 11)
                e.Handled = true;
            else
                MessageBox.Show("Please enter valid phone number");
                */
        }
        

        private void ContactNoTB_Validating(object sender, CancelEventArgs e)
        {
            if (!(Regex.IsMatch(ContactNoTB.Text, "^[0-9]{10,12}$")))
            {
                MessageBox.Show("Enter valid no");
                ContactNoTB.SelectAll();
                e.Cancel = true;
            }
            
        }

        private void FNTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(FNTB.Text, @"[A-Z][a-zA-Z\s\'-]*"))
            {
                MessageBox.Show("Use only alphabets or enter first letter capital");
                FNTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void LNTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(LNTB.Text, @"[A-Z][a-zA-Z\s\'-]*"))
            {
                MessageBox.Show("Use only alphabets or enter first letter capital");
                LNTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void RegnoTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(RegnoTB.Text, "^[A-Z0-9]{8}$"))
            {
                MessageBox.Show("Invalid Registeration number");
                RegnoTB.SelectAll();
                e.Cancel = true;
            }
        }
    }

}
