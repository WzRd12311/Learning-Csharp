using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx1 formEx1 = new FormEx1();
            formEx1.MdiParent = this;
            formEx1.Show();
        }
        private void Ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx2 formEx2 = new FormEx2();
            formEx2.MdiParent = this;
            formEx2.Show();
        }
        private void Ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx3 formEx3 = new FormEx3();
            formEx3.MdiParent = this;
            formEx3.Show();
        }
        private void Ex4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx4 formEx4 = new FormEx4();
            formEx4.MdiParent = this;
            formEx4.Show();
        }
    }
}
