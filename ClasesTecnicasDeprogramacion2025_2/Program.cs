// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! 8:35pm");

Romantico juan = new Romantico("Juan", 25);
Amistoso pedro = new Amistoso("Pedro", 25);
Indiferente maria = new Indiferente("Maria", 20);
Romantico ana = new Romantico("Ana", 22);
Romantico paquita = new Romantico("Paquita", 26);
Indiferente roberto = new Indiferente("Roberto",30);


juan.MostrarInteres();
pedro.MostrarInteres();
maria.MostrarInteres();
ana.MostrarInteres();
paquita.MostrarInteres();
juan.ExpresarSentimientoss();
pedro.ExpresarSentimientoss();
maria.ExpresarSentimientoss();
ana.ExpresarSentimientoss();
paquita.ExpresarSentimientoss();

//Formar parejas 
Console.WriteLine("----Formar parejas-----");

Persona pareja1 = maria + pedro;
Persona pareja2 = juan + ana;
Console.WriteLine("-----Poliamor");

Persona trio = pareja2.CupidoCumplido(juan, ana, paquita);
Console.WriteLine($"Los nombres del poliamor son {trio.Nombre}, su promedio de edad es {trio.Edad}");
Persona triof = pareja1.CupidoCumplido(maria, pedro, roberto);
Console.WriteLine($"Los nombres del poliamor fallido son {triof.Nombre}, su promedio de edad es {triof.Edad}");
