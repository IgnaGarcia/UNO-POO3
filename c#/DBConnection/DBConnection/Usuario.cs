class Usuario
{
    private int id;
    private string name;
    private string password;

    public Usuario(int v1, string? v2, string? v3)
    {
        this.id = v1;
        this.name = v2;
        this.password = v3;
    }

    public string toString()
    {
        return id.ToString() +" "+ name +" "+ password;
    }
}