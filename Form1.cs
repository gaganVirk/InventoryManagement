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

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(conString);
            cnn.Open();
            String sql = "Select Cust_Id, CustName, CustAddress, City, Phone, Email from Customer";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
              //  string row = reader.GetValue(0) + " " + reader.GetValue(1);
                dataGridView.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3),
                    reader.GetValue(4), reader.GetValue(5));
            }

            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
    }
}
