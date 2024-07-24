//Visitor is a behavioral design pattern that lets you separate algorithms from the objects on which they operate.
//var emailVisitor = new EmailSender();
//var phoneVisitor = new MessageSender();
//INotificationSenderWithVisitor notification = new InvoiceNotificationSenderWithVisitor();
//notification.Accept(emailVisitor);
//notification.Accept(phoneVisitor);
//notification.Send("INvoice");

public interface INotificationSenderWithVisitor
{
    public void Send(String message);

    public void Accept(IVisitorMedium visitor);
}

public class InvoiceNotificationSenderWithVisitor : INotificationSenderWithVisitor
{
    public void Send(string message)
    {
        Console.WriteLine($"Notification sent for  {message}");
    }

    public void Accept(IVisitorMedium visitor)
    {
        visitor.Visit(this);
    }
}
public class OrderNotificationSenderWithVisitor : INotificationSenderWithVisitor
{
    public void Send(string message)
    {
        Console.WriteLine($"Notification sent for  {message}");
    }

    public void Accept(IVisitorMedium visitor)
    {
        visitor.Visit(this);
    }
}

public interface IVisitorMedium
{
    public void Visit(INotificationSenderWithVisitor notificationSender);
}

class EmailSender : IVisitorMedium
{
    public void Visit(INotificationSenderWithVisitor notificationSender)
    {
        Console.WriteLine("setup email");

    }
}

class MessageSender : IVisitorMedium
{
    public void Visit(INotificationSenderWithVisitor notificationSender)
    {
        Console.WriteLine("setup message");
    }
}
