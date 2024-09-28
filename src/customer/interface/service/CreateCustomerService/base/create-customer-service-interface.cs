
public interface ICreateCustomerServiceProp {
    string Name {get; set;}
    string Email {get; set;}
}

public interface ICreateCustomerService {
    public Task<ICustomer> Execute(ICreateCustomerServiceProp prop);
}