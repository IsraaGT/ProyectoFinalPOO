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
            SuspendLayout();
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.Location = new Point(12, 12);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Size = new Size(157, 66);
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
            lstUsuarios.Location = new Point(12, 100);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(600, 200);
            lstUsuarios.TabIndex = 2;
            lstUsuarios.UseCompatibleStateImageBehavior = false;
            lstUsuarios.View = View.Details;
            lstUsuarios.SelectedIndexChanged += lstUsuarios_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre de Usuario";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Contraseña";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tipo de Usuario";
            columnHeader3.Width = 200;
            // 
            // txbNuevoUsuario
            // 
            txbNuevoUsuario.Location = new Point(650, 100);
            txbNuevoUsuario.Name = "txbNuevoUsuario";
            txbNuevoUsuario.Size = new Size(150, 27);
            txbNuevoUsuario.TabIndex = 3;
            // 
            // txbNuevaContraseña
            // 
            txbNuevaContraseña.Location = new Point(650, 150);
            txbNuevaContraseña.Name = "txbNuevaContraseña";
            txbNuevaContraseña.Size = new Size(150, 27);
            txbNuevaContraseña.TabIndex = 4;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Admin", "Empleado", "Cliente" });
            cmbTipoUsuario.Location = new Point(650, 200);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(150, 28);
            cmbTipoUsuario.TabIndex = 5;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(650, 250);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(150, 29);
            btnAgregarUsuario.TabIndex = 6;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(650, 300);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(150, 29);
            btnEliminarUsuario.TabIndex = 7;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 361);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(txbNuevaContraseña);
            Controls.Add(txbNuevoUsuario);
            Controls.Add(lstUsuarios);
            Controls.Add(btnVerUsuarios);
            Name = "FrmAdmin";
            Text = "Administrar Usuarios";
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
    }
}
