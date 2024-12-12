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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Optionally, set StartPosition to CenterScreen if you want centered loading
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadData();

        }
        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM Employee where active = 1";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
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
                    dgv_employee.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    //MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void dgv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show(); // Hiển thị màn hình Menu lên đầu  
            // Ẩn giao diện của màn hình hiện tại 
            this.Hide();
        }
        private void dgv_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_employee.Rows[e.RowIndex];

                // Retrieve data from each cell in the selected row
                var code = selectedRow.Cells["code"].Value.ToString();
                var fullname = selectedRow.Cells["name"].Value.ToString();
                var position = selectedRow.Cells["position"].Value.ToString();
                var username = selectedRow.Cells["username"].Value.ToString();
                var password = selectedRow.Cells["password"].Value.ToString();

                UpdateEmployee updateForm = new UpdateEmployee(code, fullname, position, username, password);
                updateForm.Show();

            }
        }
    }
}
