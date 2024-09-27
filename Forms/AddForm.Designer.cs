namespace Database_CRUD
{
	partial class AddForm
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
			txtTableName = new TextBox();
			button1 = new Button();
			button2 = new Button();
			npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
			columnsPnl = new Panel();
			button3 = new Button();
			button4 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(89, 31);
			label1.Name = "label1";
			label1.Size = new Size(88, 20);
			label1.TabIndex = 0;
			label1.Text = "Table Name";
			// 
			// txtTableName
			// 
			txtTableName.Location = new Point(204, 28);
			txtTableName.Name = "txtTableName";
			txtTableName.Size = new Size(252, 27);
			txtTableName.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(246, 394);
			button1.Name = "button1";
			button1.Size = new Size(160, 29);
			button1.TabIndex = 14;
			button1.Text = "Delate columns";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(12, 394);
			button2.Name = "button2";
			button2.Size = new Size(172, 29);
			button2.TabIndex = 15;
			button2.Text = "Add columns\r\n\r\n";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// npgsqlCommandBuilder1
			// 
			npgsqlCommandBuilder1.QuotePrefix = "\"";
			npgsqlCommandBuilder1.QuoteSuffix = "\"";
			// 
			// columnsPnl
			// 
			columnsPnl.Location = new Point(12, 93);
			columnsPnl.Name = "columnsPnl";
			columnsPnl.Size = new Size(754, 295);
			columnsPnl.TabIndex = 16;
			columnsPnl.Paint += columnsPnl_Paint;
			// 
			// button3
			// 
			button3.Location = new Point(615, 394);
			button3.Name = "button3";
			button3.Size = new Size(151, 29);
			button3.TabIndex = 17;
			button3.Text = "Back";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(462, 394);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 18;
			button4.Text = "Add table";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// AddForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(columnsPnl);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(txtTableName);
			Controls.Add(label1);
			Name = "AddForm";
			Text = "AddForm";
			Load += AddForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtTableName;
		private Button button1;
		private Button button2;
		private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
		private Panel columnsPnl;
		private Button button3;
		private Button button4;
	}
}