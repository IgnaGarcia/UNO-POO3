using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract public class ProductoComposite
{
    protected String name;
    protected int precio;
    protected int stock;

    public ProductoComposite()
    {
        this.name = "";
    }

    public ProductoComposite(String name, int precio, int stock)
    {
        this.name = name;
        this.precio = precio;
        this.stock = stock;
    }

    abstract public void add(ProductoComposite child);
    abstract public void remove(ProductoComposite child);
    abstract public void show(int index);
}
