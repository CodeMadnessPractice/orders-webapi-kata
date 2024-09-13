using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using OrdersWeb.Api.Controllers;

namespace OrdersWeb.Api.Test
{
    public class OrderControllerShould
    {
        private CreateOrderHandler createOrderHandler;
        private OrderController orderController;

        [SetUp]
        public void Setup()
        {
            createOrderHandler = Substitute.For<CreateOrderHandler>();

            orderController = new OrderController(createOrderHandler);
        }

        [Test]
        public async Task returns_ok_when_request_is_valid()
        {
            //given
            var givenOrderRequest = new OrderRequest();

            //when
            createOrderHandler.Handle().Returns(1);
            var result = await orderController.Post(givenOrderRequest);

            //then
            result.Should().BeOfType(typeof(CreatedResult));

        }

        [Test]
        public async Task returns_error_when_request_is_invalid()
        {
            //given
            var givenInvalidOrderRequest = new OrderRequest();

            //when
            createOrderHandler.Handle().Throws(new Exception());
            var result = await orderController.Post(givenInvalidOrderRequest);
            
            //then
            result.Should().BeOfType(typeof(BadRequestObjectResult));
        }

        [Test]
        [TestCase(1)]
        [TestCase(3)]
        public async Task returns_id_when_order_is_created_correctly(int valueReturned)
        {
            //Given
            var givenRq = new OrderRequest();
            createOrderHandler.Handle().Returns(valueReturned);

            //When
            var result = await orderController.Post(givenRq);

            //Then
            ((CreatedResult)result).Value.Should().Be(valueReturned);
        }
    }
}