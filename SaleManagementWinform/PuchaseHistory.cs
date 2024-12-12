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
    public partial class PuchaseHistory : Form
    {
        public static string SQLConnection
          = "Server=VICTUS\\SQLEXPRESS;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public PuchaseHistory()
        {
            InitializeComponent();
        }
        private void PuchaseHistory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Optionally, set StartPosition to CenterScreen if you want centered loading
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_puchaseHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadData();
            //dgv_puchaseHistory.CellClick += dgv_puchaseHistory_CellClick;
        }
        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM PurchaseHistory where active = 1";

            using (SqlConnection connection = new SqlConnection(SQLConnection))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with query results
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dgv_puchaseHistory.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             AddPurchaseHistory addCustomer = new AddPurchaseHistory();
             addCustomer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void dgv_puchaseHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã nhấp vào dòng hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu đã chọn
                DataGridViewRow selectedRow = dgv_puchaseHistory.Rows[e.RowIndex];

                // Lấy thông tin từ các ô trong dòng đã chọn
                int purchaseId = int.Parse(selectedRow.Cells["PurchaseID"].Value.ToString());
                string customerCode = selectedRow.Cells["CustomerCode"].Value.ToString();
                string productCode = selectedRow.Cells["ProductCode"].Value.ToString();
                DateTime purchaseDate = Convert.ToDateTime(selectedRow.Cells["PurchaseDate"].Value);
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                int status = Convert.ToInt32(selectedRow.Cells["Status"].Value.ToString());


                UpdatePurchaseHistory purchaseHistory = new UpdatePurchaseHistory(purchaseId, customerCode, productCode,
                    purchaseDate, quantity, status, 1);
                purchaseHistory.Show();

                // Hiển thị thông tin trong các hộp thoại hoặc xử lý theo cách bạn muốn
                //MessageBox.Show($"Purchase ID: {purchaseId}\n" +
                //                $"Customer Code: {customerCode}\n" +
                //                $"Product Code: {productCode}\n" +
                //                $"Purchase Date: {purchaseDate.ToShortDateString()}\n" +
                //                $"Quantity: {quantity}\n" +
                //                $"Status: {status}",
                //                "Purchase Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_puchaseHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("aaaaaaaaaaaaaaaa");
        }
    }
}


