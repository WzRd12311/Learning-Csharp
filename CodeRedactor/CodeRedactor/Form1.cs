using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CodeRedactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public RichTextBox MainRTB
        {
            get { return rbnFile; }
        }

        private string currentFilePath = "";
        private bool isModified = false;

        private void tsmNewFile(object sender, EventArgs e)
        {
            if (CheckSaveChanged()) {
                rbnFile.Clear();
                currentFilePath = "";
                isModified = false;
            }
        }

        private void tsmOpenFile(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                ofd.Title = "Открыть файл";

                if (ofd.ShowDialog() == DialogResult.OK)
                    currentFilePath = ofd.FileName;
                try
                {
                    StreamReader r = new StreamReader(currentFilePath);
                    rbnFile.Text = r.ReadToEnd(); 
                    isModified = true;
                }

                catch(Exception ex) 
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmSaveFile(object sender, EventArgs e)
        {
            if (currentFilePath == "")
                tsmSaveFileAs(sender, e);
            else
                SaveToFile(currentFilePath);
        }

        private void tsmSaveFileAs(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                sfd.Title = "Открыть файл";
                sfd.FileName = "Новый документ";

                if(sfd.ShowDialog() == DialogResult.OK)
                    SaveToFile(sfd.FileName);
            }
        }

        private void tsmExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToFile(string filePath)
        {
            try
            {
                File.WriteAllText(filePath, rbnFile.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            currentFilePath = filePath;
            isModified = true;
        }


        private void tsmFind(object sender, EventArgs e)
        {
            FindForm find = new FindForm(this);
            find.Show();
        }

        private void tsmChangeTo(object sender, EventArgs e) 
        {
            ChangeForm change = new ChangeForm(this);
            change.Show();
        }
        private void tsmSelectAll(object sender, EventArgs e) 
        { 
            rbnFile.SelectAll();
        }
        private void tsmCopy(object sender, EventArgs e) 
        {
            rbnFile.Copy();
        }
        private void tsmPaste(object sender, EventArgs e) 
        {
            rbnFile.Paste();
        }
        private void tsmDelete(object sender, EventArgs e) 
        {
            rbnFile.SelectedText = "";
        }
        private void tsmCut(object sender, EventArgs e) 
        {
            rbnFile.Cut();
        }
        private void tsmWriteDate(object sender, EventArgs e) 
        {
            rbnFile.Text = rbnFile.Text.Insert(rbnFile.SelectionStart, DateTime.Now.ToString());
        }
        private void tsmFontProperties(object sender, EventArgs e) 
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = Font;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    rbnFile.Font = fontDialog.Font;
                }
            }
        }
        private bool CheckSaveChanged() 
        {
            if (isModified) {
                var result = MessageBox.Show("Документ был изменён. Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel,  MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    SaveToFile(currentFilePath);
                    return true;
                }

                else if (result == DialogResult.No)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        private void tsmZoomUp(object sender, EventArgs e)
        {
            if (rbnFile.ZoomFactor != 5f)
                rbnFile.ZoomFactor += 0.1f;
        }

        private void tsmZoomDown(object sender, EventArgs e)
        {
            if(rbnFile.ZoomFactor != 0.1f)
                rbnFile.ZoomFactor -= 0.1f;
        }

        private void tsmZoomDefault(object sender, EventArgs e)
        {
            rbnFile.ZoomFactor += 0.1f; //костыль для обновления рендеринга
            rbnFile.ZoomFactor = 1f;
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                e.Handled = true;
                tsmNewFile(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                e.Handled = true;
                tsmOpenFile(sender, e);
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                e.Handled = true;
                tsmSaveFileAs(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                e.Handled = true;
                tsmSaveFile(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                e.Handled = true;
                tsmFind(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                e.Handled = true;
                tsmChangeTo(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                e.Handled = true;
                tsmSelectAll(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                e.Handled = true;
                tsmCopy(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                tsmPaste(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                e.Handled = true;
                tsmCut(sender, e);
            }
            else if (e.KeyCode == Keys.Delete && !e.Control && !e.Shift)
            {
                e.Handled = true;
                tsmDelete(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                e.Handled = true;
                tsmWriteDate(sender, e);
            }
            else if (e.Control && (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus))
            {
                e.Handled = true;
                tsmZoomUp(sender, e);
            }
            else if (e.Control && (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus))
            {
                e.Handled = true;
                tsmZoomDown(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.D0)
            {
                e.Handled = true;
                tsmZoomDefault(sender, e);
            }

        }
    }
}
