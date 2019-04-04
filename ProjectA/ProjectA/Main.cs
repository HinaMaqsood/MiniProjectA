using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome fm2 = new Welcome();
            fm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person fm2 = new Person();
            fm2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Project fm2 = new Project();
            fm2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Advisor fm2 = new Advisor();
            fm2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Evaluation fm2 = new Evaluation();
            fm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageGroups id0 = new ManageGroups();
            id0.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ProjectAdvisor id1 = new ProjectAdvisor();
            id1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GroupProject id2 = new GroupProject();
            id2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GroupEvaluation id3 = new GroupEvaluation();
            id3.Show();
        }
    }
}
