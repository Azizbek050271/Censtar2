namespace Censtar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedToolStripMenuItem,
            this.disconnectedToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portSettingToolStripMenuItem,
            this.priceSettingToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // portSettingToolStripMenuItem
            // 
            this.portSettingToolStripMenuItem.Name = "portSettingToolStripMenuItem";
            this.portSettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.portSettingToolStripMenuItem.Text = "Port setting";
            this.portSettingToolStripMenuItem.Click += new System.EventHandler(this.portSettingToolStripMenuItem_Click);
            // 
            // priceSettingToolStripMenuItem
            // 
            this.priceSettingToolStripMenuItem.Name = "priceSettingToolStripMenuItem";
            this.priceSettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.priceSettingToolStripMenuItem.Text = "Price setting";
            this.priceSettingToolStripMenuItem.Click += new System.EventHandler(this.priceSettingToolStripMenuItem_Click);
            // 
            // connectedToolStripMenuItem
            // 
            this.connectedToolStripMenuItem.Name = "connectedToolStripMenuItem";
            this.connectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectedToolStripMenuItem.Text = "Connected";
            this.connectedToolStripMenuItem.Click += new System.EventHandler(this.connectedToolStripMenuItem_Click);
            // 
            // disconnectedToolStripMenuItem
            // 
            this.disconnectedToolStripMenuItem.Name = "disconnectedToolStripMenuItem";
            this.disconnectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectedToolStripMenuItem.Text = "Disconnected";
            this.disconnectedToolStripMenuItem.Click += new System.EventHandler(this.disconnectedToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

