public class Libro
{
    //propiedades 
    public string Titulo {  get; set; }
    public string Autor {  get; set; }
    public string Genero { get; set; }


    //constrcutores 
    public Libro(string titulo, string autor, string genero)
    {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
    }
    //metodos 

    public void mostarTitulo()
    {
        Console.WriteLine($"El Titulo es: {Titulo}");
    }

    public void mostarAutor()
    {
        Console.WriteLine($"El Titulo es: {Autor}");
    }

    public void mostarGenero()
    {
        Console.WriteLine($"El Titulo es: {Genero}");
    }


}