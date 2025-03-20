// Clase para representar una competencia-----------------
class Competencia
{
    /*
     * Propiedades de una competencia
     * Nombre
     * Deporte
     */
    public string Nombre { get; set; }
    public string Deporte { get; set; }

    //Constructor competencia

    public Competencia(string nombre, string deporte)
    {
        Nombre = nombre;
        Deporte = deporte;

    }
}

/////////////////////////////////