using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using MySql.Data.MySqlClient;

namespace OneScreenMySQLClient
{
    public partial class MainForm : Form
    {
        private MySqlConnection conn;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                // connection
                string hostname = HostnameTextbox.Text;
                string port = PortTextbox.Text;
                string username = UsernameTextbox.Text;
                string password = PasswordTextbox.Text;
                string database_name = DatabaseNameTextbox.Text;
                string charset = "utf8";

                string connectionString = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};Charset={5}", hostname, port, database_name, username, password, charset);
                conn = new MySqlConnection(connectionString);

                // open connection
                conn.Open();

                // get databases
                using (var connection = new MySqlConnection(connectionString))
                using (var command = new MySqlCommand())
                {

                    connection.Open();
                    MessageBox.Show("Successfully made the MySQL connection.");

                    command.Connection = connection;
                    command.CommandText = "SHOW DATABASES;";
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var name = reader.GetString(0);
                            Debug.WriteLine(name);
                            DatabaseComboBox.DataSource = name;
                        }
                    }
                }









                // mysql actions below:
                // table gets data
                DataTable tbl = new DataTable();
                ComboBox cmb = new ComboBox();

                // execute query
                MySqlDataAdapter dataAdp = new MySqlDataAdapter("SHOW databases", conn);
                // dataAdp.Fill(tbl);
                dataAdp.Fill(tbl);
                
                

                // display gridview
                // MainDataGridView.DataSource = tbl;

                // close connection
                conn.Close();
            }
            catch (MySqlException mse)
            {
                // mysql exception
                MessageBox.Show("MySQL Exception: " + mse.Message);
            }
            catch (AggregateException ae)
            {
                // application exception
                MessageBox.Show("Application Exception: " + ae.Message);
            }
        }

        private void ExecuteQueryButton_Click(object sender, EventArgs e)
        {
            string query = QueryTextbox.Text;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlTransaction trans = null;

            try
            {
                cmd.Connection.Open();

                trans = cmd.Connection.BeginTransaction(IsolationLevel.ReadCommitted);

                cmd.ExecuteNonQuery();

                trans.Commit();

                MessageBox.Show("Success!");

            } catch (MySqlException mse)
            {
                trans.Rollback();
                MessageBox.Show(mse.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
