using System;

public class MobileApp : Observer
{
    public void Update(string stockName, double price)
    {
        Console.WriteLine(
            $"Mobile App: {stockName} price updated to ₹{price}");
    }
}

public class WebApp : Observer
{
    public void Update(string stockName, double price)
    {
        Console.WriteLine(
            $"Web App: {stockName} price updated to ₹{price}");
    }
}