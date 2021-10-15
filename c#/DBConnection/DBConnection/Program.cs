try
{
    UsuarioTable usuarioT = new UsuarioTable();
    bool sigo = usuarioT.getPrimero("SELECT * FROM \"user\"");
    while (sigo)
    {
        Console.WriteLine(usuarioT.getUsuario().toString());
        sigo = usuarioT.getSiguiente();
    }
    usuarioT.getFinal();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    ConnectionProvider db = new ConnectionProvider();

    for (int i=0; i < 10; i++)
    {
        db.ejecute("INSERT INTO \"user\"(nombre, password) VALUES ('"+i+"','"+(i+100)+"')");
    }
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    UsuarioTable usuarioT = new UsuarioTable();
    bool sigo = usuarioT.getPrimero("SELECT * FROM \"user\"");
    while(sigo)
    {
        Console.WriteLine(usuarioT.getUsuario().toString());
        sigo = usuarioT.getSiguiente();
    }
    usuarioT.getFinal();
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}
