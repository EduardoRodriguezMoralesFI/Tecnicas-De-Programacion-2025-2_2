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
    public void RegistrarAtleta(Atleta atleta)
    {
        //Añadir atleta a la lista de atletas
        atletas.Add(atleta);
    }


    //Metodo para registrar resultado invidual sin comentario
    public  void RegistrarResultadoIndividual(string competencia, string nombreAtleta, int posicion)
    {
        foreach (Atleta atleta in atletas)
        {

            if (atleta.Nombre == nombreAtleta)
            {
                atleta.RegistrarResultadoIndividual(posicion, competencia);
                return;
            }
        }
        throw new Exception("Atleta no encontrado.");
    }

    //Metodo para registrar resultado invidual con comentario
    public void RegistrarResultadoIndividual(string competencia, string nombreAtleta, int posicion, string comentario)
    {
        foreach (Atleta atleta in atletas)
        {
            if (atleta.Nombre == nombreAtleta)
            {
                atleta.RegistrarResultadoIndividual(posicion, competencia, comentario);
                return;
            }
        }
        throw new Exception("Atleta no encontrado.");
    }

    //Metodo para registrar resultado en equipo sin comentario
    public void RegistrarResultadoEquipo(string competencia, string nombreEquipo, string resultado)
    {
        foreach (Atleta atleta in atletas)
        {
            if (atleta.Equipo == nombreEquipo)
            {
                atleta.RegistrarResultadoEquipo(resultado, competencia);
            }
        }
        throw new Exception("Equipo no encontrado.");
    }

    //Metodo para registrar resultado en equipo con comentario
    public void RegistrarResultadoEquipo(string competencia, string equipoNombre, string resultado, string comentario)
    {
        foreach (Atleta atleta in atletas)
        {
            if (atleta.getNombreEquipo() == equipoNombre)
            {
                atleta.RegistrarResultadoEquipo(resultado, competencia, comentario);
            }
        }
    }

    //Metodo para cambiar criterio de evaluacion
    public void CambiarCriterio(string criterio)
    {
        
        if (criterio == "PRIMERO")
        {
            estrategia = new EvaluacionPorPrimerosLugares();
        }
        else if (criterio == "VICTORIAS")
        {
            estrategia = new EvaluacionPorVictorias();
        }
        else
        {
            Console.WriteLine("Criterio no válido.");//Una excepcion funcional 
        }
    }

    //Metodo para mostrar mejor atleta
    public void MostrarMejorAtleta(string deporte)
    {
        /*
         Lista de atletas con mejor puntuacion de apoyo para los casos de
        empate
        solo un atleta con mejor puntuacion
        ningun atleta con mejor puntuacion
         */
        List<Atleta> mejoresAtletas = new List<Atleta>();
        int maxValor = -1;

        foreach (Atleta atleta in atletas)
        {
            int valorActual = estrategia.ObtenerValor(atleta);

            if (valorActual > maxValor)
            {
                // Nuevo máximo encontrado, reiniciar la lista de mejores atletas, 
                //Para el caso de que haya un solo mejor 
                maxValor = valorActual;
                mejoresAtletas.Clear();
                mejoresAtletas.Add(atleta);
            }
            else if (valorActual == maxValor)
            {
                // Empate o empte multiple,
                mejoresAtletas.Add(atleta);
            }
        }

        if (mejoresAtletas.Count == 0)
        {
            Console.WriteLine($"No hay atletas registrados en el deporte {deporte} o no tienen valores válidos.");
        }
        else if (mejoresAtletas.Count == 1)
        {
            // Solo un mejor atleta encontrado
            var atleta = mejoresAtletas[0];
            Console.WriteLine($"Mejor atleta: {atleta.Nombre}  Equipo: {atleta.VictoriasEquipo}  Individual: {atleta.PrimerosLugares}.");
        }
        else
        {
            // Cuando tenemos un empate o empate multiple
            Console.WriteLine($"Empate entre los siguientes atletas en {deporte}:");
            foreach (var atleta in mejoresAtletas)
            {
                Console.WriteLine($"{atleta.Nombre}  Equipo: {atleta.VictoriasEquipo}  Individual: {atleta.PrimerosLugares}.");
            }
        }
    }

}

///////////////////////////////////////





