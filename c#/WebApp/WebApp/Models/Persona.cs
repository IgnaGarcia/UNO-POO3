namespace WebApp.Models
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;   
            this.edad = edad;
        }

        public static Persona getPersona()
        {
            return new Persona("nacho", 22);
        }

        public static List<Persona> getPersonas()
        {
            List<Persona> list = new List<Persona>();
            list.Add(new Persona("nacho", 22));
            list.Add(new Persona("pableki", 30));
            list.Add(new Persona("maxxx", 28));
            list.Add(new Persona("wally", 34));
            return list;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public int getEdad()
        {
            return this.edad;
        }

        public string toString()
        {
            return this.nombre + " - " + this.edad;
        }
    }
}
