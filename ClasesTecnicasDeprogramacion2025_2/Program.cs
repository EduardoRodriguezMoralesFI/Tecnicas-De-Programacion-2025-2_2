//Escribir un archivo de Texto

string ruta = "archivo.txt";
string ruta2 = @"C:\Users\Alumnos\source\repos\EduardoRodriguezMoralesFI\Tecnicas-De-Programacion-2025-2_2\ClasesTecnicasDeprogramacion2025_2\bin\Debug\net8.0\archivo2.txt";
string contenido;
using (StreamWriter writer = new StreamWriter(ruta, false))//editor de archivos en stream = tiampo real//tambien lo bloquea hasta que se termine 
{
    writer.WriteLine("Hola Mundo");
    writer.WriteLine("Adios Mundo");
    for (int i = 0; i < 10; i++)
    {
        writer.WriteLine(i);
    }
}
Console.WriteLine("Archivo escrito");


//Leer un archivo de texto
using (StreamReader reader = new StreamReader(ruta))
{
    contenido = reader.ReadToEnd();//elimina salto de linea al primer salto de linea 
    Console.WriteLine(contenido);

}
//transcribir un archivo a otro
using (StreamWriter writer = new StreamWriter(ruta2, false))//
{
    writer.WriteLine(contenido);
}

//archivo binario
string rutaB = "binario.bin";
using (StreamWriter writer = new StreamWriter(File.Open(rutaB,FileMode.Create)))
{
    writer.WriteLine(25);
    writer.WriteLine(3.14);
    writer.WriteLine("Texto binario ");
}
Console.WriteLine("Archivo binario escrito");

//leer archivo binario

using (BinaryReader bRead = new BinaryReader(File.Open(rutaB, FileMode.Open)))
{
    int numero = bRead.ReadInt32();
    double decimalNumero = bRead.ReadDouble();
    //string texto = bRead.ReadString();
    Console.WriteLine($"{numero}, {decimalNumero}");
}
Console.WriteLine("Archivo binario escrito");


//acceso secuancial (LINEA POR LINEa)//crear 
using (StreamWriter writer = new StreamWriter(ruta))
{
    for (int i = 0; i < 10; i++)
    {
        writer.Write("Linea: ");
        writer.WriteLine(i);
    }
}

//linea por linea lectura
using (StreamReader reader = new StreamReader(ruta))
{
    string linea;
    while ((linea = reader.ReadLine()) != null)
    {
        Console.WriteLine(linea);
    }

}

