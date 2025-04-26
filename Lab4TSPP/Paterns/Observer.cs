public interface IObserver
{
    void Update(string orderId, string status);
}
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
public class Order : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private string _status;
    public string OrderId { get; private set; }

    public Order(string orderId)
    {
        OrderId = orderId;
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(OrderId, _status);
        }
    }

    public void SetStatus(string status)
    {
        _status = status;
        Notify();
    }
}
public class User : IObserver
{
    private string _name;

    public User(string name)
    {
        _name = name;
    }

    public void Update(string orderId, string status)
    {
        Console.WriteLine($"[Користувач {_name}] Статус замовлення {orderId} змінено на: {status}");
    }
}
