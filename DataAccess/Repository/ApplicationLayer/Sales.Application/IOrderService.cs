namespace Sales.Application;

public interface IOrderService
{
    public long CreateAnOrder(CreateOrderDto dto);
    public OrderDto GetAnOrderById(long id);
}