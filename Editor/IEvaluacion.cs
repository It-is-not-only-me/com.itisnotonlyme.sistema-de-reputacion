namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IEvaluacion
    {
        public float Evaluar(IAccion accion);

        public void AgregarPreferencia(IPreferencia preferencia);

        public void SacarPreferencia(IPreferencia preferencia);
    }
}