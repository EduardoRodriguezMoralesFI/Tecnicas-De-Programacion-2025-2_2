
// Estrategia de evaluación basada en victorias de equipo--------------------------
class EvaluacionPorVictorias : IEstrategiaEvaluacion
{
    public int ObtenerValor(Atleta atleta)
    {
        return atleta.VictoriasEquipo;
    }
}
/////////////////////////////