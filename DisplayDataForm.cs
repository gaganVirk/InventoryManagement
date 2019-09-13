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
    public partial class CustomerDataForm : Form
    {
        Thread thread;
        public CustomerDataForm()
        {
            InitializeComponent();

        }

        private void DisplayDataForm_Load(object sender, EventArgs e)
        {
            DisplayCustomerData();
            DisplayOrderToShip();
        }
        

        public void DisplayCustomerData()
        {
            string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(conString);
            cnn.Open();
            String sql = "Select Cust_Id, CustName, CustAddress, City, Phone, Email from Customer";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //  string row = reader.GetValue(0) + " " + reader.GetValue(1);
                dataGridView.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3),
                    reader.GetValue(4), reader.GetValue(5));
            }
            cnn.Close();
        }

        public void DisplayOrderToShip()
        {
            string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(conString);
            cnn.Open();
            String sql = "Select OrdersToShip_Id, Order_Id, ShippingDate, PurchasedQuantity, ShippingDate from OrdersToShip";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewDeliver.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
            }
            cnn.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openNewForm);
            thread.Start();
        }

        private void openNewForm()
        {
            Application.Run(new ReportsSupplierForm());
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openFormOne);
            thread.Start();
        }

        private void openFormOne()
        {
            Application.Run(new Form1());
        }
    }
}
