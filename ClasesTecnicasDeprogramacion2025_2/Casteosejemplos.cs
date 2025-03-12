//Casteos

//Conversion implicita 

int numeroEntero = 42;
double numeroDouble = numeroEntero;

Console.WriteLine(numeroEntero);
Console.WriteLine(numeroDouble);

//conversion explicita 

double numeroDecimal = 42.96;
int numeroEntero2 = (int)numeroDecimal;

Console.WriteLine(numeroDecimal);
Console.WriteLine(numeroEntero2);

//Convert

string numeroTexto = "23";
string sumaTexto = "1" + numeroTexto;
int numero = Convert.ToInt32(numeroTexto);
int suma = 1 + numero;
Console.WriteLine(numero);
Console.WriteLine(suma);
Console.WriteLine(sumaTexto);

//Parse solo se utiliza para estrings

string texto = "3.1416";
double pi = double.Parse(texto);
Console.WriteLine(pi);
Console.WriteLine(pi * 2);


//Parse que evita excepciones
int piEntero;
bool exito = int.TryParse(texto, out piEntero);
Console.WriteLine(exito);
Console.WriteLine(piEntero);

//casteo de objetos 

//downCasting Padre > hijo

Animal miAnimal = new Perro(); //siempre y cuando haya espacio

//UpCasting  o HigCasting hijo > Padre conversion explicita

Animal otroAnimal = new Animal();
Perro miPerro = (Perro)miAnimal;

//Conversiones por tipos de referencia  object-->objeto generico /////objeto a cadena

object obj = "Hola mundo";

string texto2 = obj as string;

Console.WriteLine(texto2);

