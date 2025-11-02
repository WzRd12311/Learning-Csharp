using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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

        //private int startIndex = 0;
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
            if (string.IsNullOrEmpty(tbSubStr.Text))
            {
                MessageBox.Show("Ошибка: Поле для поиска не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            string searchText = tbSubStr.Text;

            RichTextBoxFinds options = RichTextBoxFinds.None;
            if (radioEnd.Checked)
            {
                options |= RichTextBoxFinds.Reverse;
            }
            if (cbMatchCase.Checked)
            {
                options |= RichTextBoxFinds.MatchCase;
            }

            int start = 0;
            int end = 0;
            var mainRtb = mainForm.MainRTB;

            if (options.HasFlag(RichTextBoxFinds.Reverse))
            {
                start = 0;
                end = mainRtb.SelectionStart > 0 ? mainRtb.SelectionStart - 1 : -1;
                if (end < 0)
                {
                    end = mainRtb.TextLength; 
                }
            }
            else
            {
                start = mainRtb.SelectionStart + mainRtb.SelectionLength;
                end = mainRtb.TextLength;
                if (start >= mainRtb.TextLength)
                {
                    start = 0; 
                }
            }

            int foundPosition;

            if (options.HasFlag(RichTextBoxFinds.Reverse))
            {
                foundPosition = mainRtb.Find(searchText, start, end, options);
            }

            else 
            {
                foundPosition = mainRtb.Find(searchText, start, options);
            }

            if (foundPosition == -1)
            {
                if (options.HasFlag(RichTextBoxFinds.Reverse))
                {
                    foundPosition = mainRtb.Find(searchText, 0, mainRtb.TextLength, options);
                }
                else
                {
                    foundPosition = mainRtb.Find(searchText, 0, options);
                }

                if (foundPosition == -1)
                {
                    MessageBox.Show($"Не удается найти \"{searchText}\"", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            if (foundPosition != -1)
                mainForm.Activate();     
        }
    }
}
