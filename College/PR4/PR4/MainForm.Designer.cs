namespace PR4
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.завданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.першеЗавданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.другеЗавданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.третєЗавданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.четвертеЗавданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завданняToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // завданняToolStripMenuItem
            // 
            this.завданняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.першеЗавданняToolStripMenuItem,
            this.toolStripSeparator1,
            this.другеЗавданняToolStripMenuItem,
            this.toolStripSeparator2,
            this.третєЗавданняToolStripMenuItem,
            this.toolStripSeparator3,
            this.четвертеЗавданняToolStripMenuItem});
            this.завданняToolStripMenuItem.Name = "завданняToolStripMenuItem";
            this.завданняToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.завданняToolStripMenuItem.Text = "Завдання";
            // 
            // першеЗавданняToolStripMenuItem
            // 
            this.першеЗавданняToolStripMenuItem.Name = "першеЗавданняToolStripMenuItem";
            this.першеЗавданняToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.першеЗавданняToolStripMenuItem.Text = "Перше завдання";
            this.першеЗавданняToolStripMenuItem.Click += new System.EventHandler(this.Ex1ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // другеЗавданняToolStripMenuItem
            // 
            this.другеЗавданняToolStripMenuItem.Name = "другеЗавданняToolStripMenuItem";
            this.другеЗавданняToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.другеЗавданняToolStripMenuItem.Text = "Друге завдання";
            this.другеЗавданняToolStripMenuItem.Click += new System.EventHandler(this.Ex2ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // третєЗавданняToolStripMenuItem
            // 
            this.третєЗавданняToolStripMenuItem.Name = "третєЗавданняToolStripMenuItem";
            this.третєЗавданняToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.третєЗавданняToolStripMenuItem.Text = "Третє завдання";
            this.третєЗавданняToolStripMenuItem.Click += new System.EventHandler(this.Ex3ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // четвертеЗавданняToolStripMenuItem
            // 
            this.четвертеЗавданняToolStripMenuItem.Name = "четвертеЗавданняToolStripMenuItem";
            this.четвертеЗавданняToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.четвертеЗавданняToolStripMenuItem.Text = "Четверте завдання";
            this.четвертеЗавданняToolStripMenuItem.Click += new System.EventHandler(this.Ex4ToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Практична №4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem завданняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem першеЗавданняToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem другеЗавданняToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem третєЗавданняToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem четвертеЗавданняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
    }
}

