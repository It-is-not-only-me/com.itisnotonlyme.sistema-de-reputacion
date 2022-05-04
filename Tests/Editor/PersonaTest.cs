using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using ItIsNotOnlyMe.SistemaDeReputacion;
using ItIsNotOnlyMe.VectorDinamico;

public class PersonaTest
{
    private IIdentificador _x = new IdentificadorPrueba();

    private Vector CrearVector(float valor)
    {
        return new Vector(new Componente(_x, valor));
    }

    private Objetivo CrearObjetivo(int id, float valor)
    {
        return new Objetivo(new Target(id), new Accion(CrearVector(valor)));
    }

    private Actividad CrearActividad(int id, float valor)
    {
        return new Actividad(new Target(id), new Accion(CrearVector(valor)));
    }

    [Test]
    public void Test01PersonaSinActividadesTieneOpinionNula()
    {
        IPersona persona = new Persona();

        float opinion = persona.Opinion(new List<IActividad>());

        Assert.AreEqual(0, opinion);
    }

    [Test]
    public void Test02PersonaConUnObjetivoPeroSinActividadesTieneOpinionNula()
    {
        IPersona persona = new Persona();

        int id = 1;
        float valor = 1;
        IObjetivo objetivo = CrearObjetivo(id, valor);

        persona.AgregarObjetivo(objetivo);

        float opinion = persona.Opinion(new List<IActividad>());

        Assert.AreEqual(0, opinion);
    }

    [Test]
    public void Test03PersonaConUnObjetivoYUnaActividadPositivaTieneOpinionPositiva()
    {
        IPersona persona = new Persona();

        int id = 1;
        float valor = 1, valorActividad = 1;
        IObjetivo objetivo = CrearObjetivo(id, valor);

        persona.AgregarObjetivo(objetivo);

        IActividad actividad = CrearActividad(id, valorActividad);
        List<IActividad> actividades = new List<IActividad> { actividad };

        float opinion = persona.Opinion(actividades);

        Assert.Greater(opinion, 0);
    }

    [Test]
    public void Test04PersonaConUnObjetivoYUnaActividadNegativaTieneOpinionNegativa()
    {
        IPersona persona = new Persona();

        int id = 1;
        float valor = 1, valorActividad = -1;
        IObjetivo objetivo = CrearObjetivo(id, valor);

        persona.AgregarObjetivo(objetivo);

        IActividad actividad = CrearActividad(id, valorActividad);
        List<IActividad> actividades = new List<IActividad> { actividad };

        float opinion = persona.Opinion(actividades);

        Assert.Less(opinion, 0);
    }

    [Test]
    public void Test05PersonaConUnObjetivoPeroConActividadesNoRelacionadaTieneOpinionNula()
    {
        IPersona persona = new Persona();

        int id = 1, idActividad = 2;
        float valor = 1, valorActividad = -1;
        IObjetivo objetivo = CrearObjetivo(id, valor);

        persona.AgregarObjetivo(objetivo);

        IActividad actividad = CrearActividad(idActividad, valorActividad);
        List<IActividad> actividades = new List<IActividad> { actividad };

        float opinion = persona.Opinion(actividades);

        Assert.AreEqual(0, opinion);
    }
}
