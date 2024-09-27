using Database_CRUD.Classes;
using Database_CRUD.Forms;
using Npgsql;

namespace Database_CRUD
{
	public partial class MainForm : Form
	{

		
        private void MainForm_Load(object sender, EventArgs e)
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

				comboBox1.DataSource = tables;
				//MessageBox.Show(String.Join(" ", tables));
			}

			Functions.GetTable();
		}
		public MainForm()
		{
			InitializeComponent();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			EnterMain enterMain = new EnterMain();
			this.Hide();
			enterMain.ShowDialog();
			this.Close();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddForm addForm = new AddForm();
			this.Hide();
			addForm.ShowDialog();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UpdateForm updateForm = new UpdateForm();
			this.Hide();
			updateForm.ShowDialog();
			this.Close();

		}
		

		private void button3_Click(object sender, EventArgs e)
		{
			string tableName = comboBox1.SelectedItem.ToString();
			using (var connection = new NpgsqlConnection(EnterMain.connectionString))
			{
				string query = $"DROP TABLE IF EXISTS {tableName}";

				try
				{
					connection.Open();
					using (var command = new NpgsqlCommand(query, connection))
					{
						command.ExecuteNonQuery();

						Functions.GetTable();
						MessageBox.Show($"Table '{tableName}' deleted sucsessfully.");

					}
					connection.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error: {ex.Message}");
				}

			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{

				InsertItem insertItem = new InsertItem();
				this.Hide();
				insertItem.ShowDialog();
				this.Close();
			}
			catch
			{
				MessageBox.Show("Chose table");
			}
		}
		public static string getTableName()
		{
			return comboBox1.SelectedItem.ToString();
		}
	}
}
