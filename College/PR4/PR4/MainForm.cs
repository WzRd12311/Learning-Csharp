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

        private Form currentForm = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenForm(Form newForm)
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Close();
            }

            currentForm = newForm;
            currentForm.MdiParent = this;
            currentForm.Show();
        }

        private void Ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FormEx1());
        }
        private void Ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FormEx2());
        }
        private void Ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FormEx3());
        }
        private void Ex4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FormEx4());
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
