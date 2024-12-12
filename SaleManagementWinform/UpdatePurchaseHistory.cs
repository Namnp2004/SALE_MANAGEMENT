using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class UpdatePurchaseHistory : Form
    {
        string[] items = { "Cancel", "Pending", "Finish" };
        static int selectID = 0;

        public UpdatePurchaseHistory(int purchaseId, string customerCode, string productCode, DateTime purchaseDate, int quantity, int status, int active)
        {

            InitializeComponent();
            comboBox1.Items.AddRange(items);
           //s comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            tbx_PurchaseID.Text = purchaseId.ToString();
            tbx_CustomerCode.Text = customerCode.ToString();
            tbx_Product.Text = productCode.ToString();
           // dateTimePicker1.Value
            tbx_Quantity.Text = quantity.ToString();
            comboBox1.SelectedIndex = status;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex; // Gets the selected index
            if (selectedIndex != -1) // Check if an item is selected
            {
                MessageBox.Show($"Selected Index: {selectedIndex}");
                selectID = selectedIndex;
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }
        public void dgv_puchaseHistory_CellContentClick() { }

        private void UpdatePurcharHistoryInDatabase(int purchaseId, string customerCode, string productCode, DateTime purchaseDate, int quantity, int status, int active)
        {

            //purchaseID, customerCode, productCode, purchaseDate, quantity, status, active
            string query = "UPDATE PurchaseHistory SET purchaseID = @purchaseID, customerCode = @customerCode, " +
                "productCode = @productCode, purchaseDate = @purchaseDate, quantity = @quantity, status = @status, active = @active WHERE purchaseID = @purchaseID";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@purchaseID", purchaseId);
                        command.Parameters.AddWithValue("@customerCode", customerCode);
                        command.Parameters.AddWithValue("@productCode", productCode);
                        command.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@active", active);
                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("PurcharseHistory updated successfully.");

                        }
                        else
                        {
                            MessageBox.Show("No PurcharseHistory found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void DeletePurcharHistoryFromDatabase(int purchaseID)
        {
            string query = "UPDATE PurchaseHistory SET active = 0 WHERE purchaseID = @purchaseID";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@purchaseID", purchaseID);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("PurchaseHistory updated successfully.");

                        }
                        else
                        {
                            MessageBox.Show("No PurchaseHistory found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int purchaseId = int.Parse(tbx_PurchaseID.Text.ToString());
            string customerCode = tbx_CustomerCode.Text.ToString();
            string productCode = tbx_Product.Text.ToString();
            DateTime purchaseDate = dateTimePicker1.Value.Date;
            int quantity = int.Parse(tbx_Quantity.Text.ToString());
            UpdatePurcharHistoryInDatabase(purchaseId, customerCode, productCode, purchaseDate, quantity, selectID, 1);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int purchaseId = int.Parse(tbx_PurchaseID.Text.ToString());
            DeletePurcharHistoryFromDatabase(purchaseId);
        }
    }
}
