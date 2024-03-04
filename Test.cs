using Thread;
namespace Test
{
   class Program
   {
       static void Main(string[] args)
       {
           Robot robot1 = new Robot(200, 300, "Robot 1");
           Robot robot2 = new Robot(100, 100, "Robot 2");
          
           robot1.Move();
           robot2.Move();


           Console.WriteLine(robot1.GetInfo());
           Console.WriteLine(robot2.GetInfo());
       }
   }
}
