//Clase base //solo se puede implementar 
public class Animal
{
    //Metodo
    public void Respirar()
    {
        Console.WriteLine("estoy respirando");
    }
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal ahce un sonido ");
    }

}


interface IAnimalTerrestre
{
    public void Caminar()
    {
        
    }
}

interface IAnimalMamifero
{
    public void Mamifero()
    {
        
    }
}

class Perro: Animal, IAnimalTerrestre, IAnimalMamifero
{
    //metodo del perro 
    public override void HacerSonido()
    {
        Console.WriteLine("Guau Guau");
    }

    public void Caminar()
    {
        Console.WriteLine("Camina en 4 patas");
    }
    public void Mamifero()
    {
        Console.WriteLine("Tiene de 2 a mas hijos");
    }
}

class Gato : Animal, IAnimalTerrestre, IAnimalMamifero
{
    //metodo del Gato 
    public override void HacerSonido()
    {
        Console.WriteLine("Miau Miau");
    }
    public void Caminar()
    {
        Console.WriteLine("Camina en 4 patas pero mas sigiloso ");
    }
    public void Mamifero()
    {
        Console.WriteLine("quiere a su mami");
    }
}