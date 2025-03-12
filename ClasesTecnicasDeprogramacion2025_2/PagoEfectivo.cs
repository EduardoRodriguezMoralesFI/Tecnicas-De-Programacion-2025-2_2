class PagoEfectivo: IPago
{
    //propiedades 
    public double Monto { get; set; }
    //Constrcutores 
    public  PagoEfectivo(double monto)
    {
        Monto = monto;
    }

    //Metodos
    public void ProcesarPago()
    {
        Console.WriteLine($"Pago en efectivo: {Monto}, fue procesado");
    }

}