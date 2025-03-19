// Estrategia de evaluación basada en primeros lugares individuales-----------------------------------
class EvaluacionPorPrimerosLugares : IEstrategiaEvaluacion
{
    public int ObtenerValor(Atleta atleta)
    {
        return atleta.PrimerosLugares;
    }
}