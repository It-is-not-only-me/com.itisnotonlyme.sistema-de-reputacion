using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IEvaluacion
    {
        public float Evaluar(IAccion accion);

        public void AgregarPreferencia(IPreferencia preferencia);

        public void SacarPreferencia(IPreferencia preferencia);
    }

    public class Evaluacion : IEvaluacion
    {
        private List<IPreferencia> _preferencias;

        public Evaluacion()
        {
            _preferencias = new List<IPreferencia>();
        }

        public void AgregarPreferencia(IPreferencia preferencia)
        {
            _preferencias.Add(preferencia);
        }

        public void SacarPreferencia(IPreferencia preferencia)
        {
            _preferencias.Remove(preferencia);
        }

        public float Evaluar(IAccion accion)
        {
            float resultado = 0;
            foreach (IPreferencia preferencia in _preferencias)
                resultado += preferencia.Alineacion(accion);
            return resultado;
        }
    }
}