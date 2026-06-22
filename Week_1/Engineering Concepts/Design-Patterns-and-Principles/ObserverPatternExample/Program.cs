using System;

class Program
{
    static void Main(string[] args)
    {
        StockMarket stockMarket = new StockMarket();

        Observer mobileApp = new MobileApp();
        Observer webApp = new WebApp();

        stockMarket.RegisterObserver(mobileApp);
        stockMarket.RegisterObserver(webApp);

        stockMarket.SetStockPrice("TCS", 4250.50);

        Console.WriteLine();

        stockMarket.SetStockPrice("Infosys", 1780.75);
    }
}