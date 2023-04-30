namespace StaffForms
{
	partial class LoginForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.UsernameBox = new System.Windows.Forms.TextBox();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnLogin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::StaffForms.Properties.Resources.secrecy_icon;
			this.pictureBox1.Location = new System.Drawing.Point(70, 133);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(206, 251);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// UsernameBox
			// 
			this.UsernameBox.Location = new System.Drawing.Point(153, 50);
			this.UsernameBox.Name = "UsernameBox";
			this.UsernameBox.Size = new System.Drawing.Size(214, 22);
			this.UsernameBox.TabIndex = 1;
			// 
			// PasswordBox
			// 
			this.PasswordBox.Location = new System.Drawing.Point(153, 119);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.PasswordChar = '*';
			this.PasswordBox.Size = new System.Drawing.Size(214, 22);
			this.PasswordBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(315, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 33);
			this.label3.TabIndex = 5;
			this.label3.Text = "LOGIN FORM";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnLogin);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.PasswordBox);
			this.groupBox1.Controls.Add(this.UsernameBox);
			this.groupBox1.Location = new System.Drawing.Point(321, 127);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(419, 257);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// BtnLogin
			// 
			this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
			this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnLogin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.ForeColor = System.Drawing.Color.White;
			this.BtnLogin.Location = new System.Drawing.Point(153, 177);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(214, 43);
			this.BtnLogin.TabIndex = 5;
			this.BtnLogin.Text = "Login";
			this.BtnLogin.UseVisualStyleBackColor = false;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox UsernameBox;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnLogin;
	}
}