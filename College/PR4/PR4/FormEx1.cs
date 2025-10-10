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
    public partial class FormEx1 : Form
    {
        public FormEx1()
        {
            InitializeComponent();
        }

        private void binaryArr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back)
            { 
                e.Handled = true; 
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if(binaryArr.Text.Length == 0)
                MessageBox.Show("Поле вводу пусте", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Result.Text = $"Результат переводу: {Convert.ToInt32(binaryArr.Text, 2).ToString()}";
        }
    }
}
