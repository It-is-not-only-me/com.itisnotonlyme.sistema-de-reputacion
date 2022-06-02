using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IEvaluacion
    {
        public float Evaluar(IAccion accion);
    }
}