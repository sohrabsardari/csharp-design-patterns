using Sales.Domain;

namespace Sales.Application
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }


        public long Insert(CreateOrderDto dto)
        {
            var id = _repository.GetNextId();
            var order = new Order(id, dto.Note);

            _repository.Create(order);
            return id;
        }

        public OrderDto Get(long id)
        {
            var order = _repository.Get(id);
            return new OrderDto()
            {
                Id = order.Id,
                IssueDate = order.IssueDate.ToString("s"),
                Note = order.Note
            };
        }
    }
}