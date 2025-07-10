using project.BrewByteDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adapter = new usersTableAdapter();
            var users = adapter.GetData();

            bool isValid = users.Any(u =>
                u.Username == tbUsername.Text.Trim() &&
                u.Password == tbPassword.Text);

            if (isValid)
            {
                AdminDashboard admin = new AdminDashboard();
                admin.FormClosed += (s, args) => this.Close(); // LoginForm will close once admin closes
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeForm form1 = new WelcomeForm();
            form1.Show();
            this.Hide();
        }
    }
}
