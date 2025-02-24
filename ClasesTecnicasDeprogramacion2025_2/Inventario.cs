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
            Console.WriteLine($"Nombre: {s.Nombre}, Cantidad: {s.Cantidad}, Prioridad: {s.Prioridad}");
        }

    }

    public void BuscarSuministro(string nombre)
    {
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