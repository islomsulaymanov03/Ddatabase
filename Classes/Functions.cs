using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_CRUD.Classes
{
	public static class Functions
	{
		public static void GetTable()
		{
			string query = @"SELECT table_name 
                             FROM information_schema.tables 
                             WHERE table_schema = 'public';";
			using (var connection = new NpgsqlConnection(EnterMain.connectionString))
			{
				connection.Open();
				var tables = new List<string>();

				using (var cmd = new NpgsqlCommand(query, connection))
				{
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							tables.Add(reader.GetString(0));
						}
					}
				}
				//MainForm mainForm = new MainForm();
				MainForm.comboBox1.DataSource = tables;

				//MainForm mainForm = new MainForm();
				//mainForm.comboBox1.DataSource = tables;
				////MessageBox.Show(String.Join(" ", tables));
			}
		}
		public static ComboBox CreateCombo(int count)
		{
			var types = new ComboBox();
			types.Name = "typesCombo" + (count + 1).ToString();
			//types.Size = new Size()

			types.Items.Add("SERIAL");
			types.Items.Add("INT");
			types.Items.Add("TEXT");
			types.Items.Add("VARCHAR");
			types.Items.Add("DECIMAL");

			return types;
		}

		public static TextBox CreateTextBox(int count)
		{
			TextBox textBox = new TextBox();

			textBox.Name = "textBox" + (count + 1).ToString();
			textBox.Text = "column" + count.ToString();

			return textBox;
		}
	}
}