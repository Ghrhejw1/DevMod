namespace Factory;

public interface ICar
{
    string Name { get; }
    void Accelerate();
    void Decelerate();
    void Move();
    bool IsFinished();
}
