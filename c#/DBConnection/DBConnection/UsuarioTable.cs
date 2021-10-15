using Npgsql;
using System.Data;

class UsuarioTable : ConnectionProvider, UsuarioInterface
{
    public Usuario usuario;
    NpgsqlCommand command;

    public UsuarioTable(): base(){ }

    public bool getPrimero(string sp)
    {
        command = new NpgsqlCommand(sp, getSqlConnection());
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
            result["nombre"].ToString(),
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