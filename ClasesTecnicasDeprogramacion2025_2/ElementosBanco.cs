class SaldoInsuficienteException :Exception
{
    public SaldoInsuficienteException( string message ) : base( message ) { }


}
class CuentaNoEncontradaException : Exception
{
    public CuentaNoEncontradaException(string message) : base(message) { }

}

class DepositoInvalidoException : Exception
{
    public DepositoInvalidoException(string message) : base(message) { }

}
