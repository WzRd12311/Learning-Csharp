namespace WindowsFormsApp1
{
    partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioAutomaticMode2 = new System.Windows.Forms.RadioButton();
            this.resultArrayEx2 = new System.Windows.Forms.Label();
            this.radioHandleMode2 = new System.Windows.Forms.RadioButton();
            this.performEx2 = new System.Windows.Forms.Button();
            this.curArrayEx2 = new System.Windows.Forms.Label();
            this.btnAutoFillEx2 = new System.Windows.Forms.Button();
            this.textBoxEx2 = new System.Windows.Forms.TextBox();
            this.enterElementEx2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioAutomaticMode3 = new System.Windows.Forms.RadioButton();
            this.resultArrayEx3 = new System.Windows.Forms.Label();
            this.radioHandleMode3 = new System.Windows.Forms.RadioButton();
            this.calculateButton3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAutoFill3 = new System.Windows.Forms.Button();
            this.textBoxEx3 = new System.Windows.Forms.TextBox();
            this.enterElementEx3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generateButton4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.resultLabel);
            this.tabPage1.Controls.Add(this.convertButton);
            this.tabPage1.Controls.Add(this.binaryTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(519, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Example 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 61);
            this.label7.TabIndex = 4;
            this.label7.Text = "Дано ціле число у двійковій системі числення , тобто . послідовність цифр 0 та 1." +
    " Скласти програму перекладу цього числа у вісімкову систему числення";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(53, 204);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(43, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result: ";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(118, 140);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(96, 20);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Location = new System.Drawing.Point(118, 82);
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.Size = new System.Drawing.Size(96, 20);
            this.binaryTextBox.TabIndex = 1;
            this.binaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.binaryTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter binary number:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.radioAutomaticMode2);
            this.tabPage2.Controls.Add(this.resultArrayEx2);
            this.tabPage2.Controls.Add(this.radioHandleMode2);
            this.tabPage2.Controls.Add(this.performEx2);
            this.tabPage2.Controls.Add(this.curArrayEx2);
            this.tabPage2.Controls.Add(this.btnAutoFillEx2);
            this.tabPage2.Controls.Add(this.textBoxEx2);
            this.tabPage2.Controls.Add(this.enterElementEx2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Example 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 53);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ввести масив , що складається з 8 елементів ( вісім двоцифрових чисел) цілого тип" +
    "у .Отримати новий масив , що складається із цифр, що перебувають у молодших розр" +
    "ядах елементів";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Write Mode:";
            // 
            // radioAutomaticMode2
            // 
            this.radioAutomaticMode2.AutoSize = true;
            this.radioAutomaticMode2.Location = new System.Drawing.Point(294, 145);
            this.radioAutomaticMode2.Name = "radioAutomaticMode2";
            this.radioAutomaticMode2.Size = new System.Drawing.Size(101, 17);
            this.radioAutomaticMode2.TabIndex = 1;
            this.radioAutomaticMode2.Text = "Automatic mode";
            this.radioAutomaticMode2.UseVisualStyleBackColor = true;
            // 
            // resultArrayEx2
            // 
            this.resultArrayEx2.AutoSize = true;
            this.resultArrayEx2.Location = new System.Drawing.Point(66, 313);
            this.resultArrayEx2.Name = "resultArrayEx2";
            this.resultArrayEx2.Size = new System.Drawing.Size(69, 13);
            this.resultArrayEx2.TabIndex = 6;
            this.resultArrayEx2.Text = "Result array: ";
            // 
            // radioHandleMode2
            // 
            this.radioHandleMode2.AutoSize = true;
            this.radioHandleMode2.Checked = true;
            this.radioHandleMode2.Location = new System.Drawing.Point(294, 108);
            this.radioHandleMode2.Name = "radioHandleMode2";
            this.radioHandleMode2.Size = new System.Drawing.Size(88, 17);
            this.radioHandleMode2.TabIndex = 0;
            this.radioHandleMode2.TabStop = true;
            this.radioHandleMode2.Text = "Handle mode";
            this.radioHandleMode2.UseVisualStyleBackColor = true;
            this.radioHandleMode2.CheckedChanged += new System.EventHandler(this.CheckedChanged2);
            // 
            // performEx2
            // 
            this.performEx2.Location = new System.Drawing.Point(164, 237);
            this.performEx2.Name = "performEx2";
            this.performEx2.Size = new System.Drawing.Size(100, 23);
            this.performEx2.TabIndex = 5;
            this.performEx2.Text = "Perform";
            this.performEx2.UseVisualStyleBackColor = true;
            this.performEx2.Click += new System.EventHandler(this.performEx2_Click);
            // 
            // curArrayEx2
            // 
            this.curArrayEx2.AutoSize = true;
            this.curArrayEx2.Location = new System.Drawing.Point(101, 185);
            this.curArrayEx2.Name = "curArrayEx2";
            this.curArrayEx2.Size = new System.Drawing.Size(71, 13);
            this.curArrayEx2.TabIndex = 4;
            this.curArrayEx2.Text = "Current Array:";
            // 
            // btnAutoFillEx2
            // 
            this.btnAutoFillEx2.Location = new System.Drawing.Point(164, 131);
            this.btnAutoFillEx2.Name = "btnAutoFillEx2";
            this.btnAutoFillEx2.Size = new System.Drawing.Size(100, 23);
            this.btnAutoFillEx2.TabIndex = 2;
            this.btnAutoFillEx2.Text = "Auto fill";
            this.btnAutoFillEx2.UseVisualStyleBackColor = true;
            this.btnAutoFillEx2.Visible = false;
            this.btnAutoFillEx2.Click += new System.EventHandler(this.AutoFill_Click2);
            // 
            // textBoxEx2
            // 
            this.textBoxEx2.Location = new System.Drawing.Point(164, 81);
            this.textBoxEx2.Name = "textBoxEx2";
            this.textBoxEx2.Size = new System.Drawing.Size(100, 20);
            this.textBoxEx2.TabIndex = 1;
            this.textBoxEx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEx2_KeyPress);
            this.textBoxEx2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEx2_KeyUp);
            // 
            // enterElementEx2
            // 
            this.enterElementEx2.AutoSize = true;
            this.enterElementEx2.Location = new System.Drawing.Point(8, 84);
            this.enterElementEx2.Name = "enterElementEx2";
            this.enterElementEx2.Size = new System.Drawing.Size(155, 13);
            this.enterElementEx2.TabIndex = 0;
            this.enterElementEx2.Text = "Enter two-digit element of array:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.radioAutomaticMode3);
            this.tabPage3.Controls.Add(this.resultArrayEx3);
            this.tabPage3.Controls.Add(this.radioHandleMode3);
            this.tabPage3.Controls.Add(this.calculateButton3);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.btnAutoFill3);
            this.tabPage3.Controls.Add(this.textBoxEx3);
            this.tabPage3.Controls.Add(this.enterElementEx3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(519, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Example 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Current matrix:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(432, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Даний двомірний масив 7×7. Знайти суму модулів негативних непарних елементів .";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Write Mode:";
            // 
            // radioAutomaticMode3
            // 
            this.radioAutomaticMode3.AutoSize = true;
            this.radioAutomaticMode3.Location = new System.Drawing.Point(293, 89);
            this.radioAutomaticMode3.Name = "radioAutomaticMode3";
            this.radioAutomaticMode3.Size = new System.Drawing.Size(101, 17);
            this.radioAutomaticMode3.TabIndex = 1;
            this.radioAutomaticMode3.Text = "Automatic mode";
            this.radioAutomaticMode3.UseVisualStyleBackColor = true;
            // 
            // resultArrayEx3
            // 
            this.resultArrayEx3.AutoSize = true;
            this.resultArrayEx3.Location = new System.Drawing.Point(8, 368);
            this.resultArrayEx3.Name = "resultArrayEx3";
            this.resultArrayEx3.Size = new System.Drawing.Size(43, 13);
            this.resultArrayEx3.TabIndex = 6;
            this.resultArrayEx3.Text = "Result: ";
            // 
            // radioHandleMode3
            // 
            this.radioHandleMode3.AutoSize = true;
            this.radioHandleMode3.Checked = true;
            this.radioHandleMode3.Location = new System.Drawing.Point(293, 66);
            this.radioHandleMode3.Name = "radioHandleMode3";
            this.radioHandleMode3.Size = new System.Drawing.Size(88, 17);
            this.radioHandleMode3.TabIndex = 0;
            this.radioHandleMode3.TabStop = true;
            this.radioHandleMode3.Text = "Handle mode";
            this.radioHandleMode3.UseVisualStyleBackColor = true;
            this.radioHandleMode3.CheckedChanged += new System.EventHandler(this.CheckedChanged3);
            // 
            // calculateButton3
            // 
            this.calculateButton3.Location = new System.Drawing.Point(73, 323);
            this.calculateButton3.Name = "calculateButton3";
            this.calculateButton3.Size = new System.Drawing.Size(100, 23);
            this.calculateButton3.TabIndex = 5;
            this.calculateButton3.Text = "Calculate";
            this.calculateButton3.UseVisualStyleBackColor = true;
            this.calculateButton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 186);
            this.listBox1.TabIndex = 4;
            // 
            // btnAutoFill3
            // 
            this.btnAutoFill3.Location = new System.Drawing.Point(73, 277);
            this.btnAutoFill3.Name = "btnAutoFill3";
            this.btnAutoFill3.Size = new System.Drawing.Size(100, 23);
            this.btnAutoFill3.TabIndex = 2;
            this.btnAutoFill3.Text = "Auto Fill";
            this.btnAutoFill3.UseVisualStyleBackColor = true;
            this.btnAutoFill3.Visible = false;
            this.btnAutoFill3.Click += new System.EventHandler(this.btnAutoFill3_Click);
            // 
            // textBoxEx3
            // 
            this.textBoxEx3.Location = new System.Drawing.Point(184, 258);
            this.textBoxEx3.MaxLength = 5;
            this.textBoxEx3.Name = "textBoxEx3";
            this.textBoxEx3.Size = new System.Drawing.Size(100, 20);
            this.textBoxEx3.TabIndex = 1;
            this.textBoxEx3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBoxEx3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // enterElementEx3
            // 
            this.enterElementEx3.AutoSize = true;
            this.enterElementEx3.Location = new System.Drawing.Point(37, 261);
            this.enterElementEx3.Name = "enterElementEx3";
            this.enterElementEx3.Size = new System.Drawing.Size(141, 13);
            this.enterElementEx3.TabIndex = 0;
            this.enterElementEx3.Text = "Enter element of matrix [0,0]:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.listBox3);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.generateButton4);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(519, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Example 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._123;
            this.pictureBox1.Location = new System.Drawing.Point(327, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 33);
            this.label10.TabIndex = 7;
            this.label10.Text = "Необхідно заповнити двомірний масив з 0 та 1. А після його виведення - масив пови" +
    "нен мати наступний вид:";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(85, 242);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(276, 238);
            this.listBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resulting Matrix:";
            // 
            // generateButton4
            // 
            this.generateButton4.Location = new System.Drawing.Point(174, 173);
            this.generateButton4.Name = "generateButton4";
            this.generateButton4.Size = new System.Drawing.Size(100, 20);
            this.generateButton4.TabIndex = 4;
            this.generateButton4.Text = "Generate";
            this.generateButton4.UseVisualStyleBackColor = true;
            this.generateButton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(174, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEX4_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Columns (n):";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEX4_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Rows (m):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Practice №3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultArrayEx2;
        private System.Windows.Forms.Button performEx2;
        private System.Windows.Forms.Label curArrayEx2;
        private System.Windows.Forms.Button btnAutoFillEx2;
        private System.Windows.Forms.TextBox textBoxEx2;
        private System.Windows.Forms.Label enterElementEx2;
        private System.Windows.Forms.Label resultArrayEx3;
        private System.Windows.Forms.Button calculateButton3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioAutomaticMode3;
        private System.Windows.Forms.RadioButton radioHandleMode3;
        private System.Windows.Forms.Button btnAutoFill3;
        private System.Windows.Forms.TextBox textBoxEx3;
        private System.Windows.Forms.Label enterElementEx3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateButton4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioAutomaticMode2;
        private System.Windows.Forms.RadioButton radioHandleMode2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
    }
}