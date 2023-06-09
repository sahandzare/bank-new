using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace signup
{
    public partial class loginn : Form
    {
        public loginn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Connection string for MySQL database
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=inslap;";

            // Query to check if the user exists in the database
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();

                        int result = Convert.ToInt32(command.ExecuteScalar());

                        if (result > 0)
                        {
                            // Login successful
                            MessageBox.Show("Login successful.");


                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    home home = new home();
                    home.Show();
                    this.Hide();
                }

            }

        }
    }
}


