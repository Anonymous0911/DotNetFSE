public class CustomerService
{
    private readonly CustomerRepository repository;

    public CustomerService(CustomerRepository repository)
    {
        this.repository = repository;
    }

    public Customer GetCustomer(int id)
    {
        return repository.FindCustomerById(id);
    }
}