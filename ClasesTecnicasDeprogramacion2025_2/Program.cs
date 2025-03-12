//Lista de pagos a procesar 
List<IPago> ListaPagos = new List<IPago>();

bool numerodepagos = false;

do
{
    Console.WriteLine("Desea realizar un pago?? y/n");
    string opcion0 = Console.ReadLine() ?? "";
    if (opcion0 == "y")
    {
        Console.WriteLine("Ingrese el monto a pagar");
        string montoTexto = Console.ReadLine() ?? "";

        //Conveirte string a double

        double montoNumero;

        if (double.TryParse(montoTexto, out montoNumero))
        {
            Console.WriteLine("¿Es pago con tarjeta? y/n: ");

            string opcion = Console.ReadLine() ?? "";

            if (opcion == "y")
            {
                Console.WriteLine("Ingresa el numero de tarjeta: ");

                string tarjeta = Console.ReadLine() ?? "";

                //Crear objeto

                IPago pago = new PagoTarjeta(montoNumero, tarjeta);

                ListaPagos.Add(pago);
            }

            else
            {

                //Objeto pago en efectivo

                IPago pago = new PagoEfectivo(montoNumero);
                ListaPagos.Add(pago);
            }

        }
        else
        {
            Console.WriteLine("Monto invalid, ocurrio un error");
            return;
        }


    }
    else
    {
        Console.WriteLine("---------Enviando pagos . . . ");
        numerodepagos = true;
    }


} while (numerodepagos != true);

/*
Console.WriteLine("Ingrese el monto a pagar");
string montoTexto = Console.ReadLine()??"";

//Conveirte string a double

double montoNumero;

if (double.TryParse(montoTexto, out montoNumero))
{
    Console.WriteLine("¿Es pago con tarjeta? y/n: ");

    string opcion = Console.ReadLine() ?? "";

    if(opcion == "y")
    {
        Console.WriteLine("Ingresa el numero de tarjeta: ");

        string tarjeta = Console.ReadLine() ?? "";

        //Crear objeto

        IPago pago = new PagoTarjeta(montoNumero, tarjeta);

        ListaPagos.Add(pago);
    }

    else
    {

        //Objeto pago en efectivo

        IPago pago = new PagoEfectivo(montoNumero);
        ListaPagos.Add(pago);
    }

}

else
{
    Console.WriteLine("Monto invalid, ocurrio un error");
    return;
}
*/
Console.WriteLine("---------Procesando pagos . . . ");

//recorrer la lista de pagos 

foreach (IPago pago in ListaPagos)
{
    //Casteo con AS

    PagoTarjeta pagotarjeta = pago as PagoTarjeta;

    if (pagotarjeta != null)
    {
        Console.WriteLine("Verificando tarjeta . . .");
        pago.ProcesarPago();
    }
    else
    {
        pago.ProcesarPago();
    }

}

