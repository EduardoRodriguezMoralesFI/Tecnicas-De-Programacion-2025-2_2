using System.Windows.Markup;

class GestionCompetencias
{
  
    List<Competencia> competencias = new List<Competencia>();
    List<Atleta> atletas = new List<Atleta>();
    IEstrategiaEvaluacion estrategia = new EvaluacionPorPrimerosLugares();

    //Metodo para registrar competencia 
    public void RegistrarCompetencia(string nombreCompetencia, string deporte)
    {
        //Añadir comptencia a la lista de competencias
        competencias.Add(new Competencia(nombreCompetencia, deporte));

    }

    //MEtodo para registrar un atleta
    public void RegistrarAtleta( Atleta atleta)
    {
        //Añadir atleta a la lista de atletas
        atletas.Add(atleta);
    }


    //Metodo para registrar resultado invidual sin comentario
    public void RegistrarResultadoIndividual(string nombreAtleta, int posicion)
    {
        foreach (var atleta in atletas)
        {
            if (atleta.getNombre()  == nombreAtleta)
            {
                atleta.RegistrarResultadoIndividual(posicion);
                return;
            }
        }
        throw new Exception("Atleta no encontrado.");
    }

    //Metodo para registrar resultado invidual con comentario
    public void RegistrarResultadoIndividual(string nombreAtleta, int posicion, string comentario)
    {
        foreach (var atleta in atletas)
        {
            if (atleta.getNombre() == nombreAtleta)
            {
                atleta.RegistrarResultadoIndividual(posicion, comentario);
                return;
            }
        }
        throw new Exception("Atleta no encontrado.");
    }

    //Metodo para registrar resultado en equipo sin comentario
    public void RegistrarResultadoEquipo(string nombreEquipo, int posicion)
    {
        foreach (var atleta in atletas)
        {
            if (atleta.getNombreEquipo() == nombreEquipo)
            {
                atleta.RegistrarResultadoEquipo(posicion);
            }
        }
    }

    //Metodo para registrar resultado en equipo con comentario
    public void RegistrarResultadoEquipo(string nombreEquipo, int posicion, string comentario)
    {
        foreach (var atleta in atletas)
        {
            if (atleta.getNombreEquipo() == nombreEquipo)
            {
                atleta.RegistrarResultadoEquipo(posicion, comentario);
            }
        }
    }

    //Metodo para cambiar criterio de evaluacion
    public void CambiarCriterio(string criterio)
    {
        Console.WriteLine("Escribir criterio: PrimerosLugares o  Victorias");

        if (criterio == "PrimerosLugares")
        {
            estrategia = new EvaluacionPorPrimerosLugares();
        }
        else if (criterio == "Victorias")
        {
            estrategia = new EvaluacionPorVictorias();
        }
        else
        {
            Console.WriteLine("Criterio no válido.");
        }
    }

    //Metodo para mostrar mejor atleta
    public void MostrarMejorAtleta(/*parametro de selección*/)
    {
        Atleta mejorAtleta = null;
        int maxValor = -1;

        foreach (/*cada atleta en la lista de atletas*/)
        {
            if (/*comprobación del parametro de seleccion*/)
            {
                int valorActual = estrategia.ObtenerValor(atleta);

                /*Algoritmo para comprobar si el atleta actual de la lista tiene mayor valor o hacer el cambio*/
            }
        }

        if (mejorAtleta != null)
        {
            //Imprimir resultado
        }
        else
        {
            //Imprimir resultado
        }
    }


    ////////////////////////--------------------------------------------------

    //Metodo para registrar resultado invidual con comentario


//Metodo para registrar resultado en equipo sin comentario

//Metodo para registrar resultado en equipo con comentar

//Metodo para cambiar criterio de evaluacion
public void CambiarCriterio(string criterio)
{
    if (criterio == "PrimerosLugares")
    {
        estrategia = new EvaluacionPorPrimerosLugares();
    }
    else if (criterio == "Victorias")
    {
        estrategia = new EvaluacionPorVictorias();
    }
    else
    {
        Console.WriteLine("Criterio no válido.");
    }
}

//Metodo para mostrar mejor atleta
public void MostrarMejorAtleta()
{
    Atleta mejorAtleta = null;
    int maxValor = -1;

    foreach (var atleta in atletas)
    {
        int valorActual = estrategia.ObtenerValor(atleta);
        if (valorActual > maxValor)
        {
            maxValor = valorActual;
            mejorAtleta = atleta;
        }
    }

    if (mejorAtleta != null)
    {
        Console.WriteLine($"El mejor atleta es {mejorAtleta.GetNombre()} con un valor de {maxValor}.");
    }
    else
    {
        Console.WriteLine("No hay atletas registrados.");
    }
}



