using ItIsNotOnlyMe.VectorDinamico;

public class IdentificadorPrueba : IIdentificador
{
    private static int _contador = 0;
    private int _id;

    public IdentificadorPrueba()
    {
        _id = _contador;
        _contador++;
    }

    public int GetID()
    {
        return _id;
    }

    public bool EsIgual(IIdentificador identificador)
    {
        return GetID() == identificador.GetID();
    }
}
