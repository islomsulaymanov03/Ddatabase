﻿namespace Database_CRUD.Forms
{
	partial class InsertItem
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
			panel1 = new Panel();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Location = new Point(46, 66);
			panel1.Name = "panel1";
			panel1.Size = new Size(711, 299);
			panel1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(663, 393);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(46, 393);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 1;
			button2.Text = "Back";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// InsertItem
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(panel1);
			Name = "InsertItem";
			Text = "InsertItem";
			Load += InsertItem_Load;
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button button1;
		private Button button2;
	}
}