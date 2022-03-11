namespace Sales.Application;

public interface IOrderService
{
    public long Insert(CreateOrderDto dto);
    public OrderDto Get(long id);
}