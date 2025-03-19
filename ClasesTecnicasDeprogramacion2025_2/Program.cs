/*
 * ¡Incluir la implementación de Excepciones!
 */

// Programa principal
GestionCompetencias gestion = new GestionCompetencias();
int operaciones = int.Parse(Console.ReadLine() ?? "");

for (int i = 0; i < operaciones; i++)
{
    string[] entrada = (Console.ReadLine() ?? "").Split(' ');
    string comando = entrada[0];

    switch (comando)
    {
        case "COMPETENCIA":
            //Metodo para registrar competencia
            break;

        case "ATLETA":
            if (entrada.Length == 4)
            {
                //Metodo para regitrar atleta individual
            }
            else
            {
                //Metodo para registrar atleta con equipo
            }
            break;

        case "RESULTADO":
            int posicion;
            if (int.TryParse(entrada[3], out posicion))
            {
                if (/*condición para resultado individual con comentario*/)
                {
                    //Metodo para registrar resultado individual con comentario
                    /*objeto*/.(/* . . .*/string.Join(" ", entrada.Skip(4)));
                }
                else
                {
                    //Metodo para registrar resultado individual sin comentario
                }
            }
            else
            {
                if (/*condición para resultado equipo con comentario*/)
                { 
                    //Metodo para registrar resultado equipo con comentario
                    /*objeto*/.(/* . . .*/string.Join(" ", entrada.Skip(4)));
                }
                else
                {
                    //Metodo para registrar resultado equipo sin comentario
                }
            }
            break;

        case "MEJOR":
            //Metodo para mostrar mejor atleta
            break;

        case "CRITERIO":
            //MEtodo para cmabiar criterio de mejor atleta
            break;

        default:
            Console.WriteLine("Comando no válido.");
            break;
    }
}

