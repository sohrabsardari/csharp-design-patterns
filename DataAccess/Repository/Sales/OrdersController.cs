using Microsoft.AspNetCore.Mvc;
using Sales.Application;
using Sales.Domain;

namespace Sales;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    /// <summary>
    /// Consider using application contract to define interfaces and dto there and
    /// reference application contracts in controllers instead of application
    /// </summary>
    private readonly IOrderService _service;
    public OrdersController(IOrderService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<long> Post(CreateOrderDto dto)
    {
        return Ok(_service.CreateAnOrder(dto));
    }

    [HttpGet("{id}")]
    public ActionResult<OrderDto> Get(long id)
    {
        return Ok(_service.GetAnOrderById(id));
    }
}