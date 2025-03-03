
using static System.Runtime.InteropServices.JavaScript.JSType;

static string ObtenerNombre()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Ingresa el nombre de tu guerrero");
            string nombre = Console.ReadLine()??"".Trim();
            if(string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("El nombre no puede esta vacio");
            }
            return nombre;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

}

static int ObtenerOpcion()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Ingresa la opcion: ");
            int opcion = int.Parse(Console.ReadLine() ?? "");
            if (opcion !=1 && opcion != 2 && opcion != 3 )
            {
                throw new ArgumentException($"opcion no valida");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Errr: {ex.Message}");
        }
    }
     
}

static Guerrero SeleccionarClase(string nombre)
{
    while (true)
    {
        try
        {
            Console.WriteLine("Selecciona la clase: ");
            Console.WriteLine("1 Caballero");
            Console.WriteLine("2 Mago");
            Console.WriteLine("3 Arquero");
            Console.WriteLine("4 Guerrero Sombra");
            int opcion = int.Parse(Console.ReadLine()??"");
            //string nombre;

            return opcion switch
            {
                1 => new Caballero(nombre),
                2 => new Mago(nombre),
                3 => new Arquero(nombre),
                4 => new GuerreroSombra(nombre),
                _ => throw new ArgumentException("Opcion no valida")
            };//punto y coma porque es un switch especial

        }
        catch (Exception ex) 
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }
}

static Guerrero GenerarEnemigo()
{
    string[] nombres = { "Ogro", "Dragon", "Shrek", "Ovni","Hada" };
    int indice = new Random().Next(nombres.Length);
    string nombre = nombres[indice];

    int vida;
    int ataque;
    
    int[] vidas = {150,123,126,250,314 };
    int[] ataques = {1,7,15,16,20 };
    
    indice = new Random().Next(vidas.Length);
    vida = vidas[indice];

    indice = new Random().Next(ataques.Length);
    ataque = ataques[indice];

    return new Guerrero(nombre, vida, ataque);

}

static void MostarEstado(Guerrero jugador, Guerrero enemigo)
{
    Console.WriteLine($"La vida de {jugador.Nombre} : {jugador.Vida}| la vida de {enemigo.Nombre}: {enemigo.Vida}");
    Console.WriteLine("1 Para atacar");
    Console.WriteLine("2 Para defender");
    Console.WriteLine("3 Para fucionarse");

}