//Strategy is a behavioral design pattern that lets you define a family of algorithms
//    , put each of them into a separate class, and make their objects interchangeable.
//ICalulate calulate1 = new Add();
//ICalulate calulate2 = new Subtract();

//Console.WriteLine(PracticeClass.CalculateValue(calulate1, 10, 5));
//Console.WriteLine(PracticeClass.CalculateValue(calulate2, 10, 5));

public static class PracticeClass
{
    public static int CalculateValue(ICalulate calulate, int a, int b)
    {
        return calulate.CalculateValue(a, b);
    }
}


public interface ICalulate
{
    public int CalculateValue(int a,int b);
}

class Add : ICalulate
{
    public int CalculateValue(int a, int b)
    {
        return a + b;
    }
}


class Subtract : ICalulate
{
    public int CalculateValue(int a, int b)
    {
        return (a - b);
    }
}
