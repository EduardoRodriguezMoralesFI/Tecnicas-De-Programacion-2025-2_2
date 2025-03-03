class Caballero : Guerrero
{
    public Caballero(string nombre) : base(nombre, 120, 20) { }

    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} (caballero) usa golpe critico ");
        base.Atacar( enemigo ); 
    }

}