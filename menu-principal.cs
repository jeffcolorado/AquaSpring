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
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        bool val = false;

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm=null;
        private void openchildform(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(childform);
            panel_contenedor.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            val = true;
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (val == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            val = false;
        }

        private void BtnMaximizarMinimizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            openchildform(new UsersForm());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            openchildform(new ClientsForm());
        }

    }
}
