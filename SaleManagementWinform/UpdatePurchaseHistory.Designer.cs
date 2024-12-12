namespace SaleManagementWinform
{
    partial class UpdatePurchaseHistory
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbx_CustomerCode = new System.Windows.Forms.TextBox();
            this.tbx_Product = new System.Windows.Forms.TextBox();
            this.tbx_Quantity = new System.Windows.Forms.TextBox();
            this.tbx_PurchaseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PurchaseID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(444, 424);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 37);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(275, 424);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(133, 37);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 333);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 219);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // tbx_CustomerCode
            // 
            this.tbx_CustomerCode.Location = new System.Drawing.Point(268, 117);
            this.tbx_CustomerCode.Name = "tbx_CustomerCode";
            this.tbx_CustomerCode.Size = new System.Drawing.Size(298, 22);
            this.tbx_CustomerCode.TabIndex = 23;
            // 
            // tbx_Product
            // 
            this.tbx_Product.Location = new System.Drawing.Point(268, 163);
            this.tbx_Product.Name = "tbx_Product";
            this.tbx_Product.Size = new System.Drawing.Size(298, 22);
            this.tbx_Product.TabIndex = 22;
            // 
            // tbx_Quantity
            // 
            this.tbx_Quantity.Location = new System.Drawing.Point(268, 272);
            this.tbx_Quantity.Name = "tbx_Quantity";
            this.tbx_Quantity.Size = new System.Drawing.Size(298, 22);
            this.tbx_Quantity.TabIndex = 21;
            // 
            // tbx_PurchaseID
            // 
            this.tbx_PurchaseID.Location = new System.Drawing.Point(268, 64);
            this.tbx_PurchaseID.Name = "tbx_PurchaseID";
            this.tbx_PurchaseID.Size = new System.Drawing.Size(298, 22);
            this.tbx_PurchaseID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Purchase Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer Code";
            // 
            // PurchaseID
            // 
            this.PurchaseID.AutoSize = true;
            this.PurchaseID.Location = new System.Drawing.Point(84, 70);
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.Size = new System.Drawing.Size(77, 16);
            this.PurchaseID.TabIndex = 14;
            this.PurchaseID.Text = "PurchaseID";
            // 
            // UpdatePurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 510);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbx_CustomerCode);
            this.Controls.Add(this.tbx_Product);
            this.Controls.Add(this.tbx_Quantity);
            this.Controls.Add(this.tbx_PurchaseID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PurchaseID);
            this.Name = "UpdatePurchaseHistory";
            this.Text = "UpdatePurchaseHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbx_CustomerCode;
        private System.Windows.Forms.TextBox tbx_Product;
        private System.Windows.Forms.TextBox tbx_Quantity;
        private System.Windows.Forms.TextBox tbx_PurchaseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PurchaseID;
    }
}