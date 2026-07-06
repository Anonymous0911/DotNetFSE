public class PayPalAdapter : PaymentProcessor
{
    private readonly PayPalGateway payPalGateway;

    public PayPalAdapter(PayPalGateway gateway)
    {
        payPalGateway = gateway;
    }

    public void ProcessPayment(double amount)
    {
        payPalGateway.MakePayment(amount);
    }
}

public class StripeAdapter : PaymentProcessor
{
    private readonly StripeGateway stripeGateway;

    public StripeAdapter(StripeGateway gateway)
    {
        stripeGateway = gateway;
    }

    public void ProcessPayment(double amount)
    {
        stripeGateway.Pay(amount);
    }
}