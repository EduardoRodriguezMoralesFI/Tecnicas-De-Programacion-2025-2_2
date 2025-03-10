interface Ivolador
{
    //Metodo interfaz
    public void Volar()
    {
    }
    

}

class Pajaro :Animal, Ivolador //primero la clase padre y despues la interfaz 
{
    public void Volar()
    {
        Console.WriteLine("Soy un pajaro que vuela ");
    }
    public override void HacerSonido()
    {
        Console.WriteLine(" Pio Pio");
    }

}
