using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                string password = "phuongnam";

                //InsertData("bh00724", "Phuongnam", "CEO", 1, "phuongnam", Utils.HashPassword(password));
                Application.Run(new Form1());

            }
        }
        private static void InsertData(string code, string name, string position, int roleid, string username, string password)
        {
            // Connection string to your database

            // SQL query to insert data
            string query = "INSERT INTO Employee (code, name, position, username, password, active, roleid) VALUES (@code, @name, @position, @username, @password, 1,@roleid)";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@position", position);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@roleId", roleid);

                        command.Parameters.AddWithValue("@password", password);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        //MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
