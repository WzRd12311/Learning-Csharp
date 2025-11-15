using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buy_list
{
    public partial class Form1 : Form
    {
        // VARIABLES
        private List<Dictionary<string, string>> mainBuyList = new List<Dictionary<string, string>>();
        private Dictionary<string, decimal> statistic;
        private Stack<List<Dictionary<string, string>>> undo, redo;

        public Form1()
        {
            InitializeComponent();
            dgvBuyList.DataSource = mainBuyList;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void btnRedo_Click(object sender, EventArgs e)
        {

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text.Length == 0) { 
                MessageBox.Show("Ім'я продукту не може бути пустим!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductChange_Click(object sender, EventArgs e)
        {

        }

        private void btnProductRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenStatistic_Click(object sender, EventArgs e)
        {
            StatisticForm f = new StatisticForm();
            f.Show();
        }


    }
}