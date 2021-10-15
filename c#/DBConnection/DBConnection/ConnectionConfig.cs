class ConnectionConfig
{
    private string dbserv;

    private static ConnectionConfig instance = null;

    private ConnectionConfig()
    {
        string server = "localhost";
        string user = "postgres";
        string password = "admin";
        string database = "user";
        dbserv = "Server = "+ server
            +"; User Id = "+ user
            +"; Password = "+ password
            +"; Database = "+ database
            +";";
    }

    private static void createInstance()
    {
        if (instance == null) instance = new ConnectionConfig();
    }

    public static ConnectionConfig getInstance()
    {
        if (instance == null) createInstance();
        return instance;
    }

    public static string getConnectionString()
    {
        createInstance();
        return instance.dbserv;
    }

}

