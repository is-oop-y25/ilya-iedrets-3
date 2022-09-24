namespace Shops.Entities
{
    internal class Buyer : EntityBase
    {
        public Buyer(Guid id)
            : base(id)
        {
        }

        public string Name { get; }

        public decimal Money { get; }
    }
}
