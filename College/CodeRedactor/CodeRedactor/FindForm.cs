using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRedactor
{
    public partial class FindForm : Form
    {
        private Form1 mainForm;
        private RichTextBoxFinds direction = RichTextBoxFinds.None;
        private RichTextBoxFinds matchCase = RichTextBoxFinds.None;

        private int startIndex = 0;
        public FindForm(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
            radioBegin.Checked = true;
        }


        private void cancelClick(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FindClick(object sender, EventArgs e)
        {
            mainForm.MainRTB.Find("abc", startIndex, direction | matchCase);
        }

        private void directionCheckedChanged(object sender, EventArgs e)
        {
            bool isBegin = radioBegin.Checked;
            if (isBegin)
            {
                direction = RichTextBoxFinds.None;
            }
            else
            {
                direction = RichTextBoxFinds.Reverse;
            }
        }

        private void modeCheckedChanged(object sender, EventArgs e)
        {
            if (cbMatchCase.Checked)
            {
                matchCase = RichTextBoxFinds.MatchCase;
            }
            else 
            {
                matchCase = RichTextBoxFinds.None;
            }
        }
    }
}
