using System.Collections.Generic;

namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IObjetivo
    {
        void Opinion(List<IActividad> actividades, ref float valor);
    }

    public class Objetivo : IObjetivo
    {
        public void Opinion(List<IActividad> actividades, ref float valor)
        {
            throw new System.NotImplementedException();
        }
    }
}
