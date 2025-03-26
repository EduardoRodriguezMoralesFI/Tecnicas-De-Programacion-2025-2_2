using System.Timers;

public class Robot
{
    public float Peso { get; set; }
    public string Modelo { get; set; }
    public bool Estado { get; set; }
    public int EnergiaDisponible { get; set; }

    //constructor
    public Robot(float peso, string modelo, bool estado, int energiaDisponible)
    {
        Peso = peso;
        Modelo = modelo;
        Estado = estado;
        EnergiaDisponible = energiaDisponible;
    }
    //constructor 2
    public Robot()
    {
        Peso = 5.0f;
        Modelo = "Robot Generico";
        Estado = false;
        EnergiaDisponible = 100;
    }

    //metodos
    public virtual void Encender()
    {
        if (!Estado) 
        {
            Estado = true;
            Console.WriteLine($"El robot: {Modelo}  ha sido encendido");
        }
        else
        {
            Console.WriteLine("El robot ya esta encendido");
        }
    }

    public virtual void Apagar()
    {
        if (Estado)
        {
            Estado = false;
            Console.WriteLine($"El robot: {Modelo} ha sido apagado");
        }
        else
        {
            Console.WriteLine("El robot ya esta apagado");

        }
    }

    public virtual int VerificarEnergia()
    {
        Console.WriteLine("La energia disponible es de: % " + EnergiaDisponible);
        return EnergiaDisponible;
    }

    public virtual void RecargarEnergia(int cantidad)
    {
        EnergiaDisponible = Math.Min(EnergiaDisponible + cantidad, 100);//retorna la cantidad menor entre dos valores
        
    }

    public virtual void MostarEstado()
    {
        Console.WriteLine($"Energia disponible: {EnergiaDisponible}, y Estado:{Estado}");
    }

    public virtual void MostarInformacio()
    {
        Console.WriteLine($"El Robot es de Modelo: {Modelo}, y peso de:{Peso}");
    }
}

class RobotMovil : Robot
{
    //Propiedades
    public float Velocidad { get; set; }
    public string Direccion { get; set; }
    public int MotorIzquierdo { get; set; }
    public int MotorDerecho { get; set; }
    public bool SensorUltraSonico { get; set; }

    //Constructor
    public RobotMovil(float peso, string modelo, bool estado, int energiaDisponible, int motorIzquierdo, int motorDerecho):base(peso, modelo, estado, energiaDisponible)
    {
        Velocidad = 0.0f;
        Direccion = "detenido";
        SensorUltraSonico = true;
    }

    //Metodos
    public override void Encender()
    {
        base.Encender();
        SensorUltraSonico = true;
        Console.WriteLine("El robot movil esta encendido");
    }
    public override void Apagar()
    {
        base.Apagar();
        SensorUltraSonico = false;
    }

    public override int VerificarEnergia()
    {
        int energia = base.VerificarEnergia();  
        //Console.WriteLine($"---->La energia disponible del robot movil es : {EnergiaDisponible}<---- " );
        return energia;
    }
    //----------------------
    public override void RecargarEnergia(int cantidad)
    {
        EnergiaDisponible = Math.Min(EnergiaDisponible + cantidad, 100);//retorna la cantidad menor entre dos valores
        base.RecargarEnergia(cantidad);
        Console.WriteLine($"La energia recargada,nuevo porcentaje: {EnergiaDisponible}");
    }

    public override void MostarEstado()
    {
        base.MostarEstado();
        Console.WriteLine($"Sensor: {SensorUltraSonico}, Motor Izq: {MotorIzquierdo}, Motor Der {MotorDerecho}");
    }

    public override void MostarInformacio()
    {
        base.MostarInformacio();
        Console.WriteLine($"Velocidad: {Velocidad}, Direccion:{Direccion}");
    }


}