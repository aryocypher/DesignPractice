interface INotificationSender
{
    public void Send(String message);

    public void SendEmail();

    public void SendText();
}

class InvoiceNotificationSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine("Invoice Notification Send");
    }

    public void SendEmail()
    {
        Console.WriteLine("Invoice send via email");
    }

    public void SendText()
    {
        Console.WriteLine("Text send via text");
    }
}

class OrderNotificationSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine("Order Notification Send");
    }

    public void SendEmail()
    {
        Console.WriteLine("Order send via email");
    }

    public void SendText()
    {
        Console.WriteLine("Order send via text");
    }
}

