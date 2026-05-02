using helloworld;
using System;

public class Program
{
    static void Main()
    {

        TemperatureConverter temperature = new TemperatureConverter(101.11);
        Circle circle = new Circle(201.11);
        StepCounter stepCounter = new StepCounter(119);
        Rectangle rectangle = new Rectangle(110.111, 110.111);
        BankAccount bankAccount = new BankAccount(100.007);
        Student student = new Student(10129);
        Product product = new Product(1029);
        WaterTankLevel watertanklevel = new WaterTankLevel(11);
        CarSpeedometer carspeedometer = new CarSpeedometer(240);
        Employee employee = new Employee("kim");
        Book book = new Book(50);
       

        Console.WriteLine(temperature.Fahrenheit);
        Console.WriteLine(circle.Radius);
        Console.WriteLine(stepCounter.DistanceInKm);
        Console.WriteLine(rectangle.Area);
        Console.WriteLine(bankAccount.Balance);
        Console.WriteLine(student.Grade);
        Console.WriteLine(product.TaxedPrice);
        Console.WriteLine(watertanklevel.liters);
        Console.WriteLine(carspeedometer.Speed);
        Console.WriteLine(employee.Name);
        Console.WriteLine(book.PagesRead);
    }
}