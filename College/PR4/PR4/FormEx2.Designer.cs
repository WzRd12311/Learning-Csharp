namespace PR4
{
    partial class FormEx2
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Element = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат перевірки: ";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(183, 116);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(171, 23);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Перевірити симетричність";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введіть массив по елементно: ";
            // 
            // Element
            // 
            this.Element.Location = new System.Drawing.Point(183, 76);
            this.Element.Name = "Element";
            this.Element.Size = new System.Drawing.Size(171, 20);
            this.Element.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 67);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть масив символів із 7 елементів. Визначте, чи він є симетричним\r\n(Симетричн" +
    "им вважається масив, який однаково читається зліва направо і праворуч\r\nналіво).\r" +
    "\n";
            // 
            // FormEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Element);
            this.Controls.Add(this.label1);
            this.Name = "FormEx2";
            this.Text = "FormEx2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Element;
        private System.Windows.Forms.Label label1;
    }
}