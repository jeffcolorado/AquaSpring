
namespace AquaSpring
{
    partial class AddUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label SearchPícBtn;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label DeletePicBtn;
            System.Windows.Forms.Label BtnCancelar;
            System.Windows.Forms.Label BtnAceptar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSetUsers = new AquaSpring.DataSetUsers();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new AquaSpring.DataSetUsersTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new AquaSpring.DataSetUsersTableAdapters.TableAdapterManager();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.PictureUpload = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IdTextBox = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            userIDLabel = new System.Windows.Forms.Label();
            SearchPícBtn = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            DeletePicBtn = new System.Windows.Forms.Label();
            BtnCancelar = new System.Windows.Forms.Label();
            BtnAceptar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUpload)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(180, 13);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 8;
            userIDLabel.Text = "User ID:";
            // 
            // SearchPícBtn
            // 
            SearchPícBtn.AutoSize = true;
            SearchPícBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            SearchPícBtn.Location = new System.Drawing.Point(49, 49);
            SearchPícBtn.Name = "SearchPícBtn";
            SearchPícBtn.Size = new System.Drawing.Size(40, 13);
            SearchPícBtn.TabIndex = 10;
            SearchPícBtn.Text = "Picture";
            SearchPícBtn.Click += new System.EventHandler(this.SearchPícBtn_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(194, 99);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 12;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(194, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(194, 122);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 16;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(194, 148);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 18;
            passwordLabel.Text = "Password:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(194, 174);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(32, 13);
            roleLabel.TabIndex = 20;
            roleLabel.Text = "Role:";
            // 
            // DeletePicBtn
            // 
            DeletePicBtn.AutoSize = true;
            DeletePicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            DeletePicBtn.Location = new System.Drawing.Point(104, 190);
            DeletePicBtn.Name = "DeletePicBtn";
            DeletePicBtn.Size = new System.Drawing.Size(43, 13);
            DeletePicBtn.TabIndex = 24;
            DeletePicBtn.Text = "Eliminar";
            DeletePicBtn.Click += new System.EventHandler(this.DeletePicBtn_Click);
            // 
            // BtnCancelar
            // 
            BtnCancelar.AutoSize = true;
            BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnCancelar.Location = new System.Drawing.Point(217, 246);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(49, 13);
            BtnCancelar.TabIndex = 25;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            BtnAceptar.AutoSize = true;
            BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnAceptar.Location = new System.Drawing.Point(116, 246);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new System.Drawing.Size(44, 13);
            BtnAceptar.TabIndex = 26;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 35);
            this.panel1.TabIndex = 7;
            // 
            // dataSetUsers
            // 
            this.dataSetUsers.DataSetName = "DataSetUsers";
            this.dataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dataSetUsers;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AquaSpring.DataSetUsersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Enabled = false;
            this.userIDTextBox.Location = new System.Drawing.Point(41, 10);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.userIDTextBox.TabIndex = 9;
            // 
            // PictureUpload
            // 
            this.PictureUpload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureUpload.Image = ((System.Drawing.Image)(resources.GetObject("PictureUpload.Image")));
            this.PictureUpload.Location = new System.Drawing.Point(52, 65);
            this.PictureUpload.Name = "PictureUpload";
            this.PictureUpload.Size = new System.Drawing.Size(95, 122);
            this.PictureUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUpload.TabIndex = 11;
            this.PictureUpload.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextBox.Location = new System.Drawing.Point(197, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(182, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(258, 119);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(121, 20);
            this.usernameTextBox.TabIndex = 17;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(258, 145);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 19;
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "FACTURADOR",
            "DIGITADOR"});
            this.roleComboBox.Location = new System.Drawing.Point(258, 171);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 21);
            this.roleComboBox.TabIndex = 21;
            this.roleComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roleComboBox_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.userIDTextBox);
            this.panel2.Controls.Add(userIDLabel);
            this.panel2.Location = new System.Drawing.Point(418, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 10);
            this.panel2.TabIndex = 22;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(258, 92);
            this.IdTextBox.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(120, 20);
            this.IdTextBox.TabIndex = 23;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Notificacion
            // 
            this.Notificacion.Text = "El registro se ha guardado exitosamente";
            this.Notificacion.Visible = true;
            // 
            // AddUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 292);
            this.Controls.Add(BtnAceptar);
            this.Controls.Add(BtnCancelar);
            this.Controls.Add(DeletePicBtn);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(SearchPícBtn);
            this.Controls.Add(this.PictureUpload);
            this.Controls.Add(iDLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Users";
            this.Load += new System.EventHandler(this.AddUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUpload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DataSetUsers dataSetUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSetUsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private DataSetUsersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.PictureBox PictureUpload;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown IdTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NotifyIcon Notificacion;
    }
}