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
    public partial class ChangeForm : Form
    {

        private Form1 mainForm;

        public ChangeForm(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
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
            if (cbMatchCase.Checked)
            {
                options |= RichTextBoxFinds.MatchCase;
            }

            int start = 0;

            start = mainForm.MainRTB.SelectionStart + mainForm.MainRTB.SelectionLength;
            if (start >= mainForm.MainRTB.TextLength)
            {
                start = 0;
            }


            int foundPosition;

            foundPosition = mainForm.MainRTB.Find(searchText, start, options);
            //

            if (foundPosition == -1)
            {
                foundPosition = mainForm.MainRTB.Find(searchText, 0, options);

                if (foundPosition == -1)
                {
                    MessageBox.Show($"Не удается найти \"{searchText}\"", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            if (foundPosition != -1)
                mainForm.Activate();
        }
        private void currentChangeClick(object sender, EventArgs e)
        {
            FindClick(sender, e);
            if (string.IsNullOrEmpty(tbSubStr.Text) || string.IsNullOrEmpty(tbHow.Text))
            {
                MessageBox.Show("Ошибка: Поле для поиска не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newText = tbHow.Text;
            string searchText = tbSubStr.Text;
	        string currentSelection = mainForm.MainRTB.SelectedText;

            if (currentSelection.Contains(searchText))
            {
                 string modifiedSelection = currentSelection.Replace(searchText, newText);
                 mainForm.MainRTB.SelectedText = modifiedSelection;
            }
            else
            {
                 MessageBox.Show($"В текущем выделении не найдено вхождений \"{searchText}\"", "Результат замены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void allChangeClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSubStr.Text) || string.IsNullOrEmpty(tbHow.Text))
            {
                MessageBox.Show("Ошибка: Поле для поиска не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newText = tbHow.Text;
            string searchText = tbSubStr.Text;

            string original = mainForm.MainRTB.Text;
            mainForm.MainRTB.Text = original.Replace(searchText, newText);
            mainForm.MainRTB.SelectionStart = 0;
        }
    }
}
