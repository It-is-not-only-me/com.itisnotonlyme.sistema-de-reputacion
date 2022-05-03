using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface IPersona
    {
        float Opinion(List<IActividad> actividades);
    }

    public class Persona : IPersona
    {
        public float Opinion(List<IActividad> actividades)
        {
            throw new System.NotImplementedException();
        }
    }
}
