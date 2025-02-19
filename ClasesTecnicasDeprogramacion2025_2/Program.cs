// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! 8:35pm");

Romantico juan = new Romantico("Juan", 25);
Amistoso pedro = new Amistoso("Pedron", 30);
Indiferente maria = new Indiferente("Maria", 20);
Romantico ana = new Romantico("Ana", 22);
Romantico paquita = new Romantico("Paquita", 26);


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

Persona pareja1 = juan + pedro;
Persona pareja2 = juan + ana;
Console.WriteLine("-------------");
Persona pareja3 = pareja1 + pareja2;



//Compara pareja 
/*
Console.WriteLine($"Nueva pareja formada: {pareja1.Nombre} con edad pronedio : {pareja1.Edad}");
Console.WriteLine($"Nueva pareja formada: {pareja2.Nombre} con edad pronedio : {pareja2.Edad}");

*/
