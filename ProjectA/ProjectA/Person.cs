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
        SqlDataAdapter Adopt;
        int Id = 0;
        public Person()
        {
            InitializeComponent();
        }
        private void DataShow()
        {
           
            DataTable all = new DataTable();
            Adopt = new SqlDataAdapter("select Person.Id, RegistrationNo, FirstName, LastName,  Contact, Email, DateOfBirth, Gender from Person JOIN Student ON Person.Id = Student.Id", conn);
            Adopt.Fill(all);
            dataGridView1.DataSource = all;
            conn.Close();
        }
        private void DataClean()
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
            DataShow();
        }

        int value;
        private int LookupGen(string gen)
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
        private int IDGET()
        {
            int getID = 0;
            
                string query = "Select Id from Person where (Id = SCOPE_IDENTITY());";
                if(conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand command = new SqlCommand(query, conn);
                var i = command.ExecuteScalar().ToString();
                getID = int.Parse(i);
                return getID;
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(RegistrationNo) FROM [Student] WHERE (RegistrationNo = @user)", conn);
            check_User_Name.Parameters.AddWithValue("@user", RegnoTB.Text);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            conn.Close();
            if (UserExist > 0)
            {
                MessageBox.Show("This Registration Number is already registered");
            }
            else
            {


                if (RegnoTB.Text != "" && FNTB.Text != "" && LNTB.Text != "" && ContactNoTB.Text != "" && EmailTB.Text != "" && DTTB.Text != "")
                {
                    conn.Open();
                    string gen = gendercombo.SelectedItem.ToString();
                    string genGet = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + gen + "'";
                    SqlCommand ConvertToInt = new SqlCommand(genGet, conn);
                    int GetGender = 0;
                    SqlDataReader readgen = ConvertToInt.ExecuteReader();
                    while (readgen.Read())
                    {
                        GetGender = int.Parse(readgen[0].ToString());
                    }

                    string insertall = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + FNTB.Text + "' , '" + LNTB.Text + "' , '" + ContactNoTB.Text + "' , '" + EmailTB.Text + "' , '" + DateTime.Parse(DTTB.Text) + "' , '" + GetGender + "')";

                    SqlCommand i = new SqlCommand(insertall, conn);
                    int an = i.ExecuteNonQuery();
                    int total = 0;
                    string scope = "Select Id from Person where (Id = SCOPE_IDENTITY())";
                    SqlCommand command = new SqlCommand(scope, conn);
                    var dig = command.ExecuteScalar().ToString();
                    total = int.Parse(dig);
                    string q = "insert into Student values('" + total + "','" + RegnoTB.Text.ToString() + "')";
                    SqlCommand cmd1 = new SqlCommand(q, conn);
                    int sel = cmd1.ExecuteNonQuery();
                    conn.Close();
                    if (MessageBox.Show("Do You want to Register this Student?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Student is Registered");
                    }
                    else
                    {
                        MessageBox.Show("Student is not Registered", "Register Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter all details!");
                }
            }
            DataShow();
            

           
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (FNTB.Text != "" && LNTB.Text != "" && ContactNoTB.Text != "" && EmailTB.Text != "" && DTTB.Text != "")
            {
                string i = "UPDATE Person set(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + FNTB.Text + "' , '" + LNTB.Text + "' , '" + ContactNoTB.Text + "' , '" + EmailTB.Text + "' , '" + DateTime.Parse(DTTB.Text) + "' , '" + value + "') where Id = Id";
                conn.Open();
                SqlCommand an = new SqlCommand(i, conn);
                int total = an.ExecuteNonQuery();
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
                DataShow();
                DataClean();
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
                MessageBox.Show("Enter valid number");
                ContactNoTB.SelectAll();
                e.Cancel = true;
            }
            
        }

        private void FNTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(FNTB.Text, @"[A-Z][a-zA-Z\s\'-]*"))
            {
                MessageBox.Show("Use only alphabets or Enter first letter capital");
                FNTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void LNTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(LNTB.Text, @"[A-Z][a-zA-Z\s\'-]*"))
            {
                MessageBox.Show("Use only alphabets or Enter first letter capital");
                LNTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void RegnoTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(RegnoTB.Text, "^[0-9]{4}-[A-Z]{2}-[0-9]{2,3}$"))
            {
                MessageBox.Show("Invalid Registeration number");
                RegnoTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void DTTB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTTB_Validating(object sender, CancelEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
