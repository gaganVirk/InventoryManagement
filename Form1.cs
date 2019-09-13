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
            this.Close();
            thread = new Thread(openCustomerForm);

            thread.Start();
        }

        private void openCustomerForm()
        {
            Application.Run(new CustomerDataForm());
        }
    }
}
