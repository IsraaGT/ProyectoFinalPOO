using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinalPO
{
    public partial class FrmAdmin : Form
    {
        private GestionUsuarios gestionUsuarios;
        private List<Usuario> usuarios;

        public FrmAdmin(GestionUsuarios gestion)
        {
            InitializeComponent();
            this.Icon = new Icon(@"imagenes\iconoAdmin.ico");
            gestionUsuarios = gestion;
            usuarios = gestionUsuarios.CargarUsuarios();
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            lstUsuarios.Items.Clear();
            foreach (var usuario in usuarios)
            {
                var item = new ListViewItem(new[] { usuario.NombreUsuario, usuario.Contraseña, usuario.TipoUsuario });
                lstUsuarios.Items.Add(item);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txbNuevoUsuario.Visible = true;
            txbNuevaContraseña.Visible = true;
            cmbTipoUsuario.Visible = true;
            btnAgregarUsuario.Visible = true;
            btnEliminarUsuario.Visible = true;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txbNuevoUsuario.Text;
            string contraseña = txbNuevaContraseña.Text;
            string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(nombreUsuario) && !string.IsNullOrEmpty(contraseña) && !string.IsNullOrEmpty(tipoUsuario))
            {
                Usuario nuevoUsuario = new Usuario(nombreUsuario, contraseña, tipoUsuario);
                usuarios.Add(nuevoUsuario);
                gestionUsuarios.GuardarUsuarios(usuarios);
                MessageBox.Show("Usuario agregado correctamente.");
                txbNuevoUsuario.Clear();
                txbNuevaContraseña.Clear();
                cmbTipoUsuario.SelectedIndex = -1;
                btnVerUsuarios_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItems.Count > 0)
            {
                string usuarioSeleccionado = lstUsuarios.SelectedItems[0].Text;
                Usuario usuarioAEliminar = usuarios.Find(u => u.NombreUsuario == usuarioSeleccionado);
                if (usuarioAEliminar != null)
                {
                    usuarios.Remove(usuarioAEliminar);
                    gestionUsuarios.GuardarUsuarios(usuarios);
                    MessageBox.Show("Usuario eliminado correctamente.");
                    btnVerUsuarios_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
