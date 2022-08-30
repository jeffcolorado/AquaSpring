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

        private void openchildform(object childform)
        {
            if (this.panel_contenedor.Controls.Count > 0) this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = childform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
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
            openchildform(new users_form());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            openchildform(new clients_form());
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            openchildform(new process_form());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            openchildform(new calculate_form());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            openchildform(new print_form());
        }

        private void btnCopyright_Click(object sender, EventArgs e)
        {
            openchildform(new copyrigth_form());
        }
    }
}
