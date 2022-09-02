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
    public partial class AddUsersForm : Form
    {
        public AddUsersForm()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
    

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void AddUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetUsers.Users' Puede moverla o quitarla según sea necesario.
            this.usersTableAdapter.TodosRegistros(this.dataSetUsers.Users);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Users' Puede moverla o quitarla según sea necesario.


        }

        private void usersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetUsers);

        }

        private void roleComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SearchPícBtn_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Imagenes | *.jpg;*.jpeg;*.png;";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            else
            {
                this.PictureUpload.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void DeletePicBtn_Click(object sender, EventArgs e)
        {
            this.PictureUpload.Image = null;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (PictureUpload.Image == null)
            {
                MessageBox.Show("Agregue una foto", "Notificación");
            }
            else if(string.IsNullOrEmpty(this.nameTextBox.Text))
            {
                MessageBox.Show("Por favor escriba un nombre", "Notificación");
                this.nameTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(this.IdTextBox.Text))
            {
                MessageBox.Show("Por favor escriba un ID", "Notificación");
                this.IdTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(this.usernameTextBox.Text))
            {
                MessageBox.Show("Por favor escriba un Username", "Notificación");
                this.usernameTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(this.passwordTextBox.Text))
            {
                MessageBox.Show("Por favor escriba una contraseña", "Notificación");
                this.passwordTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(this.roleComboBox.Text))
            {
                MessageBox.Show("Por favor seleccione un rol", "Notificación");
                this.roleComboBox.Focus();
            }
            else
            {
                try
                {
                    this.passwordTextBox.Text = Globalmente.Encriptar(this.passwordTextBox.Text);
                    this.usersTableAdapter.InsertarUsuario(Globalmente.Convertir_Imagen_Bytes(this.PictureUpload.Image), this.IdTextBox.Text, this.nameTextBox.Text, this.usernameTextBox.Text, this.roleComboBox.Text, this.passwordTextBox.Text);
                    Notificacion.ShowBalloonTip(20000);
                    MessageBox.Show("Usuario creado con éxito.");
                }catch(Exception)
                {
                    MessageBox.Show("El registro no se puede guardar en la base de datos.");
                }
            }
        }
    }
}
