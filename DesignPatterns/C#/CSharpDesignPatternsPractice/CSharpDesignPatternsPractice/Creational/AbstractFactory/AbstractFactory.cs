using CSharpDesignPatternsPractice.Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

IAbstractFactory ab = new RedVehicleFactory();
IProductForAbstractFactory product = ab.GetVehicle("Scooter");
product.Drive(10);


namespace CSharpDesignPatternsPractice.Creational.Factory
{
    public interface IProductForAbstractFactory
    {
     
        void Drive( int miles);
    }

    public class ScooterForAbstractFactory : IProductForAbstractFactory
    {
        public string Color { get; set; }
        public ScooterForAbstractFactory(string color)
        {
            this.Color = color;
        }
        public void Drive(int miles)
        {
            Console.WriteLine($"Scooter drived for {miles}. Color {Color}");
        }
    }
    public class BikeForAbstractFactory : IProductForAbstractFactory
    {
        public string Color { get; set; }

        public BikeForAbstractFactory(string color)
        {
            this.Color= color;
        }
        public void Drive(int miles)
        {
            Console.WriteLine($"Bike drived for {miles}.Color {Color}");
        }
    }

    public interface IAbstractFactory
    {
        public IProductForAbstractFactory GetVehicle(string vehicle);
    }

    public class GreenVehicleFactory : IAbstractFactory
    {
        public IProductForAbstractFactory GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Bike":
                    return new BikeForAbstractFactory("Green");
                case "Scooter":
                    return new ScooterForAbstractFactory("Green");
                default:
                    throw new Exception("Vehicle not found");
            }
        }
    }

    public class RedVehicleFactory : IAbstractFactory
    {
        public IProductForAbstractFactory GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Bike":
                    return new BikeForAbstractFactory("Red");
                case "Scooter":
                    return new ScooterForAbstractFactory("Red");
                default:
                    throw new Exception("Vehicle not found");
            }
        }
    }


}
