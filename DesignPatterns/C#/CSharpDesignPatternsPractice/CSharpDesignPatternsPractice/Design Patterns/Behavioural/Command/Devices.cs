

// Receiver interface
public interface IDevice
{
    void turnOn();
    void turnOff();
}

// Concrete receiver for a TV
public class TV : IDevice
{
    public void turnOn()
    {
        Console.WriteLine("TV is now on");
    }

    public void turnOff()
    {
        Console.WriteLine("TV is now off");
    }

    public void changeChannel()
    {
        Console.WriteLine("Channel changed");
    }
}

// Concrete receiver for a stereo
public class Stereo : IDevice
{
    public void turnOn()
    {
        Console.WriteLine("Stereo is now on");
    }

    public void turnOff()
    {
        Console.WriteLine("Stereo is now off");
    }

    public void adjustVolume()
    {
        Console.WriteLine("Volume adjusted");
    }
}