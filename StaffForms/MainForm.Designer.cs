namespace StaffForms
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.goodsReceivingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GoodsReceivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GoodsDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Gray;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsReceivingFormToolStripMenuItem,
            this.othersToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1064, 34);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// goodsReceivingFormToolStripMenuItem
			// 
			this.goodsReceivingFormToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.goodsReceivingFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoodsReceivingToolStripMenuItem,
            this.GoodsDeliveryToolStripMenuItem,
            this.ReportingToolStripMenuItem});
			this.goodsReceivingFormToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.goodsReceivingFormToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.goodsReceivingFormToolStripMenuItem.Name = "goodsReceivingFormToolStripMenuItem";
			this.goodsReceivingFormToolStripMenuItem.Size = new System.Drawing.Size(91, 30);
			this.goodsReceivingFormToolStripMenuItem.Text = "Forms";
			// 
			// GoodsReceivingToolStripMenuItem
			// 
			this.GoodsReceivingToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.GoodsReceivingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.GoodsReceivingToolStripMenuItem.Name = "GoodsReceivingToolStripMenuItem";
			this.GoodsReceivingToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
			this.GoodsReceivingToolStripMenuItem.Text = "Goods Receiving";
			this.GoodsReceivingToolStripMenuItem.Click += new System.EventHandler(this.GoodsReceivingToolStripMenuItem_Click);
			// 
			// GoodsDeliveryToolStripMenuItem
			// 
			this.GoodsDeliveryToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.GoodsDeliveryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.GoodsDeliveryToolStripMenuItem.Name = "GoodsDeliveryToolStripMenuItem";
			this.GoodsDeliveryToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
			this.GoodsDeliveryToolStripMenuItem.Text = "Goods Delivery";
			// 
			// ReportingToolStripMenuItem
			// 
			this.ReportingToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.ReportingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem";
			this.ReportingToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
			this.ReportingToolStripMenuItem.Text = "Reporting";
			// 
			// othersToolStripMenuItem
			// 
			this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.LogoutToolStripMenuItem});
			this.othersToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
			this.othersToolStripMenuItem.Size = new System.Drawing.Size(95, 30);
			this.othersToolStripMenuItem.Text = "Others";
			// 
			// viewProfileToolStripMenuItem
			// 
			this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
			this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
			this.viewProfileToolStripMenuItem.Text = "View profile";
			// 
			// LogoutToolStripMenuItem
			// 
			this.LogoutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.LogoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
			this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
			this.LogoutToolStripMenuItem.Text = " Logout";
			this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::StaffForms.Properties.Resources.banner;
			this.pictureBox1.Location = new System.Drawing.Point(12, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1040, 391);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem goodsReceivingFormToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GoodsReceivingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GoodsDeliveryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReportingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}