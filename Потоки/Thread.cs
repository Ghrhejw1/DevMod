namespace Thread;


public class Robot
{
   private (int, int) coordinates;
   private string name;


   public Robot(int x, int y, string name)
   {
       coordinates.Item1 = x;
       coordinates.Item2 = y;
       this.name = name;
   }
  
   public (int, int) Coordinates
   {
       get { return coordinates; }
       set { coordinates = value; }
   }


   public void Move()
   {
       Random random = new Random();
       int derection = random.Next(4);
      
       switch (derection)
       {
           case 0:
               Console.WriteLine($"{name} Вперед ({coordinates.Item1 + 1}, {coordinates.Item2})");
               coordinates.Item1++;
               break;
           case 1:
               Console.WriteLine($"{name} Назад ({coordinates.Item1 - 1}, {coordinates.Item2})");
               coordinates.Item1--;
               break;
           case 2:
               Console.WriteLine($"{name} Налево ({coordinates.Item1}, {coordinates.Item2 - 1})");
               coordinates.Item2++;
               break;
           case 3:
               Console.WriteLine($"{name} Направо ({coordinates.Item1}, {coordinates.Item2 + 1})");
               coordinates.Item2--;
               break;
       }


     
   }
   public string GetInfo()
      {
          return  $"{name} ({coordinates.Item1}, {coordinates.Item2})";
      }
   public override string ToString()
   {
       return GetInfo();
   }
}
