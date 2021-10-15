using System;
using System.Data;
using Npgsql;

public class ConnectionProvider
{
	static NpgsqlConnection sqlConnection = null;
	protected NpgsqlDataReader reader;

	public ConnectionProvider() { }

    public void ejecute(string query)
    {
        NpgsqlCommand command = new NpgsqlCommand(query, sqlConnection);

        try
        {
            command.ExecuteNonQuery();
        } catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public connect()
    {
        try
        {
            sqlConnection = new NpgsqlConnection(ConnectionConfig.getConnectionString());
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void finish()
    {
        sqlConnection.Close();
    }

    public NpgsqlConnection getSqlConnection()
    {
        return sqlConnection;
    }
}
