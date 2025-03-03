class Arquero : Guerrero
{
    public Arquero(string nombre) : base(nombre, 90, 15) { }

    public override void Atacar(Guerrero enemigo)
    {
        int probabilidad = new Random().Next(1,100);//next slo int 
        if (probabilidad < 30)
        {
            Console.WriteLine($"{Nombre} (Arquero) dispara una flecha y falla");
        }
        else
        {
            Console.WriteLine($"{Nombre} (Arquero) Lanza una flecha y acierta");
            base.Atacar(enemigo);
        }
        
    }

}