namespace SOLID.Repository.Interface
{
    public interface IPaymentProcessor
    {
        public Task<bool> ProcessPayment(int orderId);
    }
}
