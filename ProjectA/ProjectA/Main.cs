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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person fm2 = new Person();
            fm2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
