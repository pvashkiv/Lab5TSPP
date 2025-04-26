// Файл: Program.cs

using System;

// Абстрактний продукт
interface IUser
{
    void DisplayInfo();
}

// Конкретні продукти
class Admin : IUser
{
    public void DisplayInfo()
    {
        Console.WriteLine("I'm an Admin user.");
    }
}

class Manager : IUser
{
    public void DisplayInfo()
    {
        Console.WriteLine("I'm a Manager user.");
    }
}

class Employee : IUser
{
    public void DisplayInfo()
    {
        Console.WriteLine("I'm an Employee user.");
    }
}

// Абстрактна фабрика
abstract class UserFactory
{
    public abstract IUser CreateUser();
}

// Конкретні фабрики
class AdminFactory : UserFactory
{
    public override IUser CreateUser()
    {
        return new Admin();
    }
}

class ManagerFactory : UserFactory
{
    public override IUser CreateUser()
    {
        return new Manager();
    }
}

class EmployeeFactory : UserFactory
{
    public override IUser CreateUser()
    {
        return new Employee();
    }
}
