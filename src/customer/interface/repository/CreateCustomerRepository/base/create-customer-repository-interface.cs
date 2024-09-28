

public interface ICreateCustomerRepository {
    public Task<ICustomer> Excute(string name, string email);
}