using System;

class Program
{
    static void Main(string[] args)
    {
        CustomerRepository repository =
            new CustomerRepositoryImpl();

        CustomerService service =
            new CustomerService(repository);

        Customer customer = service.GetCustomer(101);

        Console.WriteLine("Customer Details:");
        Console.WriteLine("ID   : " + customer.Id);
        Console.WriteLine("Name : " + customer.Name);
    }
}