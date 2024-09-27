namespace Database_CRUD.Forms
{
	partial class UpdateForm
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
			txtUpdateTableName = new TextBox();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(77, 84);
			label1.Name = "label1";
			label1.Size = new Size(153, 20);
			label1.TabIndex = 0;
			label1.Text = "Enter new table name";
			// 
			// txtUpdateTableName
			// 
			txtUpdateTableName.Location = new Point(286, 84);
			txtUpdateTableName.Name = "txtUpdateTableName";
			txtUpdateTableName.Size = new Size(217, 27);
			txtUpdateTableName.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(77, 191);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "Back";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(409, 191);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 3;
			button2.Text = "Save";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// UpdateForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(618, 358);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(txtUpdateTableName);
			Controls.Add(label1);
			Name = "UpdateForm";
			Text = "UpdateForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtUpdateTableName;
		private Button button1;
		private Button button2;
	}
}