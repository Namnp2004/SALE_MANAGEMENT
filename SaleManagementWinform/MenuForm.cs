using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Disable the maximize/restore button
            this.MaximizeBox = false;
            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Utils.roleID == 1)
            {
                button1.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            } else if(Utils.roleID == 2)
            {
                button1.Visible = true;
                button2.Visible = true;
                button4.Visible = false;
                button5.Visible = false;
            } else if(Utils.roleID == 3)
            {
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = true;
                button5.Visible = false;
            } else if (Utils.roleID == 4)
            {
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            MainForm main = new MainForm();
            main.Show();
            this.Hide();


        }
        private void button4_Click(object sender, EventArgs e)
        {

            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PuchaseHistory purchaseHistoryForm = new PuchaseHistory();
            purchaseHistoryForm.Show();
            this.Hide();
        }
    }
}
