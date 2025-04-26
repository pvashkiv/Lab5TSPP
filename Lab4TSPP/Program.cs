class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Оберіть патерн для демонстрації:");
        Console.WriteLine("1 — Observer (сповіщення про замовлення)");
        Console.WriteLine("2 — Singleton (менеджер ресурсів)");
        Console.WriteLine("3 — Adapter (конвертер валют)");
        Console.Write("Ваш вибір: ");

        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine("\n=== Observer ===");
                Demo.RunObserverDemo();
                break;

            case "2":
                Console.WriteLine("\n===  Singleton ===");
                Demo.RunSingletonDemo();
                break;

            case "3":
                Console.WriteLine("\n===  Adapter ===");
                Demo.RunAdapterDemo();
                break;

            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }
}