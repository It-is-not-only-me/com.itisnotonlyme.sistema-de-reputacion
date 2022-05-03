namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IAccion
    {
        float Similitud(IAccion accion);
    }

    // Debe ser un numero en el rango de -1 a 1
    public class Accion : IAccion
    {
        public float Similitud(IAccion accion)
        {
            throw new System.NotImplementedException();
        }
    }
}
