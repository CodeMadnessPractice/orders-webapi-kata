using Microsoft.AspNetCore.Mvc;

namespace OrdersWeb.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController(CreateOrderHandler createOrderHandler) : ControllerBase
{
    private CreateOrderHandler createOrderHandler = createOrderHandler;

    [HttpPost]
    public async Task<IActionResult> Post(OrderRequest givenOrderRequest)
    {
        try
        {
            var createdOrderHandler = createOrderHandler.Handle();
            return Created("", null);
        }
        catch(Exception)
        {
            return BadRequest("Patata");
        }
    }
}