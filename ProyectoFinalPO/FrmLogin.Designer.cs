﻿namespace ProyectoFinalPO
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInicioSesion = new Label();
            txbUsuario = new TextBox();
            txbContaseña = new TextBox();
            btnInicioSesion = new Button();
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblBienvenida = new Label();
            btnCancelarLogin = new Button();
            SuspendLayout();
            // 
            // txtInicioSesion
            // 
            txtInicioSesion.AutoSize = true;
            txtInicioSesion.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtInicioSesion.ForeColor = Color.FromArgb(34, 45, 50);
            txtInicioSesion.Location = new Point(287, 60);
            txtInicioSesion.Name = "txtInicioSesion";
            txtInicioSesion.Size = new Size(275, 41);
            txtInicioSesion.TabIndex = 0;
            txtInicioSesion.Text = "INICIO DE SESIÓN";
            // 
            // txbUsuario
            // 
            txbUsuario.BorderStyle = BorderStyle.FixedSingle;
            txbUsuario.Font = new Font("Segoe UI", 12F);
            txbUsuario.Location = new Point(283, 140);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(200, 34);
            txbUsuario.TabIndex = 1;
            // 
            // txbContaseña
            // 
            txbContaseña.BorderStyle = BorderStyle.FixedSingle;
            txbContaseña.Font = new Font("Segoe UI", 12F);
            txbContaseña.Location = new Point(283, 214);
            txbContaseña.Name = "txbContaseña";
            txbContaseña.Size = new Size(200, 34);
            txbContaseña.TabIndex = 2;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = Color.FromArgb(34, 45, 50);
            btnInicioSesion.FlatAppearance.BorderSize = 0;
            btnInicioSesion.FlatStyle = FlatStyle.Flat;
            btnInicioSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInicioSesion.ForeColor = Color.White;
            btnInicioSesion.Location = new Point(242, 293);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(130, 35);
            btnInicioSesion.TabIndex = 3;
            btnInicioSesion.Text = "Ingresar";
            btnInicioSesion.UseVisualStyleBackColor = false;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14F);
            lblUsuario.ForeColor = Color.FromArgb(34, 45, 50);
            lblUsuario.Location = new Point(287, 105);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(94, 32);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 14F);
            lblContraseña.ForeColor = Color.FromArgb(34, 45, 50);
            lblContraseña.Location = new Point(287, 181);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(134, 32);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 14F);
            lblBienvenida.ForeColor = Color.FromArgb(34, 45, 50);
            lblBienvenida.Location = new Point(287, 20);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(261, 32);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido a MasterPC";
            // 
            // btnCancelarLogin
            // 
            btnCancelarLogin.BackColor = Color.FromArgb(34, 45, 50);
            btnCancelarLogin.FlatAppearance.BorderSize = 0;
            btnCancelarLogin.FlatStyle = FlatStyle.Flat;
            btnCancelarLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelarLogin.ForeColor = Color.White;
            btnCancelarLogin.Location = new Point(418, 293);
            btnCancelarLogin.Name = "btnCancelarLogin";
            btnCancelarLogin.Size = new Size(130, 35);
            btnCancelarLogin.TabIndex = 6;
            btnCancelarLogin.Text = "Cancelar";
            btnCancelarLogin.UseVisualStyleBackColor = false;
            btnCancelarLogin.Click += btnCancelarLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarLogin);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(btnInicioSesion);
            Controls.Add(txbContaseña);
            Controls.Add(txbUsuario);
            Controls.Add(txtInicioSesion);
            Controls.Add(lblBienvenida);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtInicioSesion;
        private Label lblBienvenida;
        private TextBox txbUsuario;
        private TextBox txbContaseña;
        private Button btnInicioSesion;
        private Label lblUsuario;
        private Label lblContraseña;
        private Button btnCancelarLogin;
    }
}
