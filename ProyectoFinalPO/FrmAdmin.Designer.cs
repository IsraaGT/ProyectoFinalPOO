namespace ProyectoFinalPO
{
    partial class FrmAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnVerUsuarios = new Button();
            lstUsuarios = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txbNuevoUsuario = new TextBox();
            txbNuevaContraseña = new TextBox();
            cmbTipoUsuario = new ComboBox();
            btnAgregarUsuario = new Button();
            btnEliminarUsuario = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnCerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerUsuarios.Location = new Point(50, 50);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Size = new Size(150, 50);
            btnVerUsuarios.TabIndex = 0;
            btnVerUsuarios.Text = "Ver Usuarios";
            btnVerUsuarios.UseVisualStyleBackColor = true;
            btnVerUsuarios.Click += btnVerUsuarios_Click;
            // 
            // lstUsuarios
            // 
            lstUsuarios.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lstUsuarios.FullRowSelect = true;
            lstUsuarios.GridLines = true;
            lstUsuarios.Location = new Point(50, 120);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(500, 200);
            lstUsuarios.TabIndex = 1;
            lstUsuarios.UseCompatibleStateImageBehavior = false;
            lstUsuarios.View = View.Details;
            lstUsuarios.SelectedIndexChanged += lstUsuarios_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre de Usuario";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Contraseña";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tipo de Usuario";
            columnHeader3.Width = 150;
            // 
            // txbNuevoUsuario
            // 
            txbNuevoUsuario.Location = new Point(613, 87);
            txbNuevoUsuario.Name = "txbNuevoUsuario";
            txbNuevoUsuario.Size = new Size(150, 34);
            txbNuevoUsuario.TabIndex = 2;
            // 
            // txbNuevaContraseña
            // 
            txbNuevaContraseña.Location = new Point(613, 137);
            txbNuevaContraseña.Name = "txbNuevaContraseña";
            txbNuevaContraseña.Size = new Size(150, 34);
            txbNuevaContraseña.TabIndex = 3;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Admin", "Empleado", "Cliente" });
            cmbTipoUsuario.Location = new Point(613, 187);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(150, 36);
            cmbTipoUsuario.TabIndex = 4;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarUsuario.Location = new Point(613, 237);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(150, 34);
            btnAgregarUsuario.TabIndex = 5;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarUsuario.Location = new Point(613, 287);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(150, 33);
            btnEliminarUsuario.TabIndex = 6;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 10);
            label1.Name = "label1";
            label1.Size = new Size(232, 31);
            label1.TabIndex = 7;
            label1.Text = "Administrar Usuarios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.see;
            pictureBox1.Location = new Point(11, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.add;
            pictureBox2.Location = new Point(572, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.delete;
            pictureBox3.Location = new Point(572, 287);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(613, 335);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(150, 33);
            btnCerrarSesion.TabIndex = 11;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(btnCerrarSesion);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(txbNuevaContraseña);
            Controls.Add(txbNuevoUsuario);
            Controls.Add(lstUsuarios);
            Controls.Add(btnVerUsuarios);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "FrmAdmin";
            Text = "FrmAdmin";
            Load += FrmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnVerUsuarios;
        private System.Windows.Forms.ListView lstUsuarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txbNuevoUsuario;
        private System.Windows.Forms.TextBox txbNuevaContraseña;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnCerrarSesion;
    }
}
