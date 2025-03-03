using System.Security.Cryptography.X509Certificates;

class GuerreroSombra : Guerrero
{
    public GuerreroSombra(string nombre) : base(nombre, 110, 22) { }

    public override void Atacar(Guerrero enemigo)
    {
        int probabilidad = new Random().Next(1, 100);//next slo int 
        if (probabilidad < 20)
        {
            Console.WriteLine($"{Nombre} (Guerrero Sombra) esuiva el ataque");
        }
        else
        {
            Console.WriteLine($"{Nombre} (Guerrero Sombra) ataca");
            base.Atacar(enemigo);
        }

    }


}

