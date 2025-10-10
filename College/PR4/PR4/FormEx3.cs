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
    public partial class FormEx3 : Form
    {
        public FormEx3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool FlagSymb = (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ':' && e.KeyChar != ';' && e.KeyChar != '"');

            if (!char.IsLetter(e.KeyChar)&& FlagSymb && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back) { 
            e.Handled = true;
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                MessageBox.Show("Поле вводу пусте", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            string[] part = textBox1.Text.Split(new char[] {' ', ',', '"', ':', ';', '.'}, StringSplitOptions.RemoveEmptyEntries);
            labResult.Text = $"Результат перерахування: {part.Length}";
        }
    }
}
    