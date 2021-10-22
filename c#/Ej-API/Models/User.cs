namespace Ej_API.Models
{
    public class User
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; } 

        public User(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        override public string ToString()
        {
            return this.nombre;
        }
    }
}
