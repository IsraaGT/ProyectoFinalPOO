using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalPO
{
    public partial class FrmCliente : Form
    {

        private string nombreUsuario;
        private CheckBox[] checkBoxes;

        public FrmCliente(string usuario)
        {
            InitializeComponent();
            this.Icon = new Icon(@"imagenes\iconoCliente.ico");

            nombreUsuario = usuario;

            checkBoxes = new CheckBox[]
            {
                chkError1, chkError2, chkError3, chkError4, chkError5,
                chkError6, chkError7, chkError8, chkError9, chkError10,
                chkError11, chkError12, chkError13, chkError14
            };
        }

        private void btnEnviarReporte_Click(object sender, EventArgs e)
        {
            List<string> erroresSeleccionados = new List<string>();

            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    erroresSeleccionados.Add(checkBox.Text);
                }
            }

            if (erroresSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un error.");
                return;
            }

            string reporte = nombreUsuario + ": " + string.Join(", ", erroresSeleccionados);

            try
            {
                using (StreamWriter sw = new StreamWriter(@"reportes.txt", true, Encoding.UTF8))
                {
                    sw.WriteLine(reporte);
                }
                MessageBox.Show("Reporte enviado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el reporte: " + ex.Message);
            }
        }

        private void btnCerrarSesionC_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
