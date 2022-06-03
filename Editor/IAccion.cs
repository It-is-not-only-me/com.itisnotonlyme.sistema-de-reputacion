namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IAccion
    {
        public float Alineacion(IPreferencia preferencia);

        public float Alineacion(IOrientacion orientacion);
    }

    public class Accion : IAccion
    {
        private IOrientacion _orientacion;

        public Accion(IOrientacion orientacion)
        {
            _orientacion = orientacion;
        }

        public float Alineacion(IPreferencia preferencia)
        {
            return preferencia.Alineacion(_orientacion);
        }

        public float Alineacion(IOrientacion orientacion)
        {
            return _orientacion.Alineacion(orientacion);
        }
    }
}