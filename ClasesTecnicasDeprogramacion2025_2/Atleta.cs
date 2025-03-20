public class Atleta
{
    //Propiedades de atleta
    
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Deporte { get; set; }
    public int PrimerosLugares { get; set; }
    public int VictoriasEquipo { get; set; }
    public string Equipo { get; set; }


    //constructor

    public Atleta(string nombre, int edad, string deporte, string equipo = "")
    {
        Nombre = nombre;
        Edad = edad;
        Deporte = deporte;
        Equipo = equipo;
        PrimerosLugares = 0;
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
    /*
     Podemos evitar hacer Override y podemos emplear de manera mas facil una sobrecarga de metodos,
    ya que los podemos sobrecargar en la "class GestionCompetencias" ya que en esa clase con esa sobrecarga 
    puede funcionar como una ""Funcion Recursiva"" (ojo en las comillas grandes).
    Gracias por los metodos Zaa:))
     */
    /*herencia*/
    public void RegistrarResultadoIndividual(int posicion, string competencia)
    {
        if(posicion == 1)
        {
            PrimerosLugares ++;
        }
    }

    /*herencia*/
    public void RegistrarResultadoIndividual(int posicion, string competencia ,string comentario)
    {
        Console.WriteLine($"{Nombre} - {competencia}: {comentario}");
        RegistrarResultadoIndividual(posicion, competencia);
    }

    // Métodos heredar para registrar resultados en equipo
    /*herencia*/
    public void RegistrarResultadoEquipo(string resultado, string competencia)
    {
        if (resultado == "GANADO")
        {
            VictoriasEquipo ++;
        }
    }

    /*herencia*/
    public void RegistrarResultadoEquipo(string resultado, string competencia, string comentario)
    {
        
        Console.WriteLine($"{Equipo} - {competencia}: {comentario}");
        RegistrarResultadoEquipo(resultado, competencia);
    }
}

///////////////////////////////////