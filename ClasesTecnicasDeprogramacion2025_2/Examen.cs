/*
 * ¡Incluir la implementación de Excepciones!
 */

// Programa principal

GestionCompetencias gestion = new GestionCompetencias();

try
{
    Console.WriteLine("Ingrese el número de operaciones a realizar: ");
    int operaciones = int.Parse(Console.ReadLine() ?? "0");

    for (int i = 0; i < operaciones; i++)
    {
        string[] entrada = (Console.ReadLine() ?? "").Split(' ');
        string comando = entrada[0];

        switch (comando)
        {
            case "COMPETENCIA"://Agregar el nombre de la competencia y el deporte en especifico 
                if (entrada.Length < 3)
                {
                    Console.WriteLine("Error: Datos insuficientes para registrar una competencia.");
                    continue;
                }
                string nombreCompetencia = entrada[1];
                string deporteCompetencia = entrada[2];
                gestion.RegistrarCompetencia(nombreCompetencia, deporteCompetencia);
                break;

            case "ATLETA":
                if (entrada.Length < 4)
                {
                    Console.WriteLine("Error: Datos insuficientes para registrar un atleta.");
                    continue;
                }
                string nombre = entrada[1];
                int edad;
                if (!int.TryParse(entrada[2], out edad))
                {
                    Console.WriteLine("Error: La edad debe ser un número entero.");
                    continue;
                }
                string deporte = entrada[3];
                string equipo = entrada.Length == 5 ? entrada[4] : ""; // Si tiene equipo
                gestion.RegistrarAtleta(new Atleta(nombre, edad, deporte, equipo));
                break;

            case "RESULTADO":
                if (entrada.Length < 4)
                {
                    Console.WriteLine("Error: Datos insuficientes para registrar un resultado.");
                    continue;
                }
                /* 
                 Esta parte del codigo es de vital imprtancia ya que nuestra "entrada[3]", 
                nos va a indicar si es un resultado individual o en equipo mediante un tipo de dato 
                bool para mayor facilidad .
                 */
                string competencia = entrada[1];
                string nombreAtletaOEquipo = entrada[2];
                int posicion;
                bool esIndividual = int.TryParse(entrada[3], out posicion);

                if (esIndividual)
                {
                    // Es un resultado individual
                    if (entrada.Length > 4)
                    {
                        // Con comentario
                        string comentario = string.Join(" ", entrada.Skip(4));
                        gestion.RegistrarResultadoIndividual(competencia, nombreAtletaOEquipo, posicion, comentario);
                    }
                    else
                    {
                        // Sin comentario
                        gestion.RegistrarResultadoIndividual(competencia, nombreAtletaOEquipo, posicion);
                    }
                }
                else
                {
                    // Es un resultado en equipo
                    string resultado = entrada[3]; // GANADO o PERDIDO

                    if (entrada.Length > 4)
                    {
                        // Con comentario
                        string comentario = string.Join(" ", entrada.Skip(4));
                        gestion.RegistrarResultadoEquipo(competencia, nombreAtletaOEquipo, resultado, comentario);

                    }
                    else
                    {
                        // Sin comentario
                        gestion.RegistrarResultadoEquipo(competencia, nombreAtletaOEquipo, resultado);
                    }
                }
                break;

            case "MEJOR":
                if (entrada.Length < 2)
                {
                    Console.WriteLine("Error: Debe especificar un deporte.");
                    continue;
                }
                string MejorEnDeporte = entrada[1];
                gestion.MostrarMejorAtleta(MejorEnDeporte);
                break;

            case "CRITERIO":
                if (entrada.Length < 2)
                {
                    Console.WriteLine("Error: Debe especificar un criterio.");
                    continue;
                }
                gestion.CambiarCriterio(entrada[1]);
                break;

            default:
                Console.WriteLine("Comando no válido.");
                break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Se produjo un error: {ex.Message}");
}
/////////////////////////////////
////*
///Tal vez una excepcion un poco floja , pero es funcional.!!!2
/// */