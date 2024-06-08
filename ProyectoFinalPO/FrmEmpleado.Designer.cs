namespace ProyectoFinalPO
{
    partial class FrmEmpleado
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
            btnVerReportes = new Button();
            btnModificar = new Button();
            lstReportes = new ListView();
            columnHeaderUsuario = new ColumnHeader();
            columnHeaderErrores = new ColumnHeader();
            txtUsuario = new TextBox();
            txtErrores = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnVerReportes
            // 
            btnVerReportes.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerReportes.Location = new Point(50, 50);
            btnVerReportes.Name = "btnVerReportes";
            btnVerReportes.Size = new Size(150, 50);
            btnVerReportes.TabIndex = 0;
            btnVerReportes.Text = "Ver Reportes";
            btnVerReportes.UseVisualStyleBackColor = true;
            btnVerReportes.Click += btnVerReportes_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(250, 50);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 50);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lstReportes
            // 
            lstReportes.Columns.AddRange(new ColumnHeader[] { columnHeaderUsuario, columnHeaderErrores });
            lstReportes.FullRowSelect = true;
            lstReportes.GridLines = true;
            lstReportes.Location = new Point(12, 120);
            lstReportes.Name = "lstReportes";
            lstReportes.Size = new Size(544, 241);
            lstReportes.TabIndex = 2;
            lstReportes.UseCompatibleStateImageBehavior = false;
            lstReportes.View = View.Details;
            lstReportes.SelectedIndexChanged += lstReportes_SelectedIndexChanged;
            // 
            // columnHeaderUsuario
            // 
            columnHeaderUsuario.Text = "Usuario";
            columnHeaderUsuario.Width = 150;
            // 
            // columnHeaderErrores
            // 
            columnHeaderErrores.Text = "Errores";
            columnHeaderErrores.Width = 350;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(600, 120);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 34);
            txtUsuario.TabIndex = 3;
            // 
            // txtErrores
            // 
            txtErrores.Location = new Point(600, 170);
            txtErrores.Name = "txtErrores";
            txtErrores.Size = new Size(150, 34);
            txtErrores.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(600, 220);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 30);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 10);
            label1.Name = "label1";
            label1.Size = new Size(260, 31);
            label1.TabIndex = 6;
            label1.Text = "Gestión de los Reportes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.save;
            pictureBox1.Location = new Point(562, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.see;
            pictureBox2.Location = new Point(12, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(600, 272);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(150, 30);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(btnCerrarSesion);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtErrores);
            Controls.Add(txtUsuario);
            Controls.Add(lstReportes);
            Controls.Add(btnModificar);
            Controls.Add(btnVerReportes);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "FrmEmpleado";
            Text = "FrmEmpleado";
            Load += FrmEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerReportes;
        private Button btnModificar;
        private ListView lstReportes;
        private ColumnHeader columnHeaderUsuario;
        private ColumnHeader columnHeaderErrores;
        private TextBox txtUsuario;
        private TextBox txtErrores;
        private Button btnGuardar;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnCerrarSesion;
    }
}
