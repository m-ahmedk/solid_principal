using SOLID.Repository.Interface;

namespace SOLID.Repository.Abstract
{
    /* The ElectricCar object behaves differently from the other Car objects. In the context of a Car, 
     * when we call StartEngine(), we expect the car's engine to start using traditional fuel, 
     * not an electric motor.
     * 
     * In this case, the ElectricCar class does not correctly substitute the behavior of its base 
     * class Car, and it leads to unexpected and incorrect results when used as a Car.
     */


    /*
     * To fix the LSP violation, we should design the class hierarchy in a way that ensures 
     * substitutability. One way to do it is to remove the ElectricCar class and introduce a more 
     * generic concept, such as an EngineType, which can handle different engine types for cars, 
     * including traditional and electric 
     */

    public abstract class Car : IVehicle
    {
        protected EngineType EngineType { get; set; }
        public abstract Task StartEngine();
    }
}
