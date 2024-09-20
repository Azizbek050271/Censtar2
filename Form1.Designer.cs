namespace Censtar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectedToolStripMenuItem,
            this.DisconnectedToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ConnectedToolStripMenuItem
            // 
            this.ConnectedToolStripMenuItem.Name = "ConnectedToolStripMenuItem";
            this.ConnectedToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ConnectedToolStripMenuItem.Text = "Connected";
            this.ConnectedToolStripMenuItem.Click += new System.EventHandler(this.ConnectedToolStripMenuItem_Click);
            // 
            // DisconnectedToolStripMenuItem
            // 
            this.DisconnectedToolStripMenuItem.Name = "DisconnectedToolStripMenuItem";
            this.DisconnectedToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.DisconnectedToolStripMenuItem.Text = "Disconnected";
            this.DisconnectedToolStripMenuItem.Click += new System.EventHandler(this.DisconnectedToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortSettingToolStripMenuItem,
            this.PriceSettingToolStripMenuItem});
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.SettingToolStripMenuItem.Text = "Setting";
            // 
            // PortSettingToolStripMenuItem
            // 
            this.PortSettingToolStripMenuItem.Name = "PortSettingToolStripMenuItem";
            this.PortSettingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.PortSettingToolStripMenuItem.Text = "Port setting";
            this.PortSettingToolStripMenuItem.Click += new System.EventHandler(this.PortSettingToolStripMenuItem_Click);
            // 
            // PriceSettingToolStripMenuItem
            // 
            this.PriceSettingToolStripMenuItem.Name = "PriceSettingToolStripMenuItem";
            this.PriceSettingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.PriceSettingToolStripMenuItem.Text = "Price setting";
            this.PriceSettingToolStripMenuItem.Click += new System.EventHandler(this.PriceSettingToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _statusLabel
            // 
            this._statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(154, 17);
            this._statusLabel.Text = "Ожидание подключения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CENSTAR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Объявление элементов управления
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PortSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PriceSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisconnectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _statusLabel;
    }
}
