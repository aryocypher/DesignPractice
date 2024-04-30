using CSharpDesignPatternsPractice.Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//IFactory fc= new ConcreteVehicleFactory();
//IProduct bike=fc.GetVehicle("Bike");
//IProduct scooter = fc.GetVehicle("Scooter");
//bike.Drive(10);
//scooter.Drive(20);


namespace CSharpDesignPatternsPractice.Creational.Factory
{
    public interface IProduct
    {
        void Drive(int miles);
    }

    public class Scooter:IProduct
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Scooter drived for {miles}");
        }
    }
    public class Bike : IProduct
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Bike drived for {miles}");
        }
    }

    public interface IFactory
    {
        public IProduct GetVehicle(string vehicle);
    }

    public class ConcreteVehicleFactory : IFactory
    {
        public IProduct GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Bike":
                    return new Bike();
                case "Scooter":
                    return new Scooter();
                default:
                    throw new Exception("Vehicle not found");
            }
        }
    }
}
