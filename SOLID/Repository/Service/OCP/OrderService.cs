using SOLID.Repository.Interface;
using System.Runtime.CompilerServices;

namespace SOLID.Repository.Service.OCP
{
    // The class remains open for extension as new payment processors can be added without modification
    // and closed for modification as we don't need to change the OrderManager class when adding
    // new payment processors.

    public class OrderService : IOrderService
    {
        AppDBContext _appDBContext;

        public OrderService (AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task CreateOrder()
        {
            System.Diagnostics.Debug.WriteLine("Order created successfully!");
        }

        public async Task<bool> ProcessOrder(int orderId, IPaymentProcessor paymentProcess)
        {
            bool result = false;

            try { 
                result = await paymentProcess.ProcessPayment(orderId);

                return result;
            }
            catch(Exception ex)
            {
                return result;
            }
        }
    }
}
