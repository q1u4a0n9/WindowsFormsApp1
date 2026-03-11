using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string adminUsername = "admin";
            string adminPassword = "123456";

            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username == adminUsername && adminPassword == password)
            {
                MessageBox.Show("Login success!");
                Form f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login fasle, please try again!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
