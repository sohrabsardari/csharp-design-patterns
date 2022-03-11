using Sales.Domain;

namespace Sales.DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        private static readonly List<Order> _inMemoryDatabase = new List<Order>();
        public void Create(Order order)
        {
            _inMemoryDatabase.Add(order);
        }

        public Order Get(long id)
        {
            return _inMemoryDatabase.FirstOrDefault(a => a.Id == id);
        }

        public long GetNextId()
        {
            return new Random().NextInt64();
        }

    }
}