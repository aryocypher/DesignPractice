AbstractEmployee john = new Employee("John","IT");
AbstractEmployee mike = new Employee("Mike", "Sales");
AbstractEmployee aru = new Employee("aru", "IT");
AbstractEmployee eric = new Employee("Eric", "Sales");
AbstractEmployee jack = new Employee("Jack", "Sales");

AbstractEmployee cody = new Manager("Cody", "Sales")
{
    EmployeesList = {mike,eric,jack }
};

cody.GetDetails();


public abstract class AbstractEmployee
{
    public abstract void GetDetails();

    public virtual void Add(AbstractEmployee employee)
    {
        throw new NotImplementedException();
    }
}

public class Employee: AbstractEmployee
{
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee(string name, string department)
    {
        this.Name = name;
        this.Department = department;
    }
    public override void GetDetails()
    {
        Console.WriteLine($"Name: {Name} Department: {Department}");
    }
}

public class Manager : AbstractEmployee
{
    public string Name { get; set; }
    public string Department { get; set; }

    public List<AbstractEmployee> EmployeesList { get; set;}

    public Manager(string name,string department)
    {
        Name = name;
        Department = department;
        EmployeesList = new List<AbstractEmployee>();  
    }

    public override void Add(AbstractEmployee employee)
    {
       EmployeesList.Add(employee);
    }
    public override void GetDetails()
    {
        Console.WriteLine($"Name: {Name} Department: {Department}");
        foreach(var employee in EmployeesList) { 
            employee.GetDetails();
        }
    }
}

