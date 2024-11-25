using Proyecto_TDD;

Vaso vasoPeque = new Vaso(1, 100);

Console.WriteLine(vasoPeque.GetContenido());

vasoPeque.SetContenido(200);
Console.WriteLine(vasoPeque.GetContenido());
