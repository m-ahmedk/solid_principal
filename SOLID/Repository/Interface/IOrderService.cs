namespace SOLID.Repository.Interface
{
    public interface IOrderService { 
        public Task CreateOrder();
        public Task<bool> ProcessOrder(int orderId, IPaymentProcessor paymentProcess);
    }
}
