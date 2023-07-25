using SOLID.Repository.Interface;

namespace SOLID.Repository.Service.OCP
{
    public class CreditCardPayment : IPaymentProcessor
    {
        public async Task<bool> ProcessPayment(int orderId)
        {
            // implement credit card payment logic

            return true;
        }
    }
}
