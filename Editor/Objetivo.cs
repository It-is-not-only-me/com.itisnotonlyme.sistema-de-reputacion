using System.Collections.Generic;

namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public class Objetivo : IObjetivo
    {
        private ITarget _target;
        private IAccion _accion;

        public Objetivo(ITarget target, IAccion accion)
        {
            _target = target;
            _accion = accion;
        }

        public void Opinion(List<IActividad> actividades, ref float valor)
        {
            float opinionTotal = 0;
            foreach (IActividad actividad in actividades)
                actividad.Opinion(_target, _accion, ref opinionTotal);
            valor += opinionTotal;
        }
    }
}
