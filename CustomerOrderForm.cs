using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class CustomerOrderForm : Form
    {
        Thread thread;

        public CustomerOrderForm()
        {
            InitializeComponent();
        }

        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {
            DisplayIncomingOrders();
            DisplayWarehouseStaff();
        }

        private void DisplayWarehouseStaff()
        {
            string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(conString);
            cnn.Open();
            String sql = "Select Staff_Id, Cust_Id, StaffName, Position from Warehouse_Staff";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewStaff.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }

            cnn.Close();
        }

        public void DisplayIncomingOrders()
        {
            string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(conString);
            cnn.Open();
            String sql = "Select IncomingOrders_Id, Inventory_Id, IncomingOrdersDate, ProductName, IncomingQuantity from IncomingOrders";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewIncomingOrders.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
            }

            cnn.Close();
        }
       

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openReportSupplierForm);
            thread.Start();
        }

        private void openReportSupplierForm()
        {
            Application.Run(new ReportsSupplierForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            const string message =
        "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                // cancel the closure of the form.
                this.Close();
            }
        }
    }
}
