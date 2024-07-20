//separates an object's interface from its implementation


//IPaymentSystem paymentSystem = new HDFCPayment();
//Payment payment = new CardPayment(paymentSystem);
//payment.DoPayment();



interface IPaymentSystem
{
    public void ProcessPayment();
}

class HDFCPayment :IPaymentSystem


{
    public void ProcessPayment()
    {
        Console.WriteLine("Process Payment HDFC");
    }
}
class SBIPayment: IPaymentSystem
{
    public void ProcessPayment()
    {
        Console.WriteLine("Process Payment SBI");
    }
}

abstract class Payment
{
    public IPaymentSystem paymentSystem;


    public abstract void DoPayment();

}

class CardPayment : Payment
{
    public CardPayment(IPaymentSystem paymentSystem)
    {
        this.paymentSystem = paymentSystem;
    }

    public override void DoPayment()
    {
        Console.WriteLine("Inside card payment");
        this.paymentSystem.ProcessPayment();
    }
}


class NetbankindPayment : Payment
{
    public NetbankindPayment(IPaymentSystem paymentSystem)
    {
        this.paymentSystem= paymentSystem;
    }
    public override void DoPayment()
    {
        Console.WriteLine("Inside netbanking payment");
        this.paymentSystem.ProcessPayment();
    }
}