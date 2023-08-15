using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SOLID.Repository.Interface;
using SOLID.Repository.Service.OCP;

namespace SOLID.Controllers.OCP
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;
        private readonly CreditCardPayment _creditCardPayment;
        private readonly PaypalPayment _payPalPayment;

        public OrderController(OrderService orderService, CreditCardPayment creditCardPayment,
            PaypalPayment payPalPayment)
        {
            _orderService = orderService;
            _creditCardPayment = creditCardPayment;
            _payPalPayment = payPalPayment;
        }

        public async Task<IActionResult> ProcessOrder(int orderId)
        {
            IPaymentProcessor paymentProcessor;

            // Determine the payment processor based on the order ID
            if (orderId > 1000)
            {
                paymentProcessor = _creditCardPayment;
            }
            else
            {
                paymentProcessor = _payPalPayment;
            }

            await _orderService.ProcessOrder(orderId, paymentProcessor);

            return View();
        }
    }
}
