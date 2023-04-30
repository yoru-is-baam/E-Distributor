namespace StaffForms
{
	partial class GoodsReceivingForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.QuantityBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PriceBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.DataGridView = new System.Windows.Forms.DataGridView();
			this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BtnExport = new System.Windows.Forms.Button();
			this.BtnResetAll = new System.Windows.Forms.Button();
			this.BtnReset = new System.Windows.Forms.Button();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(139)))), ((int)(((byte)(160)))));
			this.label1.Location = new System.Drawing.Point(310, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(557, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "GOODS RECEIVING AND WAREHOUSING";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.QuantityBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.PriceBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.NameBox);
			this.groupBox1.Location = new System.Drawing.Point(30, 122);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(416, 242);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item Information";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Quantity";
			// 
			// QuantityBox
			// 
			this.QuantityBox.Location = new System.Drawing.Point(136, 177);
			this.QuantityBox.Name = "QuantityBox";
			this.QuantityBox.Size = new System.Drawing.Size(240, 22);
			this.QuantityBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Price";
			// 
			// PriceBox
			// 
			this.PriceBox.Location = new System.Drawing.Point(136, 109);
			this.PriceBox.Name = "PriceBox";
			this.PriceBox.Size = new System.Drawing.Size(240, 22);
			this.PriceBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(42, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(136, 43);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(240, 22);
			this.NameBox.TabIndex = 0;
			// 
			// DataGridView
			// 
			this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemPrice,
            this.ItemQuantity});
			this.DataGridView.Location = new System.Drawing.Point(486, 122);
			this.DataGridView.Name = "DataGridView";
			this.DataGridView.ReadOnly = true;
			this.DataGridView.RowHeadersWidth = 51;
			this.DataGridView.RowTemplate.Height = 24;
			this.DataGridView.Size = new System.Drawing.Size(580, 242);
			this.DataGridView.TabIndex = 2;
			this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
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
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox2.Controls.Add(this.BtnExport);
			this.groupBox2.Controls.Add(this.BtnResetAll);
			this.groupBox2.Controls.Add(this.BtnReset);
			this.groupBox2.Controls.Add(this.BtnAdd);
			this.groupBox2.Location = new System.Drawing.Point(166, 397);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 157);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			// 
			// BtnExport
			// 
			this.BtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnExport.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.BtnExport.Location = new System.Drawing.Point(30, 89);
			this.BtnExport.Name = "BtnExport";
			this.BtnExport.Size = new System.Drawing.Size(104, 46);
			this.BtnExport.TabIndex = 3;
			this.BtnExport.Text = "Export QR";
			this.BtnExport.UseVisualStyleBackColor = false;
			this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
			// 
			// BtnResetAll
			// 
			this.BtnResetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(100)))), ((int)(((byte)(226)))));
			this.BtnResetAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnResetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnResetAll.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.BtnResetAll.Location = new System.Drawing.Point(150, 89);
			this.BtnResetAll.Name = "BtnResetAll";
			this.BtnResetAll.Size = new System.Drawing.Size(101, 46);
			this.BtnResetAll.TabIndex = 2;
			this.BtnResetAll.Text = "Reset All";
			this.BtnResetAll.UseVisualStyleBackColor = false;
			this.BtnResetAll.Click += new System.EventHandler(this.BtnResetAll_Click);
			// 
			// BtnReset
			// 
			this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(162)))), ((int)(((byte)(38)))));
			this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.BtnReset.Location = new System.Drawing.Point(150, 26);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(101, 45);
			this.BtnReset.TabIndex = 1;
			this.BtnReset.Text = "Reset";
			this.BtnReset.UseVisualStyleBackColor = false;
			this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// BtnAdd
			// 
			this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
			this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
			this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.BtnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.BtnAdd.Location = new System.Drawing.Point(30, 26);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(104, 45);
			this.BtnAdd.TabIndex = 0;
			this.BtnAdd.Text = "Add Item";
			this.BtnAdd.UseVisualStyleBackColor = false;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// GoodsReceivingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1114, 590);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.DataGridView);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "GoodsReceivingForm";
			this.Text = "GRaW";
			this.Load += new System.EventHandler(this.GoodsReceivingForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox QuantityBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PriceBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.DataGridView DataGridView;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnExport;
		private System.Windows.Forms.Button BtnResetAll;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
	}
}

