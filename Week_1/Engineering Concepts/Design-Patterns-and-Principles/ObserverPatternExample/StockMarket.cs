using System.Collections.Generic;

public class StockMarket : Stock
{
    private List<Observer> observers = new List<Observer>();

    private string stockName = string.Empty;
    private double price;

    public void RegisterObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void DeregisterObserver(Observer observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (Observer observer in observers)
        {
            observer.Update(stockName, price);
        }
    }

    public void SetStockPrice(string stockName, double price)
    {
        this.stockName = stockName;
        this.price = price;

        NotifyObservers();
    }
}