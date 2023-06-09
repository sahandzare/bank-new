using System;
using MySqlConnector;
using System.Xml.Linq;
using System.Windows.Forms;



namespace signup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            string email = textBox5.Text;
            string password = textBox4.Text;
            string username = textBox3.Text;

            decimal amountofmoney = decimal.Parse(amountmoney.Text);
            if (firstname != "" && password != "" && email != "" && username != " " && lastname != " ")
            {
                // Code to add user to database or file goes here
                MessageBox.Show("Sign-up successful!");
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
            // Get the values from the text boxes


            // Create a connection to the database
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=inslap;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Insert the data into the database
            string query = "INSERT INTO inslap.users (firstname, email,lastname,password,username,amountofmoney) VALUES (@firstname, @email,@lastname,@password,@username,@amountofmoney)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@amountofmoney", amountofmoney);

            command.ExecuteNonQuery();

            // Close the connection
            connection.Close();

            // Display a success message
            MessageBox.Show("Data sent to the database.");

            loginn form1 = new loginn();
            form1.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            loginn loginn = new loginn();
            loginn.Show(); 
            this.Hide();
        }
    }
}