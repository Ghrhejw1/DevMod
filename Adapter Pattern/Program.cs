namespace Adapter_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            ComputerGame game = new ComputerGame(
                "Genshin Impact",
                PegiAgeRating.P16,
                60.5, // Бюджет в миллионах долларов
                2048, // Минимальная память GPU в мегабайтах
                50,   // Требуемое место на диске в гигабайтах
                8,    // Требуемая оперативная память в гигабайтах
                4,    // Требуемое количество ядер процессора
                3.5   // Требуемая скорость процессора в ГГц
            );

            // Создаем адаптер
            PCGame pcGame = new ComputerGameAdapter(game);

            // Используем адаптер
            Console.WriteLine($"Title: {pcGame.getTitle()}");
            Console.WriteLine($"PEGI Allowed Age: {pcGame.getPegiAllowedAge()}");
            Console.WriteLine($"Is Triple A Game: {pcGame.isTripleAGame()}");
            Requirements req = pcGame.getRequirements();
            Console.WriteLine($"GPU (GB): {req.getGpuGb()}");
            Console.WriteLine($"HDD (GB): {req.getHDDGb()}");
            Console.WriteLine($"RAM (GB): {req.getRAMGb()}");
            Console.WriteLine($"CPU Speed (GHz): {req.getCpuGhz()}");
            Console.WriteLine($"Cores Needed: {req.getCoresNum()}");
        }
    }
}
