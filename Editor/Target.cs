namespace ItIsNotOnlyMe.SistemaDeReputacion
{
    public class Target : ITarget
    {
        public int ID => _id;
        private int _id;

        public Target (int id)
        {
            _id = id;
        }

        public bool EsIgual(ITarget target)
        {
            return ID == ((Target)target).ID;
        }
    }
}
