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
    public partial class ReportsSupplierForm : Form
    {
        Thread thread;
        public ReportsSupplierForm()
        {
            InitializeComponent();
        }

        private void ReportsSupplierForm_Load(object sender, EventArgs e)
        {
            DisplayReports();
            DisplaySupplier();
            DisplayInventory();
            DisplayCustomerOrders();
        }

        public void DisplayReports()
        {
            string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(conString);
            cnn.Open();
            String sql = "Select SR_Id, Staff_Id, Reports_Date from StaffReports";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewReports.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2));
            }
            cnn.Close();
        }

        public void DisplaySupplier()
        {
            string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(conString);
            cnn.Open();
            String sql = "Select Supplier_Id, IncomingOrders_Id, SupplierName from Supplier";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewSupplier.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2));
            }
            cnn.Close();
        }

        public void DisplayInventory()
        {
            string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(conString);
            cnn.Open();
            String sql = "Select Inventory_Id, OrdersToShip_Id, ProductName, TotalQuantity from CurrentInventory";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewInventory.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }
            cnn.Close();
        }

        public void DisplayCustomerOrders()
        {
            string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(conString);
            cnn.Open();
            String sql = "Select Order_Id, Cust_Id, OrderDate, TotalPrice from CustomerOrders";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //  string row = reader.GetValue(0) + " " + reader.GetValue(1);
                dataGridViewOrder.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }
            cnn.Close();
        }



        private void btnMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openDataForm);
            thread.Start();
        }

        private void openDataForm()
        {
            Application.Run(new CustomerDataForm());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openCustomerForm);
            thread.Start();
        }

        private void openCustomerForm()
        {
            Application.Run(new CustomerOrderForm());
        }
    }
}
