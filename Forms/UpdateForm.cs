using Npgsql;
using System;
using System.Windows.Forms;

namespace Database_CRUD.Forms
{
	public partial class UpdateForm : Form
	{
		public UpdateForm()
		{
			InitializeComponent();
		}

		
		private void button2_Click(object sender, EventArgs e)
		{
			string oldTableName = MainForm.getTableName(); 
			string newTableName = txtUpdateTableName.Text; 

			if (string.IsNullOrEmpty(newTableName))
			{
				MessageBox.Show("Please enter a new table name.");
				return;
			}

			// Jadval nomini o'zgartirish uchun so'rov
			string query = @$"ALTER TABLE {oldTableName} RENAME TO {newTableName};";

			try
			{
				using (var connection = new NpgsqlConnection(EnterMain.connectionString))
				{
					connection.Open();

					using (var command = new NpgsqlCommand(query, connection))
					{
						command.ExecuteNonQuery();
						MessageBox.Show($"Table {oldTableName} renamed to {newTableName}.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error renaming table: {ex.Message}");
			}
		}

		// Back button bosilganda asosiy oynaga qaytish
		private void button1_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			this.Hide();
			mainForm.ShowDialog();
			this.Close();
		}
	}
}
