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
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lstReportes = new System.Windows.Forms.ListView();
            this.columnHeaderUsuario = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderErrores = new System.Windows.Forms.ColumnHeader();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtErrores = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Location = new System.Drawing.Point(34, 25);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(173, 75);
            this.btnVerReportes.TabIndex = 0;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(314, 25);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(173, 75);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lstReportes
            // 
            this.lstReportes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUsuario,
            this.columnHeaderErrores});
            this.lstReportes.FullRowSelect = true;
            this.lstReportes.GridLines = true;
            this.lstReportes.Location = new System.Drawing.Point(12, 120);
            this.lstReportes.Name = "lstReportes";
            this.lstReportes.Size = new System.Drawing.Size(600, 200);
            this.lstReportes.TabIndex = 2;
            this.lstReportes.UseCompatibleStateImageBehavior = false;
            this.lstReportes.View = System.Windows.Forms.View.Details;
            this.lstReportes.SelectedIndexChanged += new System.EventHandler(this.lstReportes_SelectedIndexChanged);
            // 
            // columnHeaderUsuario
            // 
            this.columnHeaderUsuario.Text = "Usuario";
            this.columnHeaderUsuario.Width = 150;
            // 
            // columnHeaderErrores
            // 
            this.columnHeaderErrores.Text = "Errores";
            this.columnHeaderErrores.Width = 450;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(650, 120);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(150, 27);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtErrores
            // 
            this.txtErrores.Location = new System.Drawing.Point(650, 170);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.Size = new System.Drawing.Size(150, 27);
            this.txtErrores.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(650, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 29);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 361);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtErrores);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lstReportes);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVerReportes);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ListView lstReportes;
        private System.Windows.Forms.ColumnHeader columnHeaderUsuario;
        private System.Windows.Forms.ColumnHeader columnHeaderErrores;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtErrores;
        private System.Windows.Forms.Button btnGuardar;
    }
}
