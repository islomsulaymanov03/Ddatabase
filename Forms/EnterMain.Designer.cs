namespace Database_CRUD
{
	partial class EnterMain
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
			label1 = new Label();
			txtHost = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtPort = new TextBox();
			txtDatabase = new TextBox();
			txtUserName = new TextBox();
			txtPassword = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(242, 32);
			label1.Name = "label1";
			label1.Size = new Size(123, 20);
			label1.TabIndex = 0;
			label1.Text = "ConnectionString";
			// 
			// txtHost
			// 
			txtHost.Location = new Point(192, 93);
			txtHost.Name = "txtHost";
			txtHost.Size = new Size(236, 27);
			txtHost.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(79, 100);
			label2.Name = "label2";
			label2.Size = new Size(40, 20);
			label2.TabIndex = 2;
			label2.Text = "Host";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(79, 162);
			label3.Name = "label3";
			label3.Size = new Size(35, 20);
			label3.TabIndex = 3;
			label3.Text = "Port";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(79, 224);
			label4.Name = "label4";
			label4.Size = new Size(72, 20);
			label4.TabIndex = 4;
			label4.Text = "Database";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(79, 288);
			label5.Name = "label5";
			label5.Size = new Size(82, 20);
			label5.TabIndex = 5;
			label5.Text = "User Name";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(79, 344);
			label6.Name = "label6";
			label6.Size = new Size(70, 20);
			label6.TabIndex = 6;
			label6.Text = "Password";
			// 
			// txtPort
			// 
			txtPort.Location = new Point(192, 159);
			txtPort.Name = "txtPort";
			txtPort.Size = new Size(236, 27);
			txtPort.TabIndex = 7;
			// 
			// txtDatabase
			// 
			txtDatabase.Location = new Point(192, 217);
			txtDatabase.Name = "txtDatabase";
			txtDatabase.Size = new Size(236, 27);
			txtDatabase.TabIndex = 8;
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(192, 281);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(236, 27);
			txtUserName.TabIndex = 9;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(192, 344);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(236, 27);
			txtPassword.TabIndex = 10;
			// 
			// button1
			// 
			button1.Location = new Point(550, 344);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 11;
			button1.Text = "Enter";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// EnterMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(717, 450);
			Controls.Add(button1);
			Controls.Add(txtPassword);
			Controls.Add(txtUserName);
			Controls.Add(txtDatabase);
			Controls.Add(txtPort);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(txtHost);
			Controls.Add(label1);
			Name = "EnterMain";
			Text = "EnterMain";
			Load += EnterMain_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtHost;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox txtPort;
		private TextBox txtDatabase;
		private TextBox txtUserName;
		private TextBox txtPassword;
		private Button button1;
	}
}