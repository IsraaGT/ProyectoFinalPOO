using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinalPO
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuarios;
        private GestionUsuarios gestionUsuarios;

        public FrmLogin()
        {
            InitializeComponent();
            gestionUsuarios = new GestionUsuarios(@"C:\Users\Isra\Documents\ProyectoPO\usuarios.txt");
            usuarios = gestionUsuarios.CargarUsuarios();
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            txbUsuario.Clear();
            txbContaseña.Clear();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = VerificarUsuario(txbUsuario.Text, txbContaseña.Text);
            if (usuario != null)
            {
                if (usuario.TipoUsuario == "Empleado")
                {
                    FrmEmpleado frmEmpleado = new FrmEmpleado();
                    this.Hide();
                    frmEmpleado.Show();
                }
                else if (usuario.TipoUsuario == "Cliente")
                {
                    FrmCliente frmCliente = new FrmCliente(usuario.NombreUsuario); // Pasa el nombre de usuario
                    this.Hide();
                    frmCliente.Show();
                }
                else if (usuario.TipoUsuario == "Admin")
                {
                    FrmAdmin frmAdmin = new FrmAdmin(gestionUsuarios); // Aquí pasas la instancia de GestionUsuarios
                    this.Hide();
                    frmAdmin.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private Usuario VerificarUsuario(string nombreUsuario, string contraseña)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario && usuario.VerificarContraseña(contraseña))
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}
