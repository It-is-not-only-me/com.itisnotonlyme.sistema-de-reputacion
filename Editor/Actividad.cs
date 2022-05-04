namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public class Actividad : IActividad
    {
        private ITarget _target;
        private IAccion _accion;

        public Actividad(ITarget target, IAccion accion)
        {
            _target = target;
            _accion = accion;
        }

        public void Opinion(ITarget target, IAccion accion, ref float valor)
        {
            if (_target.EsIgual(target))
                valor += _accion.Similitud(accion);
        }
    }
}
