using System;
using System.Data;
using System.Data.SqlClient;

public class ConnectionProvider
{
	static SqlConnection sqlConnection = null;
	protected SqlDataReader reader;

	public ConnectionProvider()
	{
        if (sqlConnection == null)
        {
            try
            {
                sqlConnection = new SqlConnection(ConnectionConfig.getConnectionString());
                if (sqlConnection.State != ConnectionState.Open)
                {
                    Console.WriteLine("opening");
                    sqlConnection.Open();
                    Console.WriteLine("opened");
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
	}

    public void ejecute(string query)
    {
        SqlCommand command = new SqlCommand(query, sqlConnection);

        try
        {
            command.ExecuteNonQuery();
        } catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void finish()
    {
        sqlConnection.Close();
    }

    public SqlConnection getSqlConnection()
    {
        return sqlConnection;
    }
}
