using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItIsNotOnlyMe.SistemaDeReputacion;

public class OrientacionPrueba : IOrientacion
{
    private Vector2 _orientacion;

    public OrientacionPrueba(Vector2 orientacion)
    {
        _orientacion = orientacion;
    }

    public float Alineacion(IOrientacion orientacion)
    {
        OrientacionPrueba nuevaOrientacion = orientacion as OrientacionPrueba;
        return Vector2.Dot(_orientacion, nuevaOrientacion._orientacion);
    }
}