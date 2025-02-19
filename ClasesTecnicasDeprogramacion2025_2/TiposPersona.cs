class Romantico : Persona
{
    //Constructor 
    public Romantico(string nombre, int edad) : base (nombre, edad){ }

    //Metodos Overside porque son heradodos de la clase Persona 
    public override void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} muestra su interes enviando una carta");
    }

    public override void ExpresarSentimientoss()
    {
        Console.WriteLine ($"{Nombre} expresa sus sentimientos dedicando un poema");
    }

}


class Amistoso : Persona
{
    //Constructor 
    public Amistoso(string nombre, int edad) : base(nombre, edad) { }

    //Metodos Overside porque son heradodos de la clase Persona 
    public override void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} muestra su interes invitando un cafe");
    }

    public override void ExpresarSentimientoss()
    {
        Console.WriteLine($"{Nombre} expresa sus sentimientos compartiendo una historia divertida");
    }

}

class Indiferente : Persona
{
    //Constructor 
    public Indiferente(string nombre, int edad) : base(nombre, edad) { }

    //Metodos Overside porque son heradodos de la clase Persona 
    public override void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} finge no mostrar su interes");
    }

    public override void ExpresarSentimientoss()
    {
        Console.WriteLine($"{Nombre} prefiere estar solo");
    }

}