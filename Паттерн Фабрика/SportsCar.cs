namespace Factory;

public class SportsCar : ICar
{
    private int speed;
    private int distance;
    private bool finished;

    public SportsCar(string name)
    {
        Name = name;
        speed = 0;
        distance = 0;
        finished = false;
    }

    public string Name { get; }

    public void Accelerate()
    {
        if (speed < 100)
            speed += 10;
    }

    public void Decelerate()
    {
        if (speed > 0)
            speed -= 5;
    }

    public void Move()
    {
        distance += speed;
        Console.WriteLine($"{Name} - Speed: {speed} km/h, Distance: {distance} km");
    }

    public bool IsFinished()
    {
        return distance >= 200; // Условие завершения гонки
    }
}
