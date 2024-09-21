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
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.LblCurPrice = new System.Windows.Forms.Label();
            this.OrdAmounts = new System.Windows.Forms.Label();
            this.StatAmount = new System.Windows.Forms.Label();
            this.OrdLiters = new System.Windows.Forms.Label();
            this.StatLiters = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.Label();
            this.Liter = new System.Windows.Forms.Label();
            this.TbxAmount = new System.Windows.Forms.TextBox();
            this.TbxLiter = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.OrderPanel.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(311, 24);
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
            this.statusStrip1.Size = new System.Drawing.Size(311, 22);
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
            // OrderPanel
            // 
            this.OrderPanel.Controls.Add(this.LblCurPrice);
            this.OrderPanel.Controls.Add(this.OrdAmounts);
            this.OrderPanel.Controls.Add(this.StatAmount);
            this.OrderPanel.Controls.Add(this.OrdLiters);
            this.OrderPanel.Controls.Add(this.StatLiters);
            this.OrderPanel.Controls.Add(this.BtnReset);
            this.OrderPanel.Controls.Add(this.BtnStop);
            this.OrderPanel.Controls.Add(this.BtnStart);
            this.OrderPanel.Controls.Add(this.Amount);
            this.OrderPanel.Controls.Add(this.Liter);
            this.OrderPanel.Controls.Add(this.TbxAmount);
            this.OrderPanel.Controls.Add(this.TbxLiter);
            this.OrderPanel.Location = new System.Drawing.Point(29, 39);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(243, 332);
            this.OrderPanel.TabIndex = 2;
            this.OrderPanel.Visible = false;
            // 
            // LblCurPrice
            // 
            this.LblCurPrice.AutoSize = true;
            this.LblCurPrice.Location = new System.Drawing.Point(38, 0);
            this.LblCurPrice.Name = "LblCurPrice";
            this.LblCurPrice.Size = new System.Drawing.Size(84, 13);
            this.LblCurPrice.TabIndex = 11;
            this.LblCurPrice.Text = "Current price:";
            // 
            // OrdAmounts
            // 
            this.OrdAmounts.AutoSize = true;
            this.OrdAmounts.Location = new System.Drawing.Point(3, 189);
            this.OrdAmounts.Name = "OrdAmounts";
            this.OrdAmounts.Size = new System.Drawing.Size(86, 13);
            this.OrdAmounts.TabIndex = 10;
            this.OrdAmounts.Text = "OrderAmounts";
            // 
            // StatAmount
            // 
            this.StatAmount.AutoSize = true;
            this.StatAmount.Location = new System.Drawing.Point(84, 165);
            this.StatAmount.Name = "StatAmount";
            this.StatAmount.Size = new System.Drawing.Size(55, 13);
            this.StatAmount.TabIndex = 9;
            this.StatAmount.Text = "Amounts";
            // 
            // OrdLiters
            // 
            this.OrdLiters.AutoSize = true;
            this.OrdLiters.Location = new System.Drawing.Point(3, 139);
            this.OrdLiters.Name = "OrdLiters";
            this.OrdLiters.Size = new System.Drawing.Size(69, 13);
            this.OrdLiters.TabIndex = 8;
            this.OrdLiters.Text = "OrderLiters";
            // 
            // StatLiters
            // 
            this.StatLiters.AutoSize = true;
            this.StatLiters.Location = new System.Drawing.Point(84, 121);
            this.StatLiters.Name = "StatLiters";
            this.StatLiters.Size = new System.Drawing.Size(38, 13);
            this.StatLiters.TabIndex = 7;
            this.StatLiters.Text = "Liters";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(168, 269);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(87, 269);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(6, 269);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(153, 216);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(53, 13);
            this.Amount.TabIndex = 3;
            this.Amount.Text = "Amount:";
            // 
            // Liter
            // 
            this.Liter.AutoSize = true;
            this.Liter.Location = new System.Drawing.Point(36, 216);
            this.Liter.Name = "Liter";
            this.Liter.Size = new System.Drawing.Size(36, 13);
            this.Liter.TabIndex = 2;
            this.Liter.Text = "Liter:";
            // 
            // TbxAmount
            // 
            this.TbxAmount.Location = new System.Drawing.Point(127, 232);
            this.TbxAmount.Name = "TbxAmount";
            this.TbxAmount.Size = new System.Drawing.Size(116, 20);
            this.TbxAmount.TabIndex = 1;
            // 
            // TbxLiter
            // 
            this.TbxLiter.Location = new System.Drawing.Point(6, 232);
            this.TbxLiter.Name = "TbxLiter";
            this.TbxLiter.Size = new System.Drawing.Size(115, 20);
            this.TbxLiter.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.OrderPanel);
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
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
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
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.TextBox TbxAmount;
        private System.Windows.Forms.TextBox TbxLiter;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Liter;
        private System.Windows.Forms.Label OrdAmounts;
        private System.Windows.Forms.Label StatAmount;
        private System.Windows.Forms.Label OrdLiters;
        private System.Windows.Forms.Label StatLiters;
        private System.Windows.Forms.Label LblCurPrice;
    }
}
