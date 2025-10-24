namespace PR5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblL1T2Result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRunL1T2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbL1T1_g = new System.Windows.Forms.RichTextBox();
            this.rtbL1T1_f = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunL1T1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbL2T2_res3 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbL2T2_res2 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbL2T2_res1 = new System.Windows.Forms.RichTextBox();
            this.btnRunL2T2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Рівень 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblL1T2Result);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnRunL1T2);
            this.groupBox2.Location = new System.Drawing.Point(349, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Завдання 2: Знайти останню компоненту файлу";
            // 
            // lblL1T2Result
            // 
            this.lblL1T2Result.AutoSize = true;
            this.lblL1T2Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblL1T2Result.Location = new System.Drawing.Point(86, 103);
            this.lblL1T2Result.Name = "lblL1T2Result";
            this.lblL1T2Result.Size = new System.Drawing.Size(11, 13);
            this.lblL1T2Result.TabIndex = 2;
            this.lblL1T2Result.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Результат:";
            // 
            // btnRunL1T2
            // 
            this.btnRunL1T2.Location = new System.Drawing.Point(6, 30);
            this.btnRunL1T2.Name = "btnRunL1T2";
            this.btnRunL1T2.Size = new System.Drawing.Size(120, 50);
            this.btnRunL1T2.TabIndex = 0;
            this.btnRunL1T2.Text = "Обрати файл та знайти";
            this.btnRunL1T2.UseVisualStyleBackColor = true;
            this.btnRunL1T2.Click += new System.EventHandler(this.btnRunL1T2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtbL1T1_g);
            this.groupBox1.Controls.Add(this.rtbL1T1_f);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRunL1T1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Завдання 1: Переписати числа (додатні, потім від\'ємні)";
            // 
            // rtbL1T1_g
            // 
            this.rtbL1T1_g.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbL1T1_g.Location = new System.Drawing.Point(6, 256);
            this.rtbL1T1_g.Name = "rtbL1T1_g";
            this.rtbL1T1_g.ReadOnly = true;
            this.rtbL1T1_g.Size = new System.Drawing.Size(306, 152);
            this.rtbL1T1_g.TabIndex = 4;
            this.rtbL1T1_g.Text = "";
            // 
            // rtbL1T1_f
            // 
            this.rtbL1T1_f.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbL1T1_f.Location = new System.Drawing.Point(6, 70);
            this.rtbL1T1_f.Name = "rtbL1T1_f";
            this.rtbL1T1_f.ReadOnly = true;
            this.rtbL1T1_f.Size = new System.Drawing.Size(306, 152);
            this.rtbL1T1_f.TabIndex = 3;
            this.rtbL1T1_f.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вміст файлу g:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вміст файлу f:";
            // 
            // btnRunL1T1
            // 
            this.btnRunL1T1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunL1T1.Location = new System.Drawing.Point(6, 19);
            this.btnRunL1T1.Name = "btnRunL1T1";
            this.btnRunL1T1.Size = new System.Drawing.Size(306, 23);
            this.btnRunL1T1.TabIndex = 0;
            this.btnRunL1T1.Text = "Обрати вхідний файл f та виконати";
            this.btnRunL1T1.UseVisualStyleBackColor = true;
            this.btnRunL1T1.Click += new System.EventHandler(this.btnRunL1T1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Рівень 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.rtbL2T2_res3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.rtbL2T2_res2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.rtbL2T2_res1);
            this.groupBox4.Controls.Add(this.btnRunL2T2);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(589, 431);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Завдання 2: Забрати з файлу, в якому більше матриць, зайві матриці до третього фа" +
    "йлу";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Файл 3 (зайві матриці)";
            // 
            // rtbL2T2_res3
            // 
            this.rtbL2T2_res3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbL2T2_res3.Location = new System.Drawing.Point(394, 68);
            this.rtbL2T2_res3.Name = "rtbL2T2_res3";
            this.rtbL2T2_res3.ReadOnly = true;
            this.rtbL2T2_res3.Size = new System.Drawing.Size(187, 258);
            this.rtbL2T2_res3.TabIndex = 5;
            this.rtbL2T2_res3.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Файл 2 (після операції)";
            // 
            // rtbL2T2_res2
            // 
            this.rtbL2T2_res2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbL2T2_res2.Location = new System.Drawing.Point(201, 68);
            this.rtbL2T2_res2.Name = "rtbL2T2_res2";
            this.rtbL2T2_res2.ReadOnly = true;
            this.rtbL2T2_res2.Size = new System.Drawing.Size(187, 258);
            this.rtbL2T2_res2.TabIndex = 3;
            this.rtbL2T2_res2.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Файл 1 (після операції)";
            // 
            // rtbL2T2_res1
            // 
            this.rtbL2T2_res1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbL2T2_res1.Location = new System.Drawing.Point(8, 68);
            this.rtbL2T2_res1.Name = "rtbL2T2_res1";
            this.rtbL2T2_res1.ReadOnly = true;
            this.rtbL2T2_res1.Size = new System.Drawing.Size(187, 258);
            this.rtbL2T2_res1.TabIndex = 1;
            this.rtbL2T2_res1.Text = "";
            // 
            // btnRunL2T2
            // 
            this.btnRunL2T2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunL2T2.Location = new System.Drawing.Point(6, 19);
            this.btnRunL2T2.Name = "btnRunL2T2";
            this.btnRunL2T2.Size = new System.Drawing.Size(576, 23);
            this.btnRunL2T2.TabIndex = 0;
            this.btnRunL2T2.Text = "Обрати файли матриць та виконати";
            this.btnRunL2T2.UseVisualStyleBackColor = true;
            this.btnRunL2T2.Click += new System.EventHandler(this.btnRunL2T2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Практична робота №5 - Варіант 2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRunL1T1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbL1T1_g;
        private System.Windows.Forms.RichTextBox rtbL1T1_f;
        private System.Windows.Forms.Label lblL1T2Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRunL1T2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbL2T2_res3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbL2T2_res2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbL2T2_res1;
        private System.Windows.Forms.Button btnRunL2T2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}