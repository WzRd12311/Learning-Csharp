using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // === Переменные для Задания 2 ===
        int[] arrayEx2 = new int[8];
        int countI2 = 0;

        // === Переменные для Задания 3 ===
        int[,] arrayEx3 = new int[7, 7];
        int countI3 = 0;
        int countJ3 = 0;
        bool isFull3 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //==================================================//
        //=============== КОД ДЛЯ ЗАДАНИЯ 1 ===============//
        //==================================================//

        private void convertButton_Click(object sender, EventArgs e)
        {
            string binaryString = binaryTextBox.Text.Trim();
            if (string.IsNullOrEmpty(binaryString))
            {
                MessageBox.Show("Enter binary num", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (binaryTextBox.Text.Length >= 50) {
                MessageBox.Show("Too long binary number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            while (binaryString.Length % 3 != 0)
            {
                binaryString = "0" + binaryString;
            }

            string octalResult = "";
            for (int i = 0; i < binaryString.Length; i += 3)
            {
                string threeBits = binaryString.Substring(i, 3);
                switch (threeBits)
                {
                    case "000": octalResult += "0"; break;
                    case "001": octalResult += "1"; break;
                    case "010": octalResult += "2"; break;
                    case "011": octalResult += "3"; break;
                    case "100": octalResult += "4"; break;
                    case "101": octalResult += "5"; break;
                    case "110": octalResult += "6"; break;
                    case "111": octalResult += "7"; break;
                }
            }

            resultLabel.Text = "Result: " + octalResult;
        }

        private void binaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //==================================================//
        //=============== КОД ДЛЯ ЗАДАНИЯ 2 ===============//
        //==================================================//

        private void performEx2_Click(object sender, EventArgs e)
        {
            if (countI2 < 8)
            {
                MessageBox.Show("Array is not full!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] newArrayEx2 = new int[8];
            for (int i = 0; i < arrayEx2.Length; i++)
            {
                newArrayEx2[i] = Abs(arrayEx2[i] % 10); // Find the last digit
            }

            resultArrayEx2.Text = "Result array: " + string.Join(", ", newArrayEx2);
        }

        private void AutoFill_Click2(object sender, EventArgs e)
        {
            Random rand = new Random();
            arrayEx2 = new int[8];
            for (countI2 = 0; countI2 < arrayEx2.Length; countI2++)
            {
                arrayEx2[countI2] = rand.Next(10, 100); 
            }

            curArrayEx2.Text = "Current Array: " + string.Join(" ", arrayEx2);
            resultArrayEx2.Text = "Result array: ";
        }

        private void CheckedChanged2(object sender, EventArgs e)
        {
            bool isHandleMode = radioHandleMode2.Checked;

            enterElementEx2.Visible = isHandleMode;
            textBoxEx2.Visible = isHandleMode;
            btnAutoFillEx2.Visible = !isHandleMode;


            arrayEx2 = new int[8];
            countI2 = 0;
            curArrayEx2.Text = "Current Array: ";
            resultArrayEx2.Text = "Result array: ";
            textBoxEx2.Clear();
        }

        private void textBoxEx2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBoxEx2.Text, out int val))
                {
                    if (val < 10 || val > 99)
                    {
                        MessageBox.Show("Enter a two-digit number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEx2.Clear();
                        return;
                    }

                    if (countI2 < 8)
                    {
                        arrayEx2[countI2] = val;
                        curArrayEx2.Text += arrayEx2[countI2++].ToString() + " ";
                        textBoxEx2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Array is full!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEx2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Input field is empty!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxEx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        //==================================================//
        //=============== КОД ДЛЯ ЗАДАНИЯ 3 ===============//
        //==================================================//

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isFull3)
            {
                MessageBox.Show("Matrix is not full!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (arrayEx3[i, j] < 0 && arrayEx3[i, j] % 2 != 0)
                    {
                        sum += Abs(arrayEx3[i, j]);
                    }
                }
            }

            resultArrayEx3.Text = "Result sum of absolute values: " + sum;
        }

        private void CheckedChanged3(object sender, EventArgs e)
        {
            bool isHandleMode = radioHandleMode3.Checked;

            enterElementEx3.Visible = isHandleMode;
            textBoxEx3.Visible = isHandleMode;
            btnAutoFill3.Visible = !isHandleMode;

            // Reset state
            arrayEx3 = new int[7, 7];
            countI3 = 0;
            countJ3 = 0;
            isFull3 = false;
            listBox1.Items.Clear();
            resultArrayEx3.Text = "Result:";
            enterElementEx3.Text = $"Enter element [{countI3},{countJ3}]:";
        }

        private void btnAutoFill3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            listBox1.Items.Clear();

            for (int i = 0; i < 7; i++)
            {
                string row = "";
                for (int j = 0; j < 7; j++)
                {
                    arrayEx3[i, j] = rand.Next(-50, 51);
                    row += arrayEx3[i, j].ToString().PadRight(10) + " ";
                }
                listBox1.Items.Add(row);
            }
            isFull3 = true;
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBoxEx3.Text, out int val))
                {
                    if (countI3 < 7)
                    {
                        arrayEx3[countI3, countJ3] = val;
                        countJ3++;
                        if (countJ3 == 7)
                        {
                            countJ3 = 0;
                            countI3++;
                        }

                        if (countI3 == 7)
                        {
                            isFull3 = true;
                            enterElementEx3.Text = "Matrix is full!";
                        }
                        else
                        {
                            enterElementEx3.Text = $"Enter element [{countI3},{countJ3}]:";
                        }

                        textBoxEx3.Clear();

                        listBox1.Items.Clear();
                        for (int i = 0; i < 7; i++)
                        {
                            if (i > countI3) break;
                            string row = "";
                            for (int j = 0; j < 7; j++)
                            {
                                if (i == countI3 && j >= countJ3 && countI3 < 7) break;
                                row += arrayEx3[i, j].ToString().PadRight(10) + " ";
                            }
                            listBox1.Items.Add(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Input field is empty!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' && (textBoxEx3.Text.Contains('-') || textBoxEx3.Text.Length != 0)) e.Handled = true;
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-') e.Handled = true;
        }

        //==================================================//
        //=============== КОД ДЛЯ ЗАДАНИЯ 4 ===============//
        //==================================================//

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text, out int m) || !int.TryParse(textBox5.Text, out int n))
            {
                MessageBox.Show("Please enter valid integers for rows and columns!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (m <= 0 || n <= 0)
            {
                MessageBox.Show("Rows and columns must be positive numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (m > 10 || n > 10) 
            {
                MessageBox.Show("Rows and columns must be less then 10 or equal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[,] arrayEx4 = new int[m, n];
            listBox3.Items.Clear();

            for (int i = 0; i < m; i++)
            {
                string row = "";
                for (int j = 0; j < n; j++)
                {
                    arrayEx4[i, j] = (i + j) % 2;
                    row += arrayEx4[i, j] + " ";
                }
                listBox3.Items.Add(row.Trim());
            }
        }

        private void textBoxEX4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

    }
}
