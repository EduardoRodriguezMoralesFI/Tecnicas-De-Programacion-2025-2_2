/* CORREIGOOOOOO
namespace RobotLibrary
{ 
    public class Robot
    {
        public float Peso { get; set; }
        public string Modelo { get; set; }
        public bool Estado { get; set; }
        public int EnergiaDisponible { get; set; }

        //constructor
        public Robot(string modelo,float peso,int energia)
        {
            Peso = peso;
            Modelo = modelo;
            Estado = false;
            EnergiaDisponible = energia;
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
    //--------------------

    public class RobotMovil : Robot
    {
        //Propiedades
        public float Velocidad { get; set; }
        public string Direccion { get; set; }
        public int MotorIzquierdo { get; set; }
        public int MotorDerecho { get; set; }
        public bool SensorUltraSonico { get; set; }

        //Constructor
        public RobotMovil(string modelo,float peso, int energia) : base(modelo, peso, energia)
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

        public void Mover(float velocidad, string direccion)
        {
            Velocidad = velocidad;
            Direccion = direccion;
            Console.WriteLine($"Moviendo robot hacia {direccion} a {velocidad}");
        }

        public void Detener()
        {
            Velocidad = 0.0f;
            Direccion = "Detenido";
            Console.WriteLine("El robot detenido");
        }

        public void GiroPorDiferemcia(string direccion)
        {
            if (direccion == "Derecha")
            {
                MotorDerecho = 0;
                MotorIzquierdo = 50;
            }
            else if (direccion == "Izquierdo")
            {
                MotorDerecho = 50;
                MotorIzquierdo = 0;
            }

            Console.WriteLine($"Girando por diferencia hacia {direccion}");

        }

        public void GiroPorContrarrotacion(string direccion)
        {
            if (direccion == "Derecha")
            {
                MotorDerecho = -50;
                MotorIzquierdo = 50;
            }
            else if (direccion == "Izquierdo")
            {
                MotorDerecho = 50;
                MotorIzquierdo = -50;
            }

            Console.WriteLine($"Girando por Contrarrotacion hacia {direccion}");

        }

        public void ObtenerDistanciaSensor()
        {
            Random random = new Random();
            int distancia = random.Next(10, 100);
            Console.WriteLine($"Distancia medida por el sensor ultrasonido es de: {distancia}");
        }

        public void ConsumirEnergia(int cantidad)
        {
            if (EnergiaDisponible <= 100 && EnergiaDisponible > 0 && EnergiaDisponible >= cantidad)
            {
                EnergiaDisponible -= cantidad;
                Console.WriteLine($"Energia disponible{EnergiaDisponible}");
            }
            else
            {
                Console.WriteLine($"Energia insuficiente{EnergiaDisponible}, regara necesaria");
            }
        }

        public void AumentarVelocidad(int incremento)
        {
            if (Velocidad + incremento <= 100)
            {
                Velocidad += incremento;
                Console.WriteLine($"Velocidad aumentada a {Velocidad} cm/s");
            }
            else
            {
                Console.WriteLine("Velocidad maxica implementa el programa de pago");
            }
        }

        public void ReducirVelocidad(int decremento)
        {
            if (Velocidad - decremento > 0)
            {
                Velocidad -= decremento;
                Console.WriteLine($"Velocidad disminuida  a {Velocidad} cm/s");
            }
            else
            {
                Console.WriteLine("Velocidad negativa");
            }

        }

    }
}
*/