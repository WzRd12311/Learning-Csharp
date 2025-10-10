namespace PR4
{
    partial class FormEx4
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
            this.Result = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ArraySymbA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ArraySymbB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(164, 209);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(135, 13);
            this.Result.TabIndex = 14;
            this.Result.Text = "Результат знаходження: ";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(167, 159);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(171, 23);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Знайти однакові символи";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введіть набір символів А: ";
            // 
            // ArraySymbA
            // 
            this.ArraySymbA.Location = new System.Drawing.Point(167, 73);
            this.ArraySymbA.MaxLength = 100;
            this.ArraySymbA.Name = "ArraySymbA";
            this.ArraySymbA.Size = new System.Drawing.Size(171, 20);
            this.ArraySymbA.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Задано два рядки. Побудувати новий рядок, що складається з символів, які\r\nвходять" +
    " як до одного, так і до іншого рядка.\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Введіть набір символів Б: ";
            // 
            // ArraySymbB
            // 
            this.ArraySymbB.Location = new System.Drawing.Point(167, 113);
            this.ArraySymbB.MaxLength = 100;
            this.ArraySymbB.Name = "ArraySymbB";
            this.ArraySymbB.Size = new System.Drawing.Size(171, 20);
            this.ArraySymbB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Максимальна кількість \r\nсимволів = 100";
            // 
            // FormEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArraySymbB);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArraySymbA);
            this.Controls.Add(this.label1);
            this.Name = "FormEx4";
            this.Text = "FormEx4";
            this.Load += new System.EventHandler(this.FormEx4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArraySymbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ArraySymbB;
        private System.Windows.Forms.Label label3;
    }
}