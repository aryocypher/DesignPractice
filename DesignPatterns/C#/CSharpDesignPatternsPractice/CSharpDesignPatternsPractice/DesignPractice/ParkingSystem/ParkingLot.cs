class ParkingLot
{
    private List<Level> levels;

    public ParkingLot(int capacity)
    {
        levels=new List<Level>();
        levels.Add(new Level(capacity, 0));
    }

    public void AddLevel(int capacity)
    {
        levels.Add(new Level(capacity,levels.Count()));
    }

    public void Checkin(string ownerName,string vehicleNumberPlate) { 

        if(string.IsNullOrEmpty(vehicleNumberPlate) || string.IsNullOrEmpty(ownerName))
        {
            throw new Exception("Vehicle should have name or number plate");
        }
        Vehicle vehicle = new Vehicle(ownerName, vehicleNumberPlate);
        bool isSpaceAvailable = false;
        foreach(var level in levels)
        {
            if (level.IsSpaceAvailable())
            {
                isSpaceAvailable = true;
                level.Checkin(vehicle);
                Console.WriteLine("Checkin done");
                break;
            }
        }
        if (!isSpaceAvailable)
        {
            throw new Exception("Space is not available");
        }
        Console.WriteLine("Vehicle Added in parking lot");
    
    }

    public void Checkout(string vehicleNumberPlate)
    {
        if (string.IsNullOrEmpty(vehicleNumberPlate)){
            throw new Exception("Vehicle number plate should not be empty or null");
        }
        bool isVehiclePresent = false;
        foreach(var level in levels)
        {
            if (level.IsVehiclePresent(vehicleNumberPlate))
            {
                isVehiclePresent = true;
                level.Checkout(vehicleNumberPlate);
                
                Console.WriteLine("Checkout done");
                break;
            }
        }
        if (!isVehiclePresent) {
            throw new Exception("Vehicle with this number plate not found");
        }
        Console.WriteLine("Vehicle Checked out of parking lot");

    }
}

//Data class
public class Vehicle
{
    public string OwnerName { get; set; }
    public string VehiclePlateNumber { get; set; }

    public Vehicle(string ownerName,string vehiclePlateNumber)
    {
        this.OwnerName = ownerName;
        this.VehiclePlateNumber = vehiclePlateNumber;
    }
}

internal class Level
{
    public int Capacity { get; set; }
    public int LevelNumber { get; set; }

    public Dictionary<string,Vehicle> Vehicles { get; set; }

    public Level(int capacity, int levelNumber)
    {
        this.Capacity = capacity;
        this.LevelNumber = levelNumber;
        Vehicles = new Dictionary<string, Vehicle>();
    }

    public bool IsSpaceAvailable()
    {
        return this.Capacity!=this.Vehicles.Count;
    }

    public void Checkin(Vehicle vehicle)
    {
        if (!this.IsSpaceAvailable())
        {
            throw new Exception("Space is not available");
        }
        this.Vehicles.Add(vehicle.VehiclePlateNumber, vehicle);
        Console.WriteLine($"Vehicle {vehicle.VehiclePlateNumber} Added to level {this.LevelNumber}");
    }

    public bool IsVehiclePresent(string vehicleNumber)
    {
        if(this.Vehicles.ContainsKey(vehicleNumber))
        { 
            return true; 
        }
        return false;
    }
    public void Checkout(string vehicleNumber)
    {
        if (!this.IsVehiclePresent(vehicleNumber))
        {
            throw new Exception("Vehicle is not there");
        }
        this.Vehicles.Remove(vehicleNumber);

        Console.WriteLine($"Vehicle {vehicleNumber} Removed from level {this.LevelNumber}");
    }
}