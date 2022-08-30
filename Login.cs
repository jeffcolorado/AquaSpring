using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaSpring
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form menuprincipal = new menu_principal();
            menuprincipal.Show();
            this.Hide();
        }

        private void textUsername_Enter(object sender, EventArgs e)
        {
            if (this.textUsername.Text == "Username")
            {
                this.textUsername.Text = string.Empty;
                this.textUsername.ForeColor = Color.Black;
            }
        }

        private void textUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textUsername.Text))
            {
                this.textUsername.Text = "Username";
                this.textUsername.ForeColor = Color.Black;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (this.textPassword.Text == "Password")
            {
                this.textPassword.Text = string.Empty;
                this.textPassword.ForeColor = Color.Black;
                this.textPassword.isPassword = true;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textPassword.Text))
            {
                this.textPassword.Text = "Password";
                this.textPassword.ForeColor = Color.Black;
                this.textPassword.isPassword = false;
            }
        }
    }
}
