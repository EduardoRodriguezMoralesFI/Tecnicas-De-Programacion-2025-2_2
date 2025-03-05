

class Guerrero
{
    //Atributos 
    public int Vida { get; set; }
    public string Nombre { get; set; }
    public int Ataque { get; set; }

    //Constructor 
    public Guerrero(string nombre, int vida, int ataque)
    {
        Nombre = nombre;
        Ataque = ataque;
        Vida = vida;
    }

    //Metodos 

    public virtual void Atacar(Guerrero enemigo)
    {
        int danio = Ataque + new Random().Next(-3,5);
        enemigo.RecibirDanio(danio);
        Console.WriteLine($"{Nombre} ataca a {enemigo.Nombre} casusa {danio} daño");

    }

    public void RecibirDanio(int cantidad)
    {
        Vida = Math.Max(Vida-cantidad, 0);
        Console.WriteLine();
    }

    public static Guerrero operator+(Guerrero g1, Guerrero g2)
    {
        Console.WriteLine($"{g1.Nombre} y {g2.Nombre} se fucionan");
         return new Guerrero($"{g1.Nombre} & {g2.Nombre}", (g1.Vida) + (g2.Vida),(g1.Ataque+g2.Ataque)/2) ;

    }










}