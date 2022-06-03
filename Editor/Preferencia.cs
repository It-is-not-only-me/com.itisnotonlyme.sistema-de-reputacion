namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public class Preferencia : IPreferencia
    {
        private IOrientacion _orientacion;

        public Preferencia(IOrientacion orientacion)
        {
            _orientacion = orientacion;
        }

        public float Alineacion(IAccion accion)
        {
            return accion.Alineacion(_orientacion);
        }

        public float Alineacion(IOrientacion orientacion)
        {
            return _orientacion.Alineacion(orientacion);
        }
    }
}