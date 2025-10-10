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
    public partial class FormEx2 : Form
    {

        private object[] array = new object[7];
        private int count = 0;

        public FormEx2()
        {
            InitializeComponent();
        }

        private void Element_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                if(Element.Text.Length == 0){
                    MessageBox.Show("Поле вводу пусте", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Element.Text.Length > 5) {
                    MessageBox.Show("Елемент масиву завеликий.\n Максимальный розмір елементу = 5", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Element.Clear();
                }

                if (count < 7) {
                    CurArr.Text += Element.Text + ' ';
                    array[count++] = Element.Text;
                    Element.Clear();
                }

                else
                {
                    MessageBox.Show("Масив повний", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Element.Clear();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (count < 7)
            {
                MessageBox.Show("Масив не заповнений", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSymmetric = array.SequenceEqual(array.Reverse());
            Result.Text = $"Результат перевірки: {isSymmetric}";



        }
    }
}
