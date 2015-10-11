using System.Collections.Generic;

namespace Chapter2
{
    class Order : IEntity
    {
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        // more code ralated with Order entity
    }

    class OrderRepository : Repository<Order>
    {
        public OrderRepository(IEnumerable<Order> orders) : base(orders) { }

        public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
        {
            List<Order> result = null;
            // filtering process here
            return result;
        }
    }
}