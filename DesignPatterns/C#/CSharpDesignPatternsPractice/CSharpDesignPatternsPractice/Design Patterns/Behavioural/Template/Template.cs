//Template Method is a behavioral design pattern that defines the skeleton of an algorithm in the 
//superclass but lets subclasses override specific steps of the algorithm without changing its structure.

//Process process = new ProcessVariation1();
//process.Start();
//process = new ProcessVariation2();
//process.Start();

public abstract class Process
{
    public void Start()
    {
        Step1();
        Step2();
        Step3();
    }

    public abstract void Step1();
    public virtual void Step2()
    {
        Console.WriteLine("Step2");
    }
    public virtual void Step3()
    {
        Console.WriteLine("Step3");
    }
}

public class ProcessVariation1 : Process
{
    public override void Step1()
    {
        Console.WriteLine("Process Variation1 Step 1");
    }
    public override void Step3()
    {
        Console.WriteLine("Process Variation1 Step 3");
    }

}

public class ProcessVariation2 : Process
{
    public override void Step1()
    {
        Console.WriteLine("Process Variation2 Step 1");
    }
    public override void Step2()
    {
        Console.WriteLine("Process Variation2 Step 2");
    }

}
