namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IAccion
    {
        float Similitud(IAccion accion);
    }

    public class Accion : IAccion
    {
        public float Similitud(IAccion accion)
        {
            throw new System.NotImplementedException();
        }
    }
}
