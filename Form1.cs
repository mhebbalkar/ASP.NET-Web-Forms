using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Web_Form_Project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source=DESKTOP-CELUQR8\\SQLEXPRESS;Initial Catalog=loginapp;Integrated Security=True;TrustServerCertificate=True");
			con.Open();
			string query = "Select COUNT(*) from loginapp WHERE username=@username and password=@password";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.AddWithValue("@username", txtUser.Text);
			cmd.Parameters.AddWithValue("@password", txtPass.Text);
			int count = (int)cmd.ExecuteScalar();
			con.Close();
			if (count > 0)
			{
				MessageBox.Show("login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Error in Login");
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			txtPass.PasswordChar=checkBox1.Checked ? '\0' : '*';
		}
	}
}
