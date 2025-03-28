/*Practica 1 act 3*/
using RobotLibrary;
RobotMovil miRobotMovil = new RobotMovil("Arduino", 1.5f,100);

bool ejecutando = true;

while (ejecutando)
{
    Console.WriteLine("Comandos disponibles: ");
    Console.WriteLine("[1] encener robot");
    Console.WriteLine("[2] apagar robot");
    Console.WriteLine("[3] mostar estado");
    Console.WriteLine("[4] verificar energia");
    Console.WriteLine("[5] recargar energia");
    Console.WriteLine("[6] mover adelante");
    Console.WriteLine("[7] mover hacia atras");
    Console.WriteLine("[8] giro por difrencia");
    Console.WriteLine("[9] giro por contra");
    Console.WriteLine("[10] medir dista");
    Console.WriteLine("[11] aumentar velo");
    Console.WriteLine("[12] reduvelocidad");
    Console.WriteLine("[0] salir ");

    int opcion = int.Parse(Console.ReadLine()??"");
    switch (opcion)
    {
        case 1:
            miRobotMovil.Encender();
            break;
        case 2:
            miRobotMovil.Apagar();
            break;
        case 3:
            miRobotMovil.MostarEstado();
            break;
        case 4:
            miRobotMovil.VerificarEnergia();
            break;
        case 5:
            Console.WriteLine("Ingrese la cantidad de energia a recargar");
            int cantidad;
            if(int.TryParse(Console.ReadLine(), out cantidad))
              {
                miRobotMovil.RecargarEnergia(cantidad);
              }
            else
            {
                Console.WriteLine("Entrada de energia invalida");
            }
            break;
        case 6:
            if (miRobotMovil.Estado)
            {
                miRobotMovil.Mover(miRobotMovil.Velocidad,"Adelane");
                miRobotMovil.ConsumirEnergia(5);
            }
            else
            {
                Console.WriteLine("Robot apagado");
            }
            break;
        case 7:
            if (miRobotMovil.Estado)
            {
                miRobotMovil.Mover(miRobotMovil.Velocidad, "Atras");
                miRobotMovil.ConsumirEnergia(5);
            }
            else
            {
                Console.WriteLine("Robot apagado");
            }
            break;
        case 8:
            if (miRobotMovil.Estado)
            {
                Console.WriteLine("INgresa la direccion de giro por diferencia");
                string direccion = Console.ReadLine()??"";
                miRobotMovil.GiroPorDiferemcia(direccion);

            }
            break;
        case 9:
            break;
        case 10:
            break;
        case 11:
            break;
        case 12:
            break;
        case 0:
            break;

    }


}