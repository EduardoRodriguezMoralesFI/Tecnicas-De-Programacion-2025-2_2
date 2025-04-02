using System;
public class Estudiante
{
    //propiedades

    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    public Estudiante(int id, string nombre, int edad, double calificacion)
    {
        Id = id;
        Nombre = nombre;
        Edad = edad;
        Calificacion = calificacion;
    }
    
    public override string ToString()
    {
        return $"{Id},{Nombre},{Edad},{Calificacion}";
    }
}

public class GestorEstudiantes
{
    //propiedades
    private string Ruta;
    //constructor

    public GestorEstudiantes(string ruta)
    {
        Ruta = ruta;
    }
    //metodos 
    public void GuardarEstudiante(List<Estudiante> estudiantes)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(Ruta))
            {
                foreach (Estudiante estudiante in estudiantes)
                {
                    writer.WriteLine(estudiante.ToString());
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public List<Estudiante> LeerEstudiantes()
    {
        List<Estudiante> newEstudiantes = new List<Estudiante>();
        try
        {
            if (File.Exists(Ruta))
            {
                using (StreamReader reader = new StreamReader(Ruta))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] lines = linea.Split(',');
                        if (lines.Length == 4)
                        {
                            newEstudiantes.Add(new Estudiante
                            (
                                int.Parse(lines[0]),
                                lines[1],
                                int.Parse(lines[2]),
                                double.Parse(lines[3])
                            ));

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Archivo no existe");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        return newEstudiantes;
    }

    public Estudiante BuscarEstudiantePorId(int id)
    {
        try
        {
            if (File.Exists(Ruta))
            {
                using (StreamReader reader = new StreamReader(Ruta))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] lines = linea.Split(',');
                        if (int.Parse(lines[0])==id)
                        {
                            return new Estudiante
                            (
                                int.Parse(lines[0]),
                                lines[1],
                                int.Parse(lines[2]),
                                double.Parse(lines[3])
                            );
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Archivo no existe");
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}