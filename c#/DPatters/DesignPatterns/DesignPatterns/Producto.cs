using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Producto : ProductoComposite
{

    public Producto() : base() { }

    public Producto(String name, int precio, int stock) : base(name, precio, stock) {  }

    public override void add(ProductoComposite child)
    {
        Console.WriteLine("La Hoja no puede tener hijos");
    }

    public override void remove(ProductoComposite child)
    {
        Console.WriteLine("La Hoja no tiene hijos");
    }

    public override void show(int index)
    {
        Console.WriteLine("- " + name + " nivel: " + index);
    }
}

