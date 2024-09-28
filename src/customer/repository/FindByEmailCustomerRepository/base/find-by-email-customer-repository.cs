

public class FindByEmailCustomerRepository: IFindByEmailCustomerRepository{
    public Task<ICustomer?> Excute(string email){
        ICustomer customer = new Customer("Customer One", email);

        if (customer.Name == "Customer One") {
            return Task.FromResult<ICustomer>(null);
        }
        
        return Task.FromResult<ICustomer>(customer);
    }
}