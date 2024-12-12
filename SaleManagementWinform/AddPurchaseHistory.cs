using DocumentFormat.OpenXml.Spreadsheet;
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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace SaleManagementWinform
{
    public partial class AddPurchaseHistory : Form
    {
        string[] items = { "Cancel", "Pending", "Finish" };
        static int selectID = 0;



        //public AddPurchaseHistory()
        //{
        //    InitializeComponent();
        //    this.StartPosition = FormStartPosition.CenterScreen;


        //    // Disable the maximize/restore button
        //    this.MaximizeBox = false;

        //    // Optional: Set a fixed border style to prevent resizing
        //    this.FormBorderStyle = FormBorderStyle.FixedSingle;
        //    comboBox1.Items.AddRange(items);
        //}

        public AddPurchaseHistory()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(items);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int purchaseId = int.Parse(tbx_purchaseID.Text.ToString()); 
            string customerCode = tbx_customerCode.Text.ToString();
            string productCode = tbx_product.Text.ToString();
            DateTime purchaseDate = dateTimePicker1.Value.Date;
            int quantity = int.Parse(tbx_quantity.Text.ToString());
            //string status = comboBox1.SelectedItem.ToString();

            InsertDataToPurchaseHistory(purchaseId, customerCode, productCode, purchaseDate, quantity, selectID, 1);
            // Lưu vào cơ sở dữ liệu (DB logic here)
            MessageBox.Show("Purchase history added successfully!");
            this.Close();
        }

        private void InsertDataToPurchaseHistory(int purchaseId, string customerCode, string productCode, DateTime purchaseDate, int quantity, int status, int active)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "Server=VICTUS\\SQLEXPRESS;Database=SALE_MANGEMENT;Trusted_Connection=True;";  // Thay thế bằng chuỗi kết nối của bạn

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO PurchaseHistory (purchaseID, customerCode, productCode, purchaseDate, quantity, status, active) " +
                             "VALUES (@PurchaseID, @CustomerCode, @ProductCode, @PurchaseDate, @Quantity, @Status, @Active)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    Console.WriteLine("2342342343");
                   

                    // Thêm tham số và kiểm tra kiểu dữ liệu
                    cmd.Parameters.AddWithValue("@PurchaseID", purchaseId);
                    cmd.Parameters.AddWithValue("@CustomerCode", customerCode);
                    cmd.Parameters.AddWithValue("@ProductCode", productCode);
                    cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Active", active);

                    Console.WriteLine(status);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"SQL Error: {sqlEx.Message}", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
