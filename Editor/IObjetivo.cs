using System.Collections.Generic;

namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IObjetivo
    {
        public void Opinion(List<IActividad> actividades, ref float valor);
    }
}
