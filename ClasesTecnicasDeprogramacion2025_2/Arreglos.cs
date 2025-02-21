class Banco
{
    //atributos 
    private CuentaBancaria[] cuentas;

    //constructor 
    public Banco() 
    {
        cuentas = new CuentaBancaria[]
        {
            new CuentaBancaria("12345",100),
            new CuentaBancaria("67890",500),


        };
    }

    //metodo
    public CuentaBancaria buscarCuenta(String numeroCuenta)
    {
        foreach ( CuentaBancaria cuenta in cuentas)
        {
            if(cuenta.NumeroCuenta == numeroCuenta)
            {
                return cuenta;
            }
            
        }
        return null;
    }

}