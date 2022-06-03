using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using ItIsNotOnlyMe.SistemaDeReputacion;

public class EvaluacionTest
{
    private IOrientacion _orientacionUno, _orientacionInversa, _orientacionOrtogonal;

    public EvaluacionTest()
    {
        _orientacionUno = new OrientacionPrueba(Vector2.one);
        _orientacionInversa = new OrientacionPrueba(-Vector2.one);
        _orientacionOrtogonal = new OrientacionPrueba(new Vector2(-1, 1));
    }

    [Test]
    public void Test01EvaluacionSinPreferenciaResultaNula()
    {
        IEvaluacion evaluacion = new Evaluacion();

        IAccion accion = new Accion(_orientacionUno);

        Assert.AreEqual(0f, evaluacion.Evaluar(accion));
    }

    [Test]
    public void Test02EvaluacionConPreferenciaDeLaMismaOrientacionResultaPositiva()
    {
        IEvaluacion evaluacion = new Evaluacion();
        IPreferencia preferencia = new Preferencia(_orientacionUno);
        evaluacion.AgregarPreferencia(preferencia);

        IAccion accion = new Accion(_orientacionUno);

        Assert.Greater(evaluacion.Evaluar(accion), 0f);
    }

    [Test]
    public void Test03EvaluacionConPreferenciaDeOrientacionOpuestasResultaNegativo()
    {
        IEvaluacion evaluacion = new Evaluacion();
        IPreferencia preferencia = new Preferencia(_orientacionUno);
        evaluacion.AgregarPreferencia(preferencia);

        IAccion accion = new Accion(_orientacionInversa);

        Assert.Less(evaluacion.Evaluar(accion), 0f);
    }

    [Test]
    public void Test04EvaluacionConPreferenciaOrtogonalesResultaNula()
    {
        IEvaluacion evaluacion = new Evaluacion();
        IPreferencia preferencia = new Preferencia(_orientacionUno);
        evaluacion.AgregarPreferencia(preferencia);

        IAccion accion = new Accion(_orientacionOrtogonal);

        Assert.AreEqual(evaluacion.Evaluar(accion), 0f);
    }

    [Test]
    public void Test05EvaluacionConDosPrefereciaOpuestasAUnaMismaAccionResultaNula()
    {
        IEvaluacion evaluacion = new Evaluacion();
        evaluacion.AgregarPreferencia(new Preferencia(_orientacionUno));
        evaluacion.AgregarPreferencia(new Preferencia(_orientacionInversa));

        IAccion accion = new Accion(_orientacionUno);

        Assert.AreEqual(evaluacion.Evaluar(accion), 0f);
    }

    [Test]
    public void Test05EvaluacionConMasPreferenciaAFavorQueInversasResultaPositiva()
    {
        IEvaluacion evaluacion = new Evaluacion();
        evaluacion.AgregarPreferencia(new Preferencia(_orientacionUno));
        evaluacion.AgregarPreferencia(new Preferencia(_orientacionUno));
        evaluacion.AgregarPreferencia(new Preferencia(_orientacionInversa));

        IAccion accion = new Accion(_orientacionUno);

        Assert.Greater(evaluacion.Evaluar(accion), 0f);
    }
}
