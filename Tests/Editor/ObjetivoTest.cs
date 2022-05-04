using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using ItIsNotOnlyMe.SistemaDeReputacion;
using ItIsNotOnlyMe.VectorDinamico;

public class ObjetivoTest
{
    private IIdentificador _x = new IdentificadorPrueba();

    private Vector CrearVector(float valor)
    {
        return new Vector(new Componente(_x, valor));
    }

    [Test]
    public void Test01ObjetivoSinActividadesTieneOpinionNula()
    {
        ITarget target = new Target(1);
        IAccion accion = new Accion(CrearVector(1));
        IObjetivo objetivo = new Objetivo(target, accion);

        float opinion = 0;

        objetivo.Opinion(new List<IActividad>(), ref opinion);

        Assert.AreEqual(0, opinion);
    }

    [Test]
    public void Test02ObjetivoConActividadOpuestaTieneOpinionNegativa()
    {
        ITarget target = new Target(1);
        IAccion accion = new Accion(CrearVector(1));
        IObjetivo objetivo = new Objetivo(target, accion);

        IAccion accionOpuesta = new Accion(CrearVector(-1));
        IActividad actividad = new Actividad(target, accionOpuesta);

        List<IActividad> actividades = new List<IActividad> { actividad };
        float opinion = 0;

        objetivo.Opinion(actividades, ref opinion);

        Assert.Less(opinion, 0);
    }

    [Test]
    public void Test03ObjetivoConActividadFavoritariaTieneOpinionPositiva()
    {
        ITarget target = new Target(1);
        IAccion accion = new Accion(CrearVector(1));
        IObjetivo objetivo = new Objetivo(target, accion);

        IActividad actividad = new Actividad(target, accion);

        List<IActividad> actividades = new List<IActividad> { actividad };
        float opinion = 0;

        objetivo.Opinion(actividades, ref opinion);

        Assert.Greater(opinion, 0);
    }

    [Test]
    public void Test03ObjetivoConActividadDeTargetDiferentesTieneOpinionNula()
    {
        ITarget target = new Target(1);
        IAccion accion = new Accion(CrearVector(1));
        IObjetivo objetivo = new Objetivo(target, accion);

        ITarget targetDiferente = new Target(2);
        IActividad actividad = new Actividad(targetDiferente, accion);

        List<IActividad> actividades = new List<IActividad> { actividad };
        float opinion = 0;

        objetivo.Opinion(actividades, ref opinion);

        Assert.AreEqual(0, opinion);
    }
}
