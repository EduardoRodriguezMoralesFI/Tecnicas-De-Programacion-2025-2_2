//string nombre;
static string ObtenerNombre()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Ingresa el nombre de tu guerrero: ");
            string nombre = Console.ReadLine() ?? "".Trim(); //.Trim quita los espacios en blanco
            if (string.IsNullOrEmpty(nombre)) //Es nulo o vacío
            {
                throw new ArgumentException("El nombre no puede estar vacío");
            }
            return nombre;
        }
        catch (Exception ex)
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
            Console.WriteLine("Ingrese una opción:");

            int opcion = int.Parse(Console.ReadLine() ?? "");

            if (opcion != 1 && opcion != 2 && opcion != 3)
            {
                throw new ArgumentException("Opción no valida");
            }
            return opcion;

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }
}


static Guerrero SeleccionarClase(string nombre)
{
    while (true)
    {
        try
        {
            Console.WriteLine("Selecciona tu clase");

            Console.WriteLine("1 Caballero");
            Console.WriteLine("2 Mago");
            Console.WriteLine("3 Arquero");
            Console.WriteLine("4 Guerrero Sombra");

            int opcion = int.Parse(Console.ReadLine() ?? "");


            return opcion switch
            {
                1 => new Caballero(nombre),
                2 => new Mago(nombre),
                3 => new Arquero(nombre),
                4 => new GuerreroSombra(nombre),
                _ => throw new ArgumentException("Opción no válida")
            };
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

static Guerrero GenerarEnemigo()
{
    string[] nombres = { "Ogro", "Dragón", "Shrek", "Ovni", "Hada","Juan", "YOYO","Cavernicola","Kanye West","*****"};
    int indice = new Random().Next(0, nombres.Length);
    string nombre = nombres[indice];

    int vida;
    int ataque;

    int[] vidas = { 150, 123, 126, 250, 314,116,200,236,201,189 };
    int[] ataques = { 1, 7, 15, 16, 20,21,22,23,24,25 };

    indice = new Random().Next(0, vidas.Length);
    vida = vidas[indice];

    indice = new Random().Next(0, ataques.Length);
    ataque = ataques[indice];

    return new Guerrero(nombre, vida, ataque);
}


static void MostrarEstado(Guerrero jugador, Guerrero enemigo,bool fusion)
{
    Console.WriteLine($"La vida de {jugador.Nombre}: {jugador.Vida} | La vida del enemigo {enemigo.Nombre} : {enemigo.Vida} ");

    Console.WriteLine("1 Para Atacar");
    Console.WriteLine("2 Para Defender");
    if (!fusion)
    {
        Console.WriteLine("3 Intentar Fusión");
    }
    

}

//Programa principal
try
{
    Console.WriteLine("Bienvenido al combate, dale un nombre a tu guerrero");

    string nombre = ObtenerNombre();

    Guerrero jugador = SeleccionarClase(nombre);
    Guerrero enemigo = GenerarEnemigo();

    Console.WriteLine($"Te enfrentraras a {enemigo.Nombre} con vida de {enemigo.Vida} y ataque {enemigo.Ataque}");
    bool fusion = false;
    do
    {
        
        //MostrarEstado(jugador, enemigo);
        MostrarEstado(jugador, enemigo, fusion);
        int opcion = ObtenerOpcion();
        try
        {
           
            if (!fusion)
            {
                switch (opcion)
                {
                    case 1:
                        jugador.Atacar(enemigo);
                        break;

                    case 2:
                        Console.WriteLine($"{jugador.Nombre} se defiende y reduce el daño");
                        enemigo.Atacar(enemigo);
                        jugador.RecibirDanio(enemigo.Ataque / 2);
                        break;

                    case 3:
                        Console.WriteLine("Intentando fusión...");

                        int probabilidad = new Random().Next(1, 100);

                        if (probabilidad >= 50 && !fusion)
                        {
                            jugador = jugador + enemigo;
                            Console.WriteLine($"Tu nuevo guerrero es {jugador.Nombre}");
                            fusion = true;
                        }
                        else
                        {
                            Console.WriteLine($"¡La fusion falló y perdiste vida!");
                            jugador.RecibirDanio(25);

                        }
                        break;

                    default:
                        throw new ArgumentException("Opción invalida");

                }


            }
            else
            {
                switch (opcion)
                {
                    case 1:
                        jugador.Atacar(enemigo);
                        break;

                    case 2:
                        Console.WriteLine($"{jugador.Nombre} se defiende y reduce el daño");
                        enemigo.Atacar(enemigo);
                        jugador.RecibirDanio(enemigo.Ataque / 2);
                        break;

                        

                    default:
                        throw new ArgumentException("Opción invalida");

                }
            }
            
                        
        }//
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (enemigo.Vida > 0)
            {
                jugador.RecibirDanio(enemigo.Ataque);
            }
        }

    }
    while (enemigo.Vida > 0 && jugador.Vida > 0);

    if (enemigo.Vida > 0)
    {
        Console.WriteLine($"{enemigo.Nombre} te ha derrotado!");

    }
    else
    {
        Console.WriteLine($"{jugador.Nombre} ha derrotado a {enemigo.Nombre} y ha ganado el combate!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}




/*
using static System.Runtime.InteropServices.JavaScript.JSType;
//Funciones de Apoyo
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
            Console.WriteLine($"Error: {ex.Message}");
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

    return new Guerrero(nombre,vida,ataque);

}

static void MostarEstado(Guerrero jugador, Guerrero enemigo)
{
    Console.WriteLine($"La vida de {jugador.Nombre} : {jugador.Vida}| la vida de {enemigo.Nombre}: {enemigo.Vida}");
    Console.WriteLine("1 Para atacar");
    Console.WriteLine("2 Para defender");
    Console.WriteLine("3 Para fucionarse");

}

//Programa Principal

try
{
    Console.WriteLine("Bienvenido al combae, dale un nombre a tu guerrero");
    
    string nombre = ObtenerNombre();
    
    Guerrero jugador = SeleccionarClase(nombre);
    Guerrero enemigo = GenerarEnemigo();

    Console.WriteLine($"Te enfrentaras a {enemigo.Nombre} con vida {enemigo.Vida} y ataque {enemigo.Ataque}");

    do
    {
        MostarEstado (jugador, enemigo);
        int opcion = ObtenerOpcion();
        bool fusion = false;

        try
        {
            switch (opcion)
            {
                case 1:
                    jugador.Atacar(enemigo);
                    break;
                case 2:
                    Console.WriteLine($"{jugador.Nombre} se defiende y reduce el daño");
                    enemigo.Atacar(jugador);
                    jugador.RecibirDanio(enemigo.Ataque / 2);
                    break;
                case 3:
                    Console.WriteLine($"Intentando fusion...");

                    int probabilidad = new Random().Next(1, 100);

                    if (probabilidad >= 50 && !fusion)
                    {
                        jugador = jugador + enemigo;
                        Console.WriteLine($"Tu nuevo guerrero es {jugador.Nombre}");
                        fusion = true;
                    }
                    else
                    {
                        Console.WriteLine($"La fusion fallo y perdiste vida!!");
                        jugador.RecibirDanio(25);
                    }
                    break;
                default:
                    throw new ArgumentException("Opcion Invalida");
                    
            }
        }
        catch (ArgumentException ex)
        { 
            Console.WriteLine(ex.Message);
        
        }
        finally
        {
            if (enemigo.Vida > 0)
            {
                jugador.RecibirDanio(enemigo.Ataque);
            }
        }


    } while (enemigo.Vida > 0 && jugador.Vida > 0);
    if (enemigo.Vida > 0)
    {
        Console.WriteLine($"{enemigo.Nombre} Te ha derrotado!");
    }
    else
    {
        Console.WriteLine($"{jugador.Nombre} ha derrotado a {enemigo.Nombre} y ha ganado la partida");
    }

    Console.WriteLine();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

*/

