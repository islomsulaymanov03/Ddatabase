using Database_CRUD.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Database_CRUD
{
	public partial class AddForm : Form
	{
		Stack<TextBox> columnNames = new Stack<TextBox>();
		Stack<ComboBox> columnTypes = new Stack<ComboBox>();

		public AddForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//MainForm form1 = new MainForm();
			//Hide();
			//form1.Show();

			TextBox t1 = columnNames.Pop();
			ComboBox c1 = columnTypes.Pop();

			columnsPnl.Controls.Remove(t1);
			columnsPnl.Controls.Remove(c1);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			List<string> str =new List<string>();
			TextBox t1 = Functions.CreateTextBox(columnNames.Count);
			ComboBox c1 = Functions.CreateCombo(columnTypes.Count);

			t1.Location = new Point(50, 10 + 30 * columnNames.Count);
			c1.Location = new Point(500, 10 + 30 * columnNames.Count);

			columnNames.Push(t1);
			columnTypes.Push(c1);
			columnsPnl.Controls.Add(t1);
			columnsPnl.Controls.Add(c1);
			//str.Add(c+","+columnTypes+",");

		}

		private void AddForm_Load(object sender, EventArgs e)
		{

			TextBox t1 = Functions.CreateTextBox(columnNames.Count);
			ComboBox c1 = Functions.CreateCombo(columnTypes.Count);

			t1.Location = new Point(50, 10);
			c1.Location = new Point(500, 10);

			columnNames.Push(t1);
			columnTypes.Push(c1);

			columnsPnl.Controls.Add(t1);
			columnsPnl.Controls.Add(c1);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.ShowDialog();
			this.Close();
		}

		private void columnsPnl_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{


			List<string> columnDefinitions = new List<string>();

			foreach (var t in columnNames.Zip(columnTypes, (textBox, comboBox) => new { textBox, comboBox }))
			{
				string columnName = t.textBox.Text;
				string columnType = t.comboBox.SelectedItem.ToString();

				if (!string.IsNullOrWhiteSpace(columnName) && !string.IsNullOrWhiteSpace(columnType))
				{
					columnDefinitions.Add($"{columnName} {columnType}");
				}
			}
			if (columnDefinitions.Count > 0 && !string.IsNullOrWhiteSpace(txtTableName.Text))
			{
				string createTableQuery = $"CREATE TABLE {txtTableName.Text} (\n{string.Join(",\n", columnDefinitions)}\n);";

				try
				{
					using (var conn = new NpgsqlConnection(EnterMain.connectionString))
					{
						conn.Open();
						using (var cmd = new NpgsqlCommand(createTableQuery, conn))
						{
							cmd.ExecuteNonQuery();
						}
					}
					MessageBox.Show("Table added!");
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error: {ex.Message}");
				}
			}
			else if (string.IsNullOrWhiteSpace(txtTableName.Text))
			{
				MessageBox.Show("Enter table name!");
			}
			else
			{
				MessageBox.Show("Add one column!");
			}
		}
	}
}
