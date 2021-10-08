using System.Data;
using System.Data.SqlClient;

class UsuarioTable : ConnectionProvider, UsuarioInterface
{
    public Usuario usuario;
    SqlCommand command;

    public UsuarioTable(): base(){ }

    public bool getPrimero(string sp)
    {
        command = new SqlCommand(sp, getSqlConnection());
        reader = command.ExecuteReader();
        return getSiguiente();
    }

    public bool getSiguiente()
    {
        if (reader.Read())
        {
            IDataRecord result;
            result = (IDataRecord)reader;
            usuario = toUsuario(result);
            return true;
        }
        return false;
    }

    private Usuario toUsuario(IDataRecord result)
    {
        return new Usuario(
            Int32.Parse(result["id"].ToString()),
            result["name"].ToString(),
            result["password"].ToString()
        );
    }

    public bool getFinal()
    {
        reader.Close();
        return true;
    }

    public Usuario getUsuario()
    {
        return usuario;
    }
}