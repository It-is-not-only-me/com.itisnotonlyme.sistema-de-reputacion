namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IPreferencia
    {
        public float Alineacion(IAccion accion);

        public float Alineacion(IOrientacion orientacion);
    }
}