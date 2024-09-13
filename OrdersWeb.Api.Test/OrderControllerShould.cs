using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using OrdersWeb.Api.Controllers;

namespace OrdersWeb.Api.Test
{
    public class OrderControllerShould
    {
        private CreateOrderHandler createOrderHandler = Substitute.For<CreateOrderHandler>();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task call_create_order_handler_when_request_is_valid()
        {
            //given
            createOrderHandler.Handle().Returns(null);
            var orderController = new OrderController();
            var givenOrderRequest = new OrderRequest();

            //when
            var result = await orderController.Post(givenOrderRequest);

            //then
            result.Should().BeOfType(typeof(CreatedResult));

        }
        public void not_call_create_order_handler_when_request_is_invalid()
        {
            //given

            //when

            //then

        }
    }
}