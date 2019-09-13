namespace DatabaseConnection
{
    partial class CustomerOrderForm
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
            this.dataGridViewIncomingOrders = new System.Windows.Forms.DataGridView();
            this.Order_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIncomingOrders
            // 
            this.dataGridViewIncomingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomingOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_Id,
            this.Cust_Id,
            this.OrderDate,
            this.Price,
            this.Column1});
            this.dataGridViewIncomingOrders.Location = new System.Drawing.Point(29, 100);
            this.dataGridViewIncomingOrders.Name = "dataGridViewIncomingOrders";
            this.dataGridViewIncomingOrders.Size = new System.Drawing.Size(622, 180);
            this.dataGridViewIncomingOrders.TabIndex = 20;
            // 
            // Order_Id
            // 
            this.Order_Id.HeaderText = "IncomingOrders_Id";
            this.Order_Id.Name = "Order_Id";
            // 
            // Cust_Id
            // 
            this.Cust_Id.HeaderText = "Inventory_Id";
            this.Cust_Id.Name = "Cust_Id";
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.HeaderText = "IncomingOrdersDate";
            this.OrderDate.Name = "OrderDate";
            // 
            // Price
            // 
            this.Price.HeaderText = "ProductName";
            this.Price.Name = "Price";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IncomingQuantity";
            this.Column1.Name = "Column1";
            // 
            // btnMainPage
            // 
            this.btnMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPage.Location = new System.Drawing.Point(29, 22);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(67, 35);
            this.btnMainPage.TabIndex = 33;
            this.btnMainPage.Text = "Back";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Incoming Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Warehouse Staff";
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewStaff.Location = new System.Drawing.Point(29, 334);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.Size = new System.Drawing.Size(421, 171);
            this.dataGridViewStaff.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Staff_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cust_Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "StaffName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Position";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(565, 22);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 35);
            this.btnLogOut.TabIndex = 37;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 513);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMainPage);
            this.Controls.Add(this.dataGridViewIncomingOrders);
            this.Name = "CustomerOrderForm";
            this.Text = "CustomerOrderForm";
            this.Load += new System.EventHandler(this.CustomerOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewIncomingOrders;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnLogOut;
    }
}