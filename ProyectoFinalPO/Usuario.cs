public class Usuario
{
    public string NombreUsuario { get; set; }
    public string Contraseña { get; set; }
    public string TipoUsuario { get; set; } // "Admin", "Empleado", "Cliente"

    public Usuario(string nombreUsuario, string contraseña, string tipoUsuario)
    {
        NombreUsuario = nombreUsuario;
        Contraseña = contraseña;
        TipoUsuario = tipoUsuario;
    }

    public bool VerificarContraseña(string contraseña)
    {
        return Contraseña == contraseña;
    }
}
