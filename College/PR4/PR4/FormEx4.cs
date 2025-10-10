using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR4
{
    public partial class FormEx4 : Form
    {
        public FormEx4()
        {
            InitializeComponent();
        }

        private void FormEx4_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (ArraySymbA.Text.Length == 0 || ArraySymbB.Text.Length == 0)
                MessageBox.Show("Поле вводу пусте", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var GeneralSymb = ArraySymbA.Text.Intersect(ArraySymbB.Text);
            string SubSTR = "";
            foreach (char c in GeneralSymb) { 
                SubSTR += " " + c;
            }
            Result.Text = $"Результат знаходження: {SubSTR}";
        }
    }
}
