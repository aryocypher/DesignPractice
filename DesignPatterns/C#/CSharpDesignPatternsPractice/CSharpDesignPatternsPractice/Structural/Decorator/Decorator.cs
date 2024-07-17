//ICar car = new HyundaiCar();
//DiscountCarDecorator carDecorator = new DiscountPrice(car);
//Console.WriteLine(carDecorator.getDiscountPrice());

public interface ICar
{
    
    public int getPrice();
}

public class HyundaiCar : ICar
{
    public string Name { get; set; }

    public int getPrice()
    {
        return 5000;
    }
}


public class MarutiCar : ICar
{
    public string Name { get; set; }

    public int getPrice()
    {
        return 3000;
    }
}

public abstract class DiscountCarDecorator : ICar
{
    private ICar Car { get; set; }

    public DiscountCarDecorator(ICar car)
    {
        this.Car = car;
    }
    public int getPrice()
    {
        return this.Car.getPrice();
    }

    public abstract int getDiscountPrice();
}

public class DiscountPrice:DiscountCarDecorator
{
    public DiscountPrice(ICar car):base(car) 
    {
    }

    public override int getDiscountPrice()
    {
        return Convert.ToInt32(base.getPrice() * 0.8);
    }
}