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

namespace Database_CRUD
{
	public partial class EnterMain : Form
	{
		public static string connectionString;
		public EnterMain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			connectionString = $@"Host={txtHost.Text}; Port={txtPort.Text}; Database={txtDatabase.Text}; Username={txtUserName.Text}; Password={txtPassword.Text} ";
			MainForm mainForm = new MainForm();
			this.Hide();
			mainForm.ShowDialog();
			this.Close();
		}

		private void EnterMain_Load(object sender, EventArgs e)
		{
			txtHost.Text = "localhost";
			txtPort.Text = "5432";
			txtDatabase.Text = "Psql_commends";
			txtUserName.Text = "postgres";
			txtPassword.Text = "SI(0311)";
		}
	}
}
