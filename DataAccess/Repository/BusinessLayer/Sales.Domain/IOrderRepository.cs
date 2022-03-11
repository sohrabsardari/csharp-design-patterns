namespace Sales.Domain;

public interface IOrderRepository
{
    void Create(Order order);
    Order Get(long id);
    long GetNextId();
}