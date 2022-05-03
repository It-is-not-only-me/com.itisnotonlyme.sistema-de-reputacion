namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public interface ITarget
    {
        bool EsIgual(ITarget target);
    }

    public class Target : ITarget
    {
        public bool EsIgual(ITarget target)
        {
            throw new System.NotImplementedException();
        }
    }
}
