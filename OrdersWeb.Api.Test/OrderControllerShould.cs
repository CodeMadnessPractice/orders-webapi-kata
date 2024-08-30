using System.Net;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace OrdersWeb.Api.Test
{
    public class OrderControllerShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task call_create_order_handler_when_request_is_valid()
        {
            //given
            var orderController = new OrderController();
            var givenOrderRequest = new OrderRequest();

            //when
            async Task<IActionResult> result () => await orderController.Post(givenOrderRequest);

            //then
            result().Result.Should().Be(HttpStatusCode.Created);

        }
        public void not_call_create_order_handler_when_request_is_invalid()
        {
            //given

            //when

            //then

        }
    }

    public class OrderRequest
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }

    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class OrderController
    {
        [HttpPost]
        public async Task<IActionResult> Post(OrderRequest givenOrderRequest)
        {
            throw new NotImplementedException();
        }
    }
}