



/*

class Inventario
{
    public void OrdenarPorNombre()
    {
        //yei
        //Arriba mecatrónica :) 
        //¿Y de que semestre eres?
        int indiceNull = Array.FindIndex(suministros, s => s == null);
        if (indiceNull >= 0)
        {
            Console.WriteLine("No hay inventario");
        }

        else
        {
            Console.WriteLine($"Lista de suministro ordenada alfabeticamente:");

            Array.Sort(suministros, (x, y) => x.Nombre.CompareTo(y.Nombre));

            foreach (Suministro s in suministros)
            {
                Console.WriteLine(s.Nombre);
            }
        }
    }

    //Propiedades
    private Suministro[] suministros;

    //Constructor

    public Inventario()
    {
        suministros = new Suministro[]
        {
            new Suministro("Oxigeno",10,1),
            new Suministro("Agua",20,1),
            new Suministro("Comida",15,1),
            new Suministro("Combustible",5,2),
            new Suministro("Herramientas",8,3)
        };
    }

    //Metodos
    public void MostrarSuministros()
    {

        foreach (Suministro s in suministros)
        {
            if (s != null)
            {
                Console.WriteLine($"Nombre: {s.Nombre}, Cantidad: {s.Cantidad}, Prioridad: {s.Prioridad}");
            }
        }
    }

    public void BuscarSuministros(string nombre)
    {
        int indiceNull = Array.FindIndex(suministros, s => s == null);
        if (indiceNull >= 0)
        {
            Console.WriteLine("El inventario esta vacio");
        }
        else
        {
            int indice = Array.FindIndex(suministros, s => s.Nombre.ToLower() == nombre.ToLower());

            if (indice >= 0)
            {
                Console.WriteLine($"{nombre} encontrado en el indice {indice}");
            }

            else
            {
                Console.WriteLine($"{nombre} no encontrado en el inventario");
            }
        }

    }



    public void InvertirOrden()
    {
        Array.Reverse(suministros);

        foreach (Suministro s in suministros)
        {
            Console.WriteLine(s.Nombre);
        }
    }

    public void VaciarInventario()
    {
        try
        {
            Array.Clear(suministros, 0, suministros.Length);
        }

        catch (Exception e)
        {
            Console.WriteLine($"Error: {e}");
        }
        Console.WriteLine("Inventario vaciado.");
    }

    public void AgregarSuministro(string nombre, int cantidad, int prioridad)
    {
        int indiceNull = Array.FindIndex(suministros, s => s == null);
        if (indiceNull >= 0)
        {
            suministros[indiceNull] = new Suministro(nombre, cantidad, prioridad);
        }
        else
        {
            try
            {
                if (cantidad > 0 && prioridad < 4 && prioridad > 0)
                {
                    Array.Resize(ref suministros, suministros.Length + 1);
                    suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
                }
                else
                {
                    throw new CantidadNegativa("No puedes agregar una cantidad negativa")
                    
                }

            }
            catch (Exception e)
            {
            }
            
            /*
            if (cantidad > 0 && prioridad <4 && prioridad>0)
            {
                Array.Resize(ref suministros, suministros.Length + 1);
                suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
            }
            else
            {
                Console.WriteLine("La cantidad es negativa o la prioridad no esta dentro del intervalo");            
            }
            
        }

    }

    //Sobrecarga

    public void AgregarSuministro(string nombre)
    {
        Array.Resize(ref suministros, suministros.Length + 1);

        suministros[suministros.Length - 1] = new Suministro(nombre, 1, 2);
    }
}


class CantidadNegativa : Exception
{
    public CantidadNegativa(string message) : base(message) { }


}
*/

/*
class Inventario 
{
    //Propiedades 
    private Suministro[] suministros;
    
    //constrcutor 

    public Inventario()
    {
        suministros = new Suministro[]
        {
            new Suministro("Oxigeno",10,1),
            new Suministro("Agua",20,1),
            new Suministro("Comida",12,1),
            new Suministro("Combustible",5,2),
            new Suministro("Herramientas",8,3)
        };
    }

    //Metodos

    public void MostarSuministros()
    {

        foreach(Suministro s in suministros)
        {
            if ( s != null)
            {
                Console.WriteLine($"Nombre: {s.Nombre}, Cantidad: {s.Cantidad}, Prioridad: {s.Prioridad}");
            }
            
        }

    }

    public void BuscarSuministro(string nombre)
    {
        int indiceNull = Array.FindIndex(suministros, s => s == null);
        int indice = Array.FindIndex(suministros,s => s.Nombre.ToLower()== nombre.ToLower());//operadir landa "=>" tal que o ese 
        

        if (indice >= 0)
        {
            Console.WriteLine($"{nombre} encontrado en el indice {indice}");
        }
        else
        {
            Console.WriteLine($"{nombre} No encontrado en el inventario");
        }
    }

    public void OrdenarPorNombre()
    {
        
        Console.WriteLine($"La lista de suministro ordenada alfabeticamente");
        Array.Sort(suministros, (x,y) => x.Nombre.CompareTo(y.Nombre));
        foreach(Suministro s in suministros)
        {
            Console.WriteLine(s.Nombre);
        }
    }
    
    public void InvertirOrden()
    {
        Array.Reverse(suministros);

    }

    public void VaciarInventario()
    {
        Array.Clear(suministros,0,suministros.Length);

    }

    public void AgregarSuministro(string nombre, int cantidad, int prioridad)
    {
        int indiceNull = Array.FindIndex(suministros, s => null);
        if (indiceNull >= 0)
        {
            suministros[indiceNull] = new Suministro(nombre, cantidad, prioridad);
        }
        else
        {
            Array.Resize(ref suministros, suministros.Length + 1);
            suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
            /*
            try
            {
                Array.Resize(ref suministros, suministros.Length + 1);
                suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
                foreach (Suministro s in suministros)
                {
                    if (s != null)
                    {
                        Console.WriteLine(s.Nombre);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
            
        }
        
        try
        {
            Array.Resize(ref suministros, suministros.Length + 1);
            suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
            foreach(Suministro s in suministros)
            {
                if (s != null)
                {
                    Console.WriteLine(s.Nombre);
                }
            }

        }
        catch(Exception e) 
        { 
            Console.WriteLine($"Error: {e}");
        }
        
    }

    public void AgregarSuministro(string nombre)
    {
        try
        {
            Array.Resize(ref suministros, suministros.Length + 1);
            suministros[suministros.Length - 1] = new Suministro(nombre);
            foreach (Suministro s in suministros)
            {
                if (s != null)
                {
                    Console.WriteLine(s.Nombre);
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e}");
        }

    }




}

*/