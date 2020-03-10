using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.user = Convert.ToString(username.Text);
            login.pass = Convert.ToString(password.Text);

            string pass = login.pass;
            if(string.Compare(pass,"pbo123") == 0)
            {
                FormHome f2 = new FormHome();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password yang anda masukan salah");
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
