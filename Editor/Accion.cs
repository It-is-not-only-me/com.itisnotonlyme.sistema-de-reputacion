using ItIsNotOnlyMe.VectorDinamico;

namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    // Se recomienda que sea un numero en el rango de -1 a 1
    public class Accion : IAccion
    {
        public Vector Valor => _valor;
        private Vector _valor;

        public Accion(Vector valor)
        {
            _valor = valor;
        }

        public float Similitud(IAccion accion)
        {
            return MathfVectores.Similitud(Valor, ((Accion)accion).Valor);
        }
    }
}
