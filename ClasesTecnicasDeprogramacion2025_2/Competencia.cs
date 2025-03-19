// Clase para representar una competencia-----------------
class Competencia
{
    /*
     * Propiedades de una competencia
     * Nombre
     * Deporte
     */
    string Nombre { get; set; }
    string Deporte { get; set; }

    //Constructor competencia

    public Competencia(string nombre, string deporte)
    {
        Nombre = nombre;
        Deporte = deporte;

    }
}
