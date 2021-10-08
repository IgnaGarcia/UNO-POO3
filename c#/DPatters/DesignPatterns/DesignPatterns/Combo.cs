using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Combo : ProductoComposite
{
    private List<ProductoComposite> childs = new List<ProductoComposite>();

    public Combo(): base() { }

    public Combo(String name, int precio, int stock): base(name, precio, stock) { }


    public override void add(ProductoComposite child)
    {
        childs.Add(child);
    }

    public override void remove(ProductoComposite child)
    {
        childs.Remove(child);
    }

    public override void show(int index)
    {
        Console.WriteLine(name + " nivel: " + index);
        for (int i = 0; i < childs.Count; i++)
            childs[i].show(index + 1);
        
    }
}

