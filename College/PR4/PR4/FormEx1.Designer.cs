namespace PR4
{
    partial class FormEx1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEx1));
            this.label1 = new System.Windows.Forms.Label();
            this.binaryArr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // binaryArr
            // 
            this.binaryArr.Location = new System.Drawing.Point(75, 110);
            this.binaryArr.MaxLength = 100;
            this.binaryArr.Name = "binaryArr";
            this.binaryArr.Size = new System.Drawing.Size(171, 20);
            this.binaryArr.TabIndex = 1;
            this.binaryArr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.binaryArr_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введіть число в двійковій системі числення:";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(75, 146);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(171, 23);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "Перевести у десяткову";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(72, 192);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(115, 13);
            this.Result.TabIndex = 4;
            this.Result.Text = "Результат переводу: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Максимальна кількість \r\nсимволів = 100";
            // 
            // FormEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.binaryArr);
            this.Controls.Add(this.label1);
            this.Name = "FormEx1";
            this.Text = "FormEx1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox binaryArr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label4;
    }
}