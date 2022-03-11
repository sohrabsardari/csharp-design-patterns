using Microsoft.AspNetCore.Mvc;
using Sales.Application;
using Sales.Domain;

namespace Sales;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _service;
    public OrdersController(IOrderService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<long> Post(CreateOrderDto dto)
    {
        return Ok(_service.Insert(dto));
    }

    [HttpGet("{id}")]
    public ActionResult<OrderDto> Get(long id)
    {
        return Ok(_service.Get(id));
    }
}