namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем фабрику
            SportsCarFactory carFactory = new SportsCarFactory();

            // Создаем коллекцию автомобилей
            List<ICar> cars = new List<ICar>();

            // Создаем 5 спортивных автомобилей
            for (int i = 0; i < 5; i++)
            {
                cars.Add(carFactory.CreateCar());
            }

            // Симулируем движение автомобилей
            while (cars.Any(car => !car.IsFinished()))
            {
                foreach (var car in cars)
                {
                    car.Accelerate();
                    car.Move();
                    car.Decelerate();
                }

                Console.WriteLine();
            }

            // Выводим информацию о распределении мест
            int place = 1;
            foreach (var car in cars.OrderByDescending(c => c.IsFinished()).ThenByDescending(c => c.Name.Length))
            {
                Console.WriteLine($"{place++} место: {car.Name}");
            }

            Console.ReadLine();
        }
    }
}
