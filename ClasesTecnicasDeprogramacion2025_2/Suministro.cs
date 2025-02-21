class Suministo
{
    //Propiedades 
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public int Prioridad { get; set; }//Alta=1, Media = 2, Baja = 3


    //constructor 
    public Suministo(string nombre, int cantidad, int prioridad)
    {
        Nombre = nombre;
        Cantidad = cantidad;
        Prioridad = prioridad;
    }
    //sobrecarga del constructor
    public Suministo(string nombre)
    {
        Nombre = nombre;
        Cantidad = 1;
        Prioridad = 2;
    }

    //Metodos 

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre} Cantidad {Cantidad} Prioridad {Prioridad}");
    }


}