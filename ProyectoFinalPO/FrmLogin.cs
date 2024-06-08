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
            this.Icon = new Icon(@"imagenes\iconoLogin.ico");
            gestionUsuarios = new GestionUsuarios("usuarios.txt");
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
                switch (usuario.TipoUsuario)
                {
                    case "Empleado":
                        FrmEmpleado frmEmpleado = new FrmEmpleado();
                        this.Hide();
                        frmEmpleado.Show();
                        break;
                    case "Cliente":
                        FrmCliente frmCliente = new FrmCliente(usuario.NombreUsuario);
                        this.Hide();
                        frmCliente.Show();
                        break;
                    case "Admin":
                        FrmAdmin frmAdmin = new FrmAdmin(gestionUsuarios);
                        this.Hide();
                        frmAdmin.Show();
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario no reconocido.");
                        break;
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
