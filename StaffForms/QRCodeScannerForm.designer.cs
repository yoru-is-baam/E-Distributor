namespace StaffForms
{
	partial class QRCodeScannerForm
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
			this.DataGridView = new System.Windows.Forms.DataGridView();
			this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BtnSelectQR = new System.Windows.Forms.Button();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.BtnLogout = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// DataGridView
			// 
			this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ItemName,
			this.ItemPrice,
			this.ItemQuantity});
			this.DataGridView.Location = new System.Drawing.Point(259, 111);
			this.DataGridView.Name = "DataGridView";
			this.DataGridView.RowHeadersWidth = 51;
			this.DataGridView.RowTemplate.Height = 24;
			this.DataGridView.Size = new System.Drawing.Size(598, 284);
			this.DataGridView.TabIndex = 3;
			this.DataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_RowsAdded);
			// 
			// ItemName
			// 
			this.ItemName.Frozen = true;
			this.ItemName.HeaderText = "Name";
			this.ItemName.MinimumWidth = 6;
			this.ItemName.Name = "ItemName";
			this.ItemName.ReadOnly = true;
			this.ItemName.Width = 125;
			// 
			// ItemPrice
			// 
			this.ItemPrice.Frozen = true;
			this.ItemPrice.HeaderText = "Price";
			this.ItemPrice.MinimumWidth = 6;
			this.ItemPrice.Name = "ItemPrice";
			this.ItemPrice.ReadOnly = true;
			this.ItemPrice.Width = 125;
			// 
			// ItemQuantity
			// 
			this.ItemQuantity.Frozen = true;
			this.ItemQuantity.HeaderText = "Quantity";
			this.ItemQuantity.MinimumWidth = 6;
			this.ItemQuantity.Name = "ItemQuantity";
			this.ItemQuantity.ReadOnly = true;
			this.ItemQuantity.Width = 125;
			// 
			// BtnSelectQR
			// 
			this.BtnSelectQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
			this.BtnSelectQR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnSelectQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSelectQR.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.BtnSelectQR.Location = new System.Drawing.Point(416, 40);
			this.BtnSelectQR.Name = "BtnSelectQR";
			this.BtnSelectQR.Size = new System.Drawing.Size(272, 41);
			this.BtnSelectQR.TabIndex = 4;
			this.BtnSelectQR.Text = "Choose QR to scan";
			this.BtnSelectQR.UseVisualStyleBackColor = false;
			this.BtnSelectQR.Click += new System.EventHandler(this.BtnSelectQR_Click);
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
			this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.BtnUpdate.Location = new System.Drawing.Point(416, 423);
			this.BtnUpdate.Name = "BtnUpdate";
			this.BtnUpdate.Size = new System.Drawing.Size(272, 64);
			this.BtnUpdate.TabIndex = 8;
			this.BtnUpdate.Text = "Update inventory";
			this.BtnUpdate.UseVisualStyleBackColor = false;
			this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// BtnLogout
			// 
			this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
			this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.BtnLogout.ForeColor = System.Drawing.Color.White;
			this.BtnLogout.Location = new System.Drawing.Point(991, 39);
			this.BtnLogout.Name = "BtnLogout";
			this.BtnLogout.Size = new System.Drawing.Size(89, 41);
			this.BtnLogout.TabIndex = 9;
			this.BtnLogout.Text = "Logout";
			this.BtnLogout.UseVisualStyleBackColor = false;
			this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
			// 
			// QRCodeScannerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 522);
			this.Controls.Add(this.BtnLogout);
			this.Controls.Add(this.BtnUpdate);
			this.Controls.Add(this.BtnSelectQR);
			this.Controls.Add(this.DataGridView);
			this.Name = "QRCodeScannerForm";
			this.Text = "QRCodeScanner";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QRCodeScannerForm_FormClosed);
			this.Load += new System.EventHandler(this.QRCodeScannerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView DataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
		private System.Windows.Forms.Button BtnSelectQR;
		private System.Windows.Forms.Button BtnUpdate;
		private System.Windows.Forms.Button BtnLogout;
	}
}

