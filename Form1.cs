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
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();

            // Set to no text.
            textBoxPwd.Text = "";
            // The password character is an asterisk.
            textBoxPwd.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBoxPwd.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" && textBoxPwd.Text == "")
            {
                MessageBox.Show("Please fill in the blanks");
            }
            else
            {
                string conString = "Server=./;Database=InventoryManagement;Trusted_Connection=True;";

                SqlConnection cnn = new SqlConnection(conString);
                cnn.Open();
                String sql = "Select UserId, Username, Password from UserDetails Where Username=@UName and Password=@Pwd";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@UName", textBoxUser.Text);
                cmd.Parameters.AddWithValue("@Pwd", textBoxPwd.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                cnn.Close();

                int count = dataSet.Tables[0].Rows.Count;
                if(count == 1)
                {
                    MessageBox.Show("You have successfully Logged In");
                    this.Close();
                    thread = new Thread(openCustomerForm);

                    thread.Start();
                } else
                {
                    MessageBox.Show("Please check your Username & Password");
                }
            }
            
        }

        private void openCustomerForm()
        {
            Application.Run(new CustomerDataForm());
        }
    }
}
