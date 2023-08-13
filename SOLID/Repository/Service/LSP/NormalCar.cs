using SOLID.Repository.Abstract;

namespace SOLID.Repository.Service.LSP
{
    public class NormalCar : Car
    {
        public NormalCar() {
            EngineType = EngineType.Gasoline;
        }

        public override async Task StartEngine()
        {
            System.Diagnostics.Debug.WriteLine("Normal Car Started!");
        }
    }
}
