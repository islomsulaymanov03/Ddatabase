namespace Database_CRUD
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			label1 = new Label();
			button5 = new Button();
			comboBox1 = new ComboBox();
			button4 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(93, 133);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "Add Table";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(93, 296);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 1;
			button2.Text = "Update";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(383, 296);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 2;
			button3.Text = "Delate";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(280, 24);
			label1.Name = "label1";
			label1.Size = new Size(44, 20);
			label1.TabIndex = 4;
			label1.Text = "Table";
			// 
			// button5
			// 
			button5.Location = new Point(247, 387);
			button5.Name = "button5";
			button5.Size = new Size(94, 29);
			button5.TabIndex = 6;
			button5.Text = "Back";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(187, 60);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(230, 28);
			comboBox1.TabIndex = 7;
			// 
			// button4
			// 
			button4.Location = new Point(383, 133);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 8;
			button4.Text = "Insert Item";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(715, 450);
			Controls.Add(button4);
			Controls.Add(comboBox1);
			Controls.Add(button5);
			Controls.Add(label1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "MainForm";
			Text = "MainForm";
			Load += MainForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private Button button3;
		private Label label1;
		private Button button5;
		private Button button4;
		public static ComboBox comboBox1;
	}
}
