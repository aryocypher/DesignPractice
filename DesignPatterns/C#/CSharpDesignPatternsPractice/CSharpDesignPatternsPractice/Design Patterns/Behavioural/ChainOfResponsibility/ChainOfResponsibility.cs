/*IHandler level1 = new Level1();
IHandler level2 = new Level2();
IHandler level3 = new Level3();
level1.SetNextHandler(level2).SetNextHandler(level3);

level1.HandleRequest(9);
level1.HandleRequest(15);
level1.HandleRequest(25);*/



public interface IHandler
{
    public IHandler SetNextHandler(IHandler level);
    public void HandleRequest(int val);
}

public class Level1 : IHandler
{
    public IHandler nextLevel;

    public void HandleRequest(int val)
    {
        if (val < 10)
        {
            Console.WriteLine("val less than 10 handled at level 1");
            return;
        }
        Console.WriteLine("Value to big for level 1. Moving to next level");
        nextLevel.HandleRequest(val);
    }

    public IHandler SetNextHandler(IHandler level)
    {
        nextLevel = level;
        return nextLevel;
    }
}

public class Level2 : IHandler
{
    public IHandler nextLevel;

    public void HandleRequest(int val)
    {
        if (val < 20)
        {
            Console.WriteLine("val less than 20 handled at level 2");
            return;
        }
        Console.WriteLine("Value to big for level 2. Moving to next level");
        nextLevel.HandleRequest(val);
    }

    public IHandler SetNextHandler(IHandler level)
    {
        nextLevel = level;
        return nextLevel;
    }
}

public class Level3 : IHandler
{
    public IHandler nextLevel;

    public void HandleRequest(int val)
    {
        Console.WriteLine("val handled at level 3");

    }

    public IHandler SetNextHandler(IHandler level)
    {
        nextLevel = level;
        return nextLevel;
    }
}