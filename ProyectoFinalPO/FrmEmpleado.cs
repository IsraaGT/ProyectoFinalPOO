using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalPO
{
    public partial class FrmEmpleado : Form
    {
        private List<Reporte> reportes;

        public FrmEmpleado()
        {
            InitializeComponent();
            CargarReportes();
        }

        private void CargarReportes()
        {
            reportes = new List<Reporte>();

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Isra\Documents\ProyectoPO\reportes.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(new[] { ": " }, StringSplitOptions.None);
                        if (datos.Length == 2)
                        {
                            reportes.Add(new Reporte { Usuario = datos[0], Errores = datos[1] });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de reportes: " + ex.Message);
            }
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            lstReportes.Items.Clear();
            foreach (var reporte in reportes)
            {
                var item = new ListViewItem(new[] { reporte.Usuario, reporte.Errores });
                lstReportes.Items.Add(item);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstReportes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstReportes.SelectedItems[0];
                txtUsuario.Text = selectedItem.Text;
                txtErrores.Text = selectedItem.SubItems[1].Text;
            }
            else
            {
                MessageBox.Show("Seleccione un reporte para modificar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lstReportes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstReportes.SelectedItems[0];
                selectedItem.Text = txtUsuario.Text;
                selectedItem.SubItems[1].Text = txtErrores.Text;

                reportes.Clear();
                foreach (ListViewItem item in lstReportes.Items)
                {
                    reportes.Add(new Reporte { Usuario = item.Text, Errores = item.SubItems[1].Text });
                }

                try
                {
                    using (StreamWriter sw = new StreamWriter(@"C:\Users\Isra\Documents\ProyectoPO\reportes.txt", false))
                    {
                        foreach (var reporte in reportes)
                        {
                            sw.WriteLine($"{reporte.Usuario}: {reporte.Errores}");
                        }
                    }
                    MessageBox.Show("Reporte modificado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el reporte: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un reporte para guardar.");
            }
        }

        private void lstReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReportes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstReportes.SelectedItems[0];
                txtUsuario.Text = selectedItem.Text;
                txtErrores.Text = selectedItem.SubItems[1].Text;
            }
        }
    }

   
}
