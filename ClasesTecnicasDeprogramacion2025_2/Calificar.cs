public class Calificar: Libro
{
    //Propiedaes
    public int Calificaion {  get; }
    public string Comentario {  get; }

    //constrcutor 
    public Calificar(string titulo, string autor, string genero, int calificacion, string comentario): base(titulo, autor,genero) 
    {
        Calificaion = calificacion;
        Comentario = comentario;
    }

    //Metodos
    public void ingresarCalificacion(int calif)
    {
        bool califB = false;
        do
        {
            Console.WriteLine($"Ingresa la calificacion del LIbro: {Titulo}, recuerda que tiene que estar en el intervalo de 1 a 5 ");
            calif = Console.ReadLine() ?? "";
        }
        
    }
}