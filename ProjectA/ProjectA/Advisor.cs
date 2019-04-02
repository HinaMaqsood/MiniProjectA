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
    public partial class Advisor : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REMV6L1\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True;");
        SqlDataAdapter Adopt;
        int Norm = 0;
        public Advisor()
        {
            InitializeComponent();
        }

        private void DataShow()
        {
            
            DataTable all = new DataTable();
            Adopt = new SqlDataAdapter("select Person.Id, FirstName, LastName, Designation, Salary, Contact, Email, DateOfBirth, Gender from Person JOIN Advisor ON Person.Id = Advisor.Id", conn);
            Adopt.Fill(all);
            dataGridView1.DataSource = all;
            conn.Close();
        }
        private void DataClean()
        {
            FNTB.Text = "";
            LNTB.Text = "";
            desigcombo.Text = "";
            salaTB.Text = "";
            ContactNoTB.Text = "";
            EmailTB.Text = "";
            DOBTB.Text = "";
            gendercombo.Text = "";
            Norm = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Advisor_Load(object sender, EventArgs e)
        {
            DataShow();
        }

        private void createbutton_Click(object sender, EventArgs e)
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

            string desig = desigcombo.SelectedItem.ToString();
            string desigGet = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND value ='" + desig + "'";
            SqlCommand ConvertToInt2 = new SqlCommand(desigGet, conn);
            int GetDesig = 0;
            SqlDataReader readDesig = ConvertToInt2.ExecuteReader();
            while (readDesig.Read())
            {
                GetDesig = int.Parse(readDesig[0].ToString());
            }

            string i = "INSERT into Person(FirstName , LastName , Contact, Email , DateOfBirth , Gender) values ('" + FNTB.Text + "' , '" + LNTB.Text + "' , '" + ContactNoTB.Text + "' , '" + EmailTB.Text + "' , '" + DateTime.Parse(DOBTB.Text) + "' , '" + GetGender + "')";
            SqlCommand alls = new SqlCommand(i, conn);
            int an = alls.ExecuteNonQuery();
            int GetID = 0;
            string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
            SqlCommand cmd = new SqlCommand(query, conn);
            var dig = cmd.ExecuteScalar().ToString();
            GetID = int.Parse(dig);
            string q = "insert into Advisor values('" + GetID + "','"+ GetDesig + "','" + salaTB.Text + "')";
            SqlCommand cmd1 = new SqlCommand(q, conn);
            int ji = cmd1.ExecuteNonQuery();
            if (MessageBox.Show("Do You want to Register this Advisor?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Advisor is Registered");
            }
            else
            {
                MessageBox.Show("Advisor is not Registered", "Register Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataShow();
            conn.Close();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void FNTB_TextChanged(object sender, EventArgs e)
        {

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

        private void ContactNoTB_Validating(object sender, CancelEventArgs e)
        {
            if (!(Regex.IsMatch(ContactNoTB.Text, "^[0-9]{10,12}$")))
            {
                MessageBox.Show("Enter valid number");
                ContactNoTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void EmailTB_Validating(object sender, CancelEventArgs e)
        {
            if (!(Regex.IsMatch(ContactNoTB.Text, "^[0-9]{10,12}$")))
            {
                MessageBox.Show("Enter valid number");
                ContactNoTB.SelectAll();
                e.Cancel = true;
            }
        }

        private void desigcombo_StyleChanged(object sender, EventArgs e)
        {

        }

        private void desigcombo_Validated(object sender, EventArgs e)
        {

        }

        private void Advisor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
