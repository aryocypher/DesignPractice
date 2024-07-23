
//Alarm alarm = new Alarm();
//alarm.AddWatcher(new FireStation());
//alarm.AddWatcher(new PoliceStation());
//alarm.Notify();



public class Alarm
{
    List<IWatcher> watchers= new List<IWatcher>();

    public void AddWatcher(IWatcher watcher)
    {
        watchers.Add(watcher);
    }

    public void Notify()
    {
        foreach(var w in watchers) { 
            w.Notify();
        
        }
    }

}

public interface IWatcher
{
    void Notify();
}


class FireStation : IWatcher
{
    public void Notify()
    {
        Console.WriteLine("Firestation notified");
    }
}

class PoliceStation : IWatcher
{
    public void Notify()
    {
        Console.WriteLine("PoliceStation notified");
    }
}
