using Microsoft.AspNetCore.Mvc;

namespace OrdersWeb.Api;

public class OrderController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post(OrderRequest givenOrderRequest)
    {
        return Created("", null);
    }
}