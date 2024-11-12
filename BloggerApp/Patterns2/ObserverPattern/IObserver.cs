using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns2.ObserverPattern;

// Observer interface
public interface IObserver
{
    void Update(Stock stock);
}

// Concrete Observer
public class Investor : IObserver
{
    private string _name;

    public Investor(string name)
    {
        _name = name;
    }

    public void Update(Stock stock)
    {
        Console.WriteLine($"Notified {_name} of {stock.Symbol}'s change to {stock.Price:C}");
    }
}

// Usage of Observer
public class ProgramObserver
{
    public static void MainObserver()
    {
        Stock apple = new Stock("AAPL", 120.00m);
        Investor investor1 = new Investor("Alice");
        Investor investor2 = new Investor("Bob");

        apple.Attach(investor1);
        apple.Attach(investor2);

        apple.Price = 121.00m;
        apple.Price = 122.50m;

        apple.Detach(investor1);

        apple.Price = 123.00m;
    }
}