using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns2.ObserverPattern;

/// <summary>
/// Subject (Stock): The Stock class maintains a list of observers and notifies them of any price changes.
/// Observer Interface(IObserver): This defines the Update method that all concrete observers must implement.
/// Concrete Observer(Investor): The Investor class implements the IObserver interface and reacts to updates.
/// Usage: In Main, we create a Stock instance and add two Investor observers.When the stock price changes,
/// the observers are notified.
/// </summary>
public class Stock
{
    private string _symbol;
    private decimal _price;
    private List<IObserver> _observers = new List<IObserver>();

    public Stock(string symbol, decimal price)
    {
        _symbol = symbol;
        _price = price;
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (_price != value)
            {
                _price = value;
                Notify();
            }
        }
    }

    public string Symbol => _symbol;
}
