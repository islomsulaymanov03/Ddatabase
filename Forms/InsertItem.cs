﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Database_CRUD.Forms
{
	public partial class InsertItem : Form
	{
		private List<TextBox> textBoxes = new List<TextBox>();
		private string tableName;
		private List<string> columnNames = new List<string>();

		public InsertItem()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBoxes.Count == 0)
			{
				MessageBox.Show("No columns found to insert data.");
				return;
			}

			string query = $"INSERT INTO {MainForm.getTableName} (";
			query += string.Join(", ", columnNames);
			query += ") VALUES (";
			query += string.Join(", ", columnNames.Select((col, index) => $"@{col}"));
			query += ");";

			try
			{
				using (var connection = new NpgsqlConnection(EnterMain.connectionString))
				{
					connection.Open();
					using (var command = new NpgsqlCommand(query, connection))
					{
						for (int i = 0; i < columnNames.Count; i++)
						{
							command.Parameters.AddWithValue($"@{columnNames[i]}", textBoxes[i].Text);
						}

						command.ExecuteNonQuery();
						MessageBox.Show("Data inserted successfully!");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error inserting data: {ex.Message}");
			}
		}

		
		private void InsertItem_Load(object sender, EventArgs e)
		{
			tableName = MainForm.getTableName();
			LoadTableColumns();
		}

	
		private void LoadTableColumns()
		{
			try
			{
				using (var connection = new NpgsqlConnection(EnterMain.connectionString))
				{
					connection.Open();
					string query = $@"
                        SELECT column_name
                        FROM information_schema.columns
                        WHERE table_name = '{tableName}';
                    ";

					using (var command = new NpgsqlCommand(query, connection))
					{
						using (var reader = command.ExecuteReader())
						{
							int yoffset = 10;
							panel1.Controls.Clear();
							textBoxes.Clear();
							columnNames.Clear();

							while (reader.Read())
							{
								string columnName = reader.GetString(0);
								columnNames.Add(columnName);

								Label label = new Label();
								label.Text = $"{columnName}:";
								label.Location = new Point(10, yoffset);
								panel1.Controls.Add(label);

								TextBox textBox = new TextBox();
								textBox.Name = $"txt_{columnName}";
								textBox.Location = new Point(150, yoffset);
								textBoxes.Add(textBox);
								panel1.Controls.Add(textBox);

								yoffset += 30;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading table columns: {ex.Message}");
			}
		}

	
		private void button2_Click_1(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			this.Hide();
			mainForm.ShowDialog();
			this.Close();
		}
	}
}

