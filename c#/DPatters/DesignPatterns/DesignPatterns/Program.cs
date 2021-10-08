// See https://aka.ms/new-console-template for more information
Singleton s1 = null;
int value = Singleton.getValue();
Console.WriteLine(value);

Singleton.setValue(20);
value = Singleton.getValue();
Console.WriteLine(value);

// -------------------

Producto coca = new Producto("coca");
Producto papitas = new Producto("papitas");
Producto burguer = new Producto("burguer");

Combo combo = new Combo("combo");
combo.add(coca);
combo.add(papitas);
combo.add(burguer);

Console.WriteLine();
combo.show(0);

Combo comboFamiliar = new Combo("familiar");
comboFamiliar.add(combo);
comboFamiliar.add(combo);
comboFamiliar.add(combo);
comboFamiliar.add(combo);

Console.WriteLine();
comboFamiliar.show(0);