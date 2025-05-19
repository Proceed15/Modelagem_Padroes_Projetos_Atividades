public class Login
{
    private List<Usuario> usuarios;

    public Login()
    {
        usuarios = new List<Usuario>();
    }
    public void addUsuario(Usuario u)
    {
        usuarios.Add(u);
    }
    public Usuario localizarUsuario(long matricula)
    {
        foreach (var usuario in usuarios)
        {
            if (usuario.Matricula == matricula)
            {
                return usuario;
            }
        }
        return null;
    }
}