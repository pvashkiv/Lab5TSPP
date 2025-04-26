public class Demo
{
    public static void RunObserverDemo()
    {
        Order order1 = new Order("100");
        Order order2 = new Order("101");

        
        User user1 = new User("Олексій");
        User user2 = new User("Ірина");

        order1.Attach(user1);
        order2.Attach(user2);

        Console.WriteLine("🔔 Нова подія: Створено замовлення");
        order1.SetStatus("Очікує підтвердження ✅");
        order2.SetStatus("Очікує підтвердження ✅");

        Console.WriteLine("\n🔔 Оновлення: Замовлення підтверджено продавцем");
        order1.SetStatus("Підтверджено 📦");
        order2.SetStatus("Підтверджено 📦");


        Console.WriteLine("\n🔔 Оновлення: Товар в дорозі");
        order1.SetStatus("Доставляється 🚚");
        order2.SetStatus("Доставляється 🚚");

        Console.WriteLine("\n🔕 Максим відписався від оновлень");
        order2.Detach(user2);

        Console.WriteLine("\n🔔 Оновлення: Замовлення доставлено");
        order1.SetStatus("Доставлено 🏠");
        order2.SetStatus("Доставлено 🏠");
        
        Console.WriteLine("\n🔔 Оновлення: Замовлення виконано");
        order1.SetStatus("Завершено ✅");
        order2.SetStatus("Завершено ✅");
    }

    public static void RunSingletonDemo()
    {
        ResourceManager rm = ResourceManager.Instance;

        rm.AddImage("logo", "/images/logo.png");
        rm.AddFont("main", "Roboto");
        rm.AddData("version", "1.0.0");

        Console.WriteLine("Image: " + rm.GetImage("logo"));
        Console.WriteLine("Font: " + rm.GetFont("main"));
        Console.WriteLine("App Version: " + rm.GetData("version"));
    }
    
    public static void RunAdapterDemo()
    {
        NationalBankApi nbuApi = new NationalBankApi();
        EuropeanCentralBankApi ecbApi = new EuropeanCentralBankApi();

        ICurrencyProvider adapter = new CurrencyAdapter(nbuApi, ecbApi);

        Console.WriteLine("Курс UAH → USD: " + adapter.GetExchangeRate("UAH", "USD"));
        Console.WriteLine("Курс UAH → EUR: " + adapter.GetExchangeRate("UAH", "EUR"));
        Console.WriteLine("Курс EUR → USD: " + adapter.GetExchangeRate("EUR", "USD"));
        Console.WriteLine("Курс USD → EUR: " + adapter.GetExchangeRate("USD", "EUR"));
    }
    
    public static void RunFactoryDemo()
    {
        UserFactory adminFactory = new AdminFactory();
        UserFactory managerFactory = new ManagerFactory();
        UserFactory employeeFactory = new EmployeeFactory();

        IUser admin = adminFactory.CreateUser();
        IUser manager = managerFactory.CreateUser();
        IUser employee = employeeFactory.CreateUser();

        admin.DisplayInfo();
        manager.DisplayInfo();
        employee.DisplayInfo();
    }
}
