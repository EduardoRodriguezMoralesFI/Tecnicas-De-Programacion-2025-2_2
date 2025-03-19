class Atleta
{
    //Propiedades de atleta
    /*
     * propiedades de atleta
     * Nombre
     * Edad
     * Deporte
     * PrimeroLugares
     * VictoriasEquipo
     * Equipo
     */
    string Nombre { get; set; }
    int Edad { get; set; }
    string Deporte { get; set; }
    int PrimeroLugares { get; set; }
    int VictoriasEquipo { get; set; }
    string Equipo { get; set; }


    //constructor

    public Atleta(string nombre, int edad, string deporte, string equipo = "")
    {
        Nombre = nombre;
        Edad = edad;
        Deporte = deporte;
        Equipo = equipo;
        PrimeroLugares = 0;
        VictoriasEquipo = 0;
    }

    public string getNombre()
    {
        return Nombre;
    }
    public string getNombreEquipo()
    {
        return Equipo;
    }

    // Métodos a heredar para registrar resultados individuales
    /*herencia*/
    public void RegistrarResultadoIndividual(int posicion)
    {
        if(posicion == 1)
        {
            PrimeroLugares += 1;
        }
    }

    /*herencia*/
    public void RegistrarResultadoIndividual(int posicion, string comentario)
    {
        if (posicion == 1)
        {
            PrimeroLugares += 1;
        }
        Console.WriteLine($"comentarios {comentario}");
    }

    // Métodos heredar para registrar resultados en equipo
    /*herencia*/
    public void RegistrarResultadoEquipo(int posicion)
    {
        if (posicion == 1)
        {
            PrimeroLugares += 1;
        }
    }

    /*herencia*/
    public void RegistrarResultadoEquipo(int posicion, string comentario)
    {
        if (posicion == 1)
        {
            PrimeroLugares += 1;
        }
        Console.WriteLine($"comentarios {comentario}");
    }
}