namespace PR3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f1 = new System.Windows.Forms.ToolStripMenuItem();
            this.f2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f1,
            this.f2ToolStripMenuItem,
            this.f3ToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.fToolStripMenuItem.Text = "F!";
            // 
            // f1
            // 
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(180, 22);
            this.f1.Text = "F1";
            this.f1.Click += new System.EventHandler(this.f1ToolStripMenuItem_Click);
            // 
            // f2ToolStripMenuItem
            // 
            this.f2ToolStripMenuItem.Name = "f2ToolStripMenuItem";
            this.f2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.f2ToolStripMenuItem.Text = "F2";
            // 
            // f3ToolStripMenuItem
            // 
            this.f3ToolStripMenuItem.Name = "f3ToolStripMenuItem";
            this.f3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.f3ToolStripMenuItem.Text = "F3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f1;
        private System.Windows.Forms.ToolStripMenuItem f2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f3ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

