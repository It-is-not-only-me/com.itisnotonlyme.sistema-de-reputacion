using System.Collections.Generic;

namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IPersona
    {
        public float Opinion(List<IActividad> actividades);

        public void AgregarObjetivo(IObjetivo objetivo);
    }
}
