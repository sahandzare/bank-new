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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void balance_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password = root; database = inslap; ";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Start a transaction to ensure atomicity
                connection.Open();

                string query = "SELECT  amountofmoney FROM users;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;
                connection.Close();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senderUsername = textBox1.Text;
            string recipientUsername = textBox2.Text;
            decimal transferAmount = decimal.Parse(textBox3.Text);
            string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password = root; database = inslap; ";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                // Retrieve sender's balance
                string senderBalanceQuery = "SELECT amountofmoney FROM users WHERE username = @username";
                MySqlCommand senderBalanceCommand = new MySqlCommand(senderBalanceQuery, connection);
                senderBalanceCommand.Parameters.AddWithValue("@username", senderUsername);
                object senderBalanceResult = senderBalanceCommand.ExecuteScalar();

                if (senderBalanceResult != null && senderBalanceResult != DBNull.Value)
                {
                    decimal senderBalance = Convert.ToDecimal(senderBalanceResult);

                    // Retrieve recipient's balance
                    string recipientBalanceQuery = "SELECT amountofmoney FROM users WHERE username = @username";
                    MySqlCommand recipientBalanceCommand = new MySqlCommand(recipientBalanceQuery, connection);
                    recipientBalanceCommand.Parameters.AddWithValue("@username", recipientUsername);
                    object recipientBalanceResult = recipientBalanceCommand.ExecuteScalar();

                    if (recipientBalanceResult != null && recipientBalanceResult != DBNull.Value)
                    {
                        decimal recipientBalance = Convert.ToDecimal(recipientBalanceResult);

                        // Check if sender has sufficient balance
                        if (senderBalance >= transferAmount)
                        {
                            // Update sender's balance
                            decimal newSenderBalance = senderBalance - transferAmount;
                            string updateSenderBalanceQuery = "UPDATE users SET amountofmoney = @amountofmoney WHERE username = @username";
                            MySqlCommand updateSenderBalanceCommand = new MySqlCommand(updateSenderBalanceQuery, connection);
                            updateSenderBalanceCommand.Parameters.AddWithValue("@amountofmoney", newSenderBalance);
                            updateSenderBalanceCommand.Parameters.AddWithValue("@username", senderUsername);
                            updateSenderBalanceCommand.ExecuteNonQuery();

                            // Update recipient's balance
                            decimal newRecipientBalance = recipientBalance + transferAmount;
                            string updateRecipientBalanceQuery = "UPDATE users SET amountofmoney = @amountofmoney WHERE username = @username";
                            MySqlCommand updateRecipientBalanceCommand = new MySqlCommand(updateRecipientBalanceQuery, connection);
                            updateRecipientBalanceCommand.Parameters.AddWithValue("@amountofmoney", newRecipientBalance);
                            updateRecipientBalanceCommand.Parameters.AddWithValue("@username", recipientUsername);
                            updateRecipientBalanceCommand.ExecuteNonQuery();

                            MessageBox.Show("Money transfer successful!");
                            string insertTransferQuery = "INSERT INTO transfer_history (sender_username, reciever_username, transfer_amount) VALUES (@sender_username, @reciever_username, @transfer_amount)";
                            MySqlCommand insertTransferCommand = new MySqlCommand(insertTransferQuery, connection);
                            insertTransferCommand.Parameters.AddWithValue("@sender_username", senderUsername);
                            insertTransferCommand.Parameters.AddWithValue("@reciever_username", recipientUsername);
                            insertTransferCommand.Parameters.AddWithValue("@transfer_amount", transferAmount);
                            insertTransferCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Insufficient balance!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Recipient balance not found or invalid.");
                    }
                }
                else
                {
                    MessageBox.Show("Sender balance not found or invalid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setting_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
            this.Hide();
        }

        private void history_Click(object sender, EventArgs e)
        {

            string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password = root; database = inslap; ";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {

                // Retrieve transfer history
                connection.Open();
                string transferHistoryQuery = "SELECT sender_username, reciever_username, transfer_amount, transfer_date FROM transfer_history";
                MySqlCommand transferHistoryCommand = new MySqlCommand(transferHistoryQuery, connection);
                MySqlDataAdapter transferHistoryDataAdapter = new MySqlDataAdapter(transferHistoryCommand);
                System.Data.DataTable transferHistoryDataTable = new DataTable();
                transferHistoryDataAdapter.Fill(transferHistoryDataTable);

                // Bind the transfer history to the DataGridView control
                dataGridView2.DataSource = transferHistoryDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving transfer history: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
