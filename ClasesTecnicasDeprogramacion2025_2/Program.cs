
Suministro[] nave = new Suministro[]
{
    new Suministro("Oxigeno",10,1),
    new Suministro("Agua",20,1),
    new Suministro("Comida",12,1),
    new Suministro("Combustible",5,2),
    new Suministro("Herramientas",8,3)
};

nave;


Console.WriteLine("Selecciona la operacion  a realizar");
Console.WriteLine("I Agregar elemento ");
Console.WriteLine("2 Buscar elemento");
Console.WriteLine("3 Borrar todo el inventario");
Console.WriteLine("4 Mostar Inventario");
Console.WriteLine("5 finalizar programa");

int opcion = int.Parse(Console.ReadLine() ?? "");
switch (opcion)  //solo puede recibir enteros o caracteres 
{
    case 1:
        Console.WriteLine("Que sumistro va a agragar");
        
        break;
    case 2:
        Console.WriteLine("Que sumistro va a buscar");

        break;
    case 3:
        Console.WriteLine("Borrando todo el inventario");
        break;
    case 4:
        Console.WriteLine("Mostar todo el inventario");

        break;
    case 5:
        Console.WriteLine("Saliendo del prgrama . . .");
        
        break;

    default:
        Console.WriteLine("una opcion no valida");
        break;

}

//agrega elemenot
//2 busca 
//3 elimir sumistro  clearrrrrr
//4 mostar inventario 
//5 finaliza 