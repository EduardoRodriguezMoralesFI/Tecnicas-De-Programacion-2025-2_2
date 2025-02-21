class CuentaBancaria
{
    //atributos
    public string NumeroCuenta { get; }

    public decimal Saldo { get; set; }

    //constructor 
    public CuentaBancaria (string numeroCuenta, decimal saldo)
    {
        NumeroCuenta = numeroCuenta;
        Saldo = saldo;
    }

    //metodos 
    public void Depositar( decimal cantidad)
    {
        if (cantidad < 0)
        {
            throw new DepositoInvalidoException("No puedes depositar una cantidad negativa");
        }
        Saldo += cantidad;

    }
    
    public void Retirar ( decimal cantidad)
    {
        if (cantidad > Saldo)
        {
            throw new SaldoInsuficienteException("Saldo nsuficiente");
        }
        
        if (cantidad < 0)
        {
            throw new SaldoInsuficienteException("no se puede retirar numeros negativos");
        }
        Saldo -= cantidad;
    }

    public void Transferir (CuentaBancaria destino, decimal cantidad)
    {
        if (destino == null)
        {
            throw new CuentaNoEncontradaException("Ceunta destino no encontrada");
        }
        Retirar(cantidad);
        destino.Depositar(cantidad);

    }
   




}