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
    public partial class ManageGroups : Form
    {
        public ManageGroups()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group fm2 = new Group();
            fm2.ShowDialog();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            StudentGroup fm3 = new StudentGroup();
            fm3.ShowDialog();
        }
    }
}
