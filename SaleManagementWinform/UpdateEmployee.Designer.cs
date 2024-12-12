namespace SaleManagementWinform
{
    partial class UpdateEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_position = new System.Windows.Forms.TextBox();
            this.rbt_customer = new System.Windows.Forms.RadioButton();
            this.rbt_sale = new System.Windows.Forms.RadioButton();
            this.rbt_warehouse = new System.Windows.Forms.RadioButton();
            this.rbt_admin = new System.Windows.Forms.RadioButton();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_code = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Role";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 31;
            this.button1.Text = "Save\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Position\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Full Name\r\n";
            // 
            // tbx_position
            // 
            this.tbx_position.Location = new System.Drawing.Point(114, 154);
            this.tbx_position.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_position.Multiline = true;
            this.tbx_position.Name = "tbx_position";
            this.tbx_position.Size = new System.Drawing.Size(261, 50);
            this.tbx_position.TabIndex = 25;
            // 
            // rbt_customer
            // 
            this.rbt_customer.AutoSize = true;
            this.rbt_customer.Location = new System.Drawing.Point(215, 271);
            this.rbt_customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_customer.Name = "rbt_customer";
            this.rbt_customer.Size = new System.Drawing.Size(69, 17);
            this.rbt_customer.TabIndex = 24;
            this.rbt_customer.TabStop = true;
            this.rbt_customer.Text = "Customer";
            this.rbt_customer.UseVisualStyleBackColor = true;
            // 
            // rbt_sale
            // 
            this.rbt_sale.AutoSize = true;
            this.rbt_sale.Location = new System.Drawing.Point(109, 271);
            this.rbt_sale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_sale.Name = "rbt_sale";
            this.rbt_sale.Size = new System.Drawing.Size(46, 17);
            this.rbt_sale.TabIndex = 23;
            this.rbt_sale.TabStop = true;
            this.rbt_sale.Text = "Sale";
            this.rbt_sale.UseVisualStyleBackColor = true;
            // 
            // rbt_warehouse
            // 
            this.rbt_warehouse.AutoSize = true;
            this.rbt_warehouse.Location = new System.Drawing.Point(215, 239);
            this.rbt_warehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_warehouse.Name = "rbt_warehouse";
            this.rbt_warehouse.Size = new System.Drawing.Size(82, 17);
            this.rbt_warehouse.TabIndex = 22;
            this.rbt_warehouse.TabStop = true;
            this.rbt_warehouse.Text = "WareHouse";
            this.rbt_warehouse.UseVisualStyleBackColor = true;
            // 
            // rbt_admin
            // 
            this.rbt_admin.AutoSize = true;
            this.rbt_admin.Location = new System.Drawing.Point(109, 239);
            this.rbt_admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_admin.Name = "rbt_admin";
            this.rbt_admin.Size = new System.Drawing.Size(54, 17);
            this.rbt_admin.TabIndex = 21;
            this.rbt_admin.TabStop = true;
            this.rbt_admin.Text = "Admin";
            this.rbt_admin.UseVisualStyleBackColor = true;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(114, 401);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_password.Multiline = true;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(261, 44);
            this.tbx_password.TabIndex = 20;
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(114, 336);
            this.tbx_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_username.Multiline = true;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(261, 44);
            this.tbx_username.TabIndex = 19;
            // 
            // tbx_code
            // 
            this.tbx_code.Location = new System.Drawing.Point(114, 83);
            this.tbx_code.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_code.Multiline = true;
            this.tbx_code.Name = "tbx_code";
            this.tbx_code.Size = new System.Drawing.Size(261, 44);
            this.tbx_code.TabIndex = 18;
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(114, 14);
            this.tbx_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_name.Multiline = true;
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(261, 44);
            this.tbx_name.TabIndex = 17;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(257, 470);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 40);
            this.btn_delete.TabIndex = 33;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 531);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_position);
            this.Controls.Add(this.rbt_customer);
            this.Controls.Add(this.rbt_sale);
            this.Controls.Add(this.rbt_warehouse);
            this.Controls.Add(this.rbt_admin);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.tbx_code);
            this.Controls.Add(this.tbx_name);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_position;
        private System.Windows.Forms.RadioButton rbt_customer;
        private System.Windows.Forms.RadioButton rbt_sale;
        private System.Windows.Forms.RadioButton rbt_warehouse;
        private System.Windows.Forms.RadioButton rbt_admin;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_code;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Button btn_delete;
    }
}