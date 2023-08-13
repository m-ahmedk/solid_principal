using SOLID.Repository.Abstract;

namespace SOLID.Repository.Service.LSP
{
    public class ElectricCar : Car
    {
        public ElectricCar()
        {
            EngineType = EngineType.Electric;
        }

        public override async Task StartEngine()
        {
            System.Diagnostics.Debug.WriteLine("Electric Car Started!");
        }
    }
}
