namespace Factory;

public class SportsCarFactory: ICarFactory
{
    public ICar CreateCar()
    {
        return new SportsCar("Sports Car");
    }
}
