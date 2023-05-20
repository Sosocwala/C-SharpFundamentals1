using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculaterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            bool decimalFlag = false;
            bool totalFlag = false; 

            Button b = (Button)sender;
            string inputTxt = b.Text;
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             string input = textBox1.Text;
            input = button10.Text;
            button10.Show();
        }
    }
}
