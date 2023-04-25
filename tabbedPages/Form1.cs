using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabbedPages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectTab("tabPage2"); // selecting a Tab
            tabControl1.SelectedIndex = 3; // another way of selecting Tabs
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
