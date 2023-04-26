using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolbar
{
    public partial class webBrowser1 : Form
    {
        public webBrowser1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoc newDoc = new NewDoc();
            newDoc.MdiParent = this;
            newDoc.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVreticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
        }

        private static void Navigate(string v)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
