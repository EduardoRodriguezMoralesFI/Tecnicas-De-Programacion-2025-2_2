using System.Timers;

class PagoTarjeta: IPago
{
    //Propiedades 
    double Monto {  get; set; }
    string NumeroDeTarjeta { get; }

    //Constructor 
    public PagoTarjeta(double monto, string numerodetarjeta)
    {
        Monto = monto;
        NumeroDeTarjeta = numerodetarjeta;

    }

    //Atributos 
    public void ProcesarPago()
    {
        if (NumeroDeTarjeta.Length == 16)
        {
            Console.WriteLine($"Pago con tarjeta por : {Monto}, fue procesado");
        }
        else
        {
            Console.WriteLine("Tarjeta invalida, pago no procesado");
        }

    }



}
