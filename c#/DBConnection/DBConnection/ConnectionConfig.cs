using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConnectionConfig
{
    private string dbserv;

    private static ConnectionConfig instance = null;

    private ConnectionConfig()
    {
        
        dbserv = "D:\\OldProyects\\poo3\\c#\\DBConnection\\users.db";
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
        return "Data Source="+ instance.dbserv;
    }

}

