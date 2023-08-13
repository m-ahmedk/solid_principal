using Microsoft.AspNetCore.Mvc;
using SOLID.Repository.Abstract;
using SOLID.Repository.Service.LSP;

namespace SOLID.Controllers.LSP
{
    public class CarController : Controller
    {
        public async Task StartCar() {
            Car normalCar = new NormalCar();
            Car electricCar = new ElectricCar();

            StartCarEngine(normalCar); // Output: "Normal car engine started."
            StartCarEngine(electricCar);  // Output: "Electric car engine started."
        }

        public static void StartCarEngine(Car car)
        {
            car.StartEngine();
        }
    }
}
