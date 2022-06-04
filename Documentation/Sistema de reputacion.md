# Organizacion

Se tiene las 4 interfaces
 * IEvaluacion
 * IAccion
 * IPreferencia
 * IOrientacion

De las cuales las primeras 3 se tiene clases de ejemplo que deberian funcionar en los casos mas habituales. 

## IOrientacion
Esta interfaz es la principal para este proyecto, es la que realmente cuantifica las relaciones entre acciones. La idea principal para esto es usarlo con vectores de n dimensiones y la cuantificacion siendo un producto punto entre ellos. 

Por ejemplo:
---
```
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
```c

El resto de las interfaces ya tienen una clase asociada, pero la idea es muy simple e intentan dar espacio a la utilizacion de IOrientacion. 

