namespace Builder_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            DogBuilder builder = new DogBuilder();
            Dog myDog = builder
                .SetName("Buddy")
                .SetBreed("Golden Retriever")
                .SetAge(3)
                .AddToy("Ball")
                .AddToy("Bone")
                .Build();

            Console.WriteLine($"Name: {myDog.Name}");
            Console.WriteLine($"Breed: {myDog.Breed}");
            Console.WriteLine($"Age: {myDog.Age}");
            Console.WriteLine("Toys: " + string.Join(", ", myDog.Toys));
        }
    }
}
