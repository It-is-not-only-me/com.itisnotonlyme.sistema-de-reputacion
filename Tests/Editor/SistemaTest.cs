using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using ItIsNotOnlyMe.SistemaDeReputacion;

public class SistemaTest
{
    private class EvaluacionPrueba : IEvaluacion
    {
        public float Evaluar(IAccion accion)
        {
            throw new System.NotImplementedException();
        }
    }

    private class AccionPrueba : IAccion
    {

    }


    [Test]
    public void SistemaTestSimplePasses()
    {
        IEvaluacion evaluacion;

        IAccion accion;


    }
}
