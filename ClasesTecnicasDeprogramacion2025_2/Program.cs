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
            if (opcion !=1 || opcion != 2|| opcion != 3 )
            {
                throw new ArgumentException($"opcion no valida");
            }
        }
        catch
        {

        }
    
    }
     
}

