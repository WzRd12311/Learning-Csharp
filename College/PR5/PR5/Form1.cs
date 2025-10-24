using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunL1T1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.Title = "Відкрити файл f";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            string fPath = openFileDialog1.FileName;

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.Title = "Зберегти файл g";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            string gPath = saveFileDialog1.FileName;

            string hPath = Path.Combine(Path.GetTempPath(), "h_temp.txt");

            try
            {
                List<int> positives = new List<int>();
                List<int> negatives = new List<int>();

                using (StreamReader sr = new StreamReader(fPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (int.TryParse(line, out int number) && number != 0)
                        {
                            if (number > 0) positives.Add(number);
                            else negatives.Add(number);
                        }
                    }
                }

                using (StreamWriter sw_h = new StreamWriter(hPath))
                {
                    foreach (int num in negatives)
                    {
                        sw_h.WriteLine(num);
                    }
                }

                using (StreamWriter sw_g = new StreamWriter(gPath))
                {
                    foreach (int num in positives)
                    {
                        sw_g.WriteLine(num);
                    }
                }

                using (StreamReader sr_h = new StreamReader(hPath))
                {
                    FileInfo fi_g = new FileInfo(gPath);
                    using (StreamWriter sw_append = fi_g.AppendText())
                    {
                        string content = sr_h.ReadToEnd();
                        sw_append.Write(content);
                    }
                }

                File.Delete(hPath);

                rtbL1T1_f.Text = File.ReadAllText(fPath);
                rtbL1T1_g.Text = File.ReadAllText(gPath);

                MessageBox.Show("Операцію успішно виконано!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnRunL1T2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.Title = "Відкрити файл з дійсними числами";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            string fPath = openFileDialog1.FileName;
            string lastLine = null;

            try
            {
                using (StreamReader sr = new StreamReader(fPath))
                {
                    string currentLine;
                    while (!sr.EndOfStream)
                    {
                        currentLine = sr.ReadLine();
                        if (!string.IsNullOrWhiteSpace(currentLine))
                        {
                            lastLine = currentLine;
                        }
                    }
                }
                lblL1T2Result.Text = lastLine ?? "Файл порожній або не містить даних.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnRunL2T2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Будь ласка, оберіть перший файл з матрицями (K).");
            openFileDialog1.Title = "Відкрити перший файл матриць";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            string file1Path = openFileDialog1.FileName;

            MessageBox.Show("Будь ласка, оберіть другий файл з матрицями (L).");
            openFileDialog1.Title = "Відкрити другий файл матриць";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            string file2Path = openFileDialog1.FileName;

            saveFileDialog1.Title = "Зберегти файл із зайвими матрицями";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            string file3Path = saveFileDialog1.FileName;

            try
            {
                var matrices1 = ReadMatrixFile(file1Path);
                var matrices2 = ReadMatrixFile(file2Path);

                if (matrices1.Count == matrices2.Count)
                {
                    MessageBox.Show("Файли містять однакову кількість матриць. Операція не потрібна.");
                    return;
                }

                List<double[,]> largerList = matrices1.Count > matrices2.Count ? matrices1 : matrices2;
                List<double[,]> smallerList = matrices1.Count < matrices2.Count ? matrices1 : matrices2;
                string largerFilePath = matrices1.Count > matrices2.Count ? file1Path : file2Path;

                int excessCount = largerList.Count - smallerList.Count;
                var excessMatrices = largerList.GetRange(smallerList.Count, excessCount);
                largerList.RemoveRange(smallerList.Count, excessCount);

                WriteMatrixFile(largerFilePath, largerList);
                WriteMatrixFile(file3Path, excessMatrices);

                rtbL2T2_res1.Text = File.ReadAllText(file1Path);
                rtbL2T2_res2.Text = File.ReadAllText(file2Path);
                rtbL2T2_res3.Text = File.ReadAllText(file3Path);

                MessageBox.Show("Операцію успішно виконано!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private List<double[,]> ReadMatrixFile(string path)
        {
            var matrices = new List<double[,]>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string dimLine = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(dimLine)) continue;

                    string[] dims = dimLine.Split(' ');
                    int rows = int.Parse(dims[0]);
                    int cols = int.Parse(dims[1]);
                    var matrix = new double[rows, cols];

                    for (int i = 0; i < rows; i++)
                    {
                        string[] values = reader.ReadLine().Split(' ');
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[i, j] = double.Parse(values[j]);
                        }
                    }
                    matrices.Add(matrix);
                }
            }
            return matrices;
        }

        private void WriteMatrixFile(string path, List<double[,]> matrices)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var matrix in matrices)
                {
                    int rows = matrix.GetLength(0);
                    int cols = matrix.GetLength(1);
                    writer.WriteLine($"{rows} {cols}");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            writer.Write(matrix[i, j] + (j == cols - 1 ? "" : " "));
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}