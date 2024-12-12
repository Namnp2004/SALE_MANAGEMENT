namespace SaleManagementWinform
{
    partial class AddPurchaseHistory
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
            this.PurchaseID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_purchaseID = new System.Windows.Forms.TextBox();
            this.tbx_quantity = new System.Windows.Forms.TextBox();
            this.tbx_product = new System.Windows.Forms.TextBox();
            this.tbx_customerCode = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PurchaseID
            // 
            this.PurchaseID.AutoSize = true;
            this.PurchaseID.Location = new System.Drawing.Point(52, 75);
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.Size = new System.Drawing.Size(77, 16);
            this.PurchaseID.TabIndex = 0;
            this.PurchaseID.Text = "PurchaseID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Code";
           // this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // tbx_purchaseID
            // 
            this.tbx_purchaseID.Location = new System.Drawing.Point(236, 69);
            this.tbx_purchaseID.Name = "tbx_purchaseID";
            this.tbx_purchaseID.Size = new System.Drawing.Size(298, 22);
            this.tbx_purchaseID.TabIndex = 6;
            // 
            // tbx_quantity
            // 
            this.tbx_quantity.Location = new System.Drawing.Point(236, 277);
            this.tbx_quantity.Name = "tbx_quantity";
            this.tbx_quantity.Size = new System.Drawing.Size(298, 22);
            this.tbx_quantity.TabIndex = 7;
            // 
            // tbx_product
            // 
            this.tbx_product.Location = new System.Drawing.Point(236, 168);
            this.tbx_product.Name = "tbx_product";
            this.tbx_product.Size = new System.Drawing.Size(298, 22);
            this.tbx_product.TabIndex = 8;
            // 
            // tbx_customerCode
            // 
            this.tbx_customerCode.Location = new System.Drawing.Point(236, 122);
            this.tbx_customerCode.Name = "tbx_customerCode";
            this.tbx_customerCode.Size = new System.Drawing.Size(298, 22);
            this.tbx_customerCode.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 338);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(243, 429);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(133, 37);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(412, 429);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(133, 37);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 511);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbx_customerCode);
            this.Controls.Add(this.tbx_product);
            this.Controls.Add(this.tbx_quantity);
            this.Controls.Add(this.tbx_purchaseID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PurchaseID);
            this.Name = "AddPurchaseHistory";
            this.Text = "AddPurchaseHistory";
          //  this.Load += new System.EventHandler(this.AddPurchaseHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PurchaseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_purchaseID;
        private System.Windows.Forms.TextBox tbx_quantity;
        private System.Windows.Forms.TextBox tbx_product;
        private System.Windows.Forms.TextBox tbx_customerCode;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_cancel;
    }
}