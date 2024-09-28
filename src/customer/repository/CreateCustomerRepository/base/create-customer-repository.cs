
public class CreateCustomerRepository: ICreateCustomerRepository{
    public Task<ICustomer> Excute(string name, string email){
        ICustomer customer = new Customer(name, email);
        return Task.FromResult<ICustomer>(customer);
    }
}