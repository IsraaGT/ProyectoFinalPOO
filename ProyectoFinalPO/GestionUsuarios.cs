using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;  

public class GestionUsuarios
{
    private string rutaArchivo;

    public GestionUsuarios(string ruta)
    {
        rutaArchivo = ruta;
    }

    public List<Usuario> CargarUsuarios()
    {
        var usuarios = new List<Usuario>();

        try
        {
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(':');
                    if (datos.Length == 3)
                    {
                        string nombreUsuario = datos[0].Trim();
                        string contraseña = datos[1].Trim();
                        string tipoUsuario = datos[2].Trim();
                        usuarios.Add(new Usuario(nombreUsuario, contraseña, tipoUsuario));
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al leer el archivo de usuarios: {ex.Message}");
        }

        return usuarios;
    }

    public void GuardarUsuarios(List<Usuario> usuarios)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (var usuario in usuarios)
                {
                    sw.WriteLine($"{usuario.NombreUsuario}:{usuario.Contraseña}:{usuario.TipoUsuario}");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al guardar el archivo de usuarios: {ex.Message}");
        }
    }
}
