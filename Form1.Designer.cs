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
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PortSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PriceSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectedToolStripMenuItem,
            this.DisconnectedToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.FileToolStripMenuItem.Text = "File";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // ConnectedToolStripMenuItem
            // 
            this.ConnectedToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConnectedToolStripMenuItem.Name = "ConnectedToolStripMenuItem";
            this.ConnectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ConnectedToolStripMenuItem.Text = "Connected";
            this.ConnectedToolStripMenuItem.Click += new System.EventHandler(this.ConnectedToolStripMenuItem_Click);
            // 
            // DisconnectedToolStripMenuItem
            // 
            this.DisconnectedToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DisconnectedToolStripMenuItem.Name = "DisconnectedToolStripMenuItem";
            this.DisconnectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DisconnectedToolStripMenuItem.Text = "Disconnected";
            this.DisconnectedToolStripMenuItem.Click += new System.EventHandler(this.DisconnectedToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortSettingToolStripMenuItem,
            this.PriceSettingToolStripMenuItem});
            this.SettingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.SettingToolStripMenuItem.Text = "Setting";
            // 
            // PortSettingToolStripMenuItem
            // 
            this.PortSettingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PortSettingToolStripMenuItem.Name = "PortSettingToolStripMenuItem";
            this.PortSettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PortSettingToolStripMenuItem.Text = "Port setting";
            this.PortSettingToolStripMenuItem.Click += new System.EventHandler(this.PortSettingToolStripMenuItem_Click);
            // 
            // PriceSettingToolStripMenuItem
            // 
            this.PriceSettingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PriceSettingToolStripMenuItem.Name = "PriceSettingToolStripMenuItem";
            this.PriceSettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PriceSettingToolStripMenuItem.Text = "Price setting";
            this.PriceSettingToolStripMenuItem.Click += new System.EventHandler(this.PriceSettingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CENSTAR";
            this.Text = "CENSTAR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PortSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PriceSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisconnectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}

