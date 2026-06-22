public class CustomerRepositoryImpl : CustomerRepository
{
    public Customer FindCustomerById(int id)
    {
        return new Customer(id, "John Doe");
    }
}