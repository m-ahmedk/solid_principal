using SOLID.Repository.Interface;

namespace SOLID.Repository.Service.OCP
{
    public class PaypalPayment : IPaymentProcessor
    {
        public async Task<bool> ProcessPayment(int orderId)
        {
            // implement paypal payment logic

            return true;
        }
    }
}
