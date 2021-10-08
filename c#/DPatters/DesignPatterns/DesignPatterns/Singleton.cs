using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Singleton
{
    private int value;
    private static Singleton instance = null;

    private Singleton()
    {
        value = 10;
    }

    private static void createInstance()
    {
        if (instance == null) instance = new Singleton();
    }

    public static Singleton getInstance()
    {
        if (instance == null) createInstance();

        return instance;
    }

    public static int getValue()
    {
        return getInstance().value;
    }

    public static void setValue(int nuevo)
    {
        getInstance().value = nuevo;
    }
}

