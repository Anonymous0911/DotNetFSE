using System;

public class StripeGateway
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Payment of ₹{amount} processed through Stripe.");
    }
}