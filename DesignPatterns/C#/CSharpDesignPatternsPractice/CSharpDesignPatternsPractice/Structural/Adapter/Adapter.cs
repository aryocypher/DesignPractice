    public class Adaptee
    {
    public void PrintString(String s)
        {
            Console.WriteLine(s);
        }
    }
    public class Adapter
    {
    public readonly Adaptee adaptee;
    public Adapter()
    {
        Adaptee adaptee = new Adaptee();
    }

    public void AdapterPrintString(String s)
    {
        Console.WriteLine(s);
    }
}
