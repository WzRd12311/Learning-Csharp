namespace CodeRedactor
{
    partial class FindForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBegin = new System.Windows.Forms.RadioButton();
            this.radioEnd = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Что:";
            // 
            // radioBegin
            // 
            this.radioBegin.AutoSize = true;
            this.radioBegin.Location = new System.Drawing.Point(23, 19);
            this.radioBegin.Name = "radioBegin";
            this.radioBegin.Size = new System.Drawing.Size(70, 17);
            this.radioBegin.TabIndex = 2;
            this.radioBegin.TabStop = true;
            this.radioBegin.Text = "С начала";
            this.radioBegin.UseVisualStyleBackColor = true;
            this.radioBegin.CheckedChanged += new System.EventHandler(this.directionCheckedChanged);
            // 
            // radioEnd
            // 
            this.radioEnd.AutoSize = true;
            this.radioEnd.Location = new System.Drawing.Point(23, 51);
            this.radioEnd.Name = "radioEnd";
            this.radioEnd.Size = new System.Drawing.Size(65, 17);
            this.radioEnd.TabIndex = 3;
            this.radioEnd.TabStop = true;
            this.radioEnd.Text = "С конца";
            this.radioEnd.UseVisualStyleBackColor = true;
            this.radioEnd.CheckedChanged += new System.EventHandler(this.directionCheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Найти далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FindClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBegin);
            this.groupBox1.Controls.Add(this.radioEnd);
            this.groupBox1.Location = new System.Drawing.Point(161, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Направление";
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Location = new System.Drawing.Point(12, 61);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(99, 17);
            this.cbMatchCase.TabIndex = 8;
            this.cbMatchCase.Text = "Учет регистра";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 128);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBegin;
        private System.Windows.Forms.RadioButton radioEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbMatchCase;
    }
}