using System.Collections.Generic;

namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public class Persona : IPersona
    {
        private List<IObjetivo> _objetivos;

        public Persona()
        {
            _objetivos = new List<IObjetivo>();
        }

        public void AgregarObjetivo(IObjetivo objetivo)
        {
            _objetivos.Add(objetivo);
        }

        public float Opinion(List<IActividad> actividades)
        {
            float resultadoFinal = 0;

            foreach (IObjetivo objetivo in _objetivos)
                objetivo.Opinion(actividades, ref resultadoFinal);

            return resultadoFinal;
        }
    }
}
