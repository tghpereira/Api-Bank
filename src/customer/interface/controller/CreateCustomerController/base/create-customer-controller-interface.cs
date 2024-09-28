public interface ICreateCustomerControllerProp {
    public string Name{get; set;}
    public string Email{get; set;}
}
public interface ICreateCustomerController {
    public Task<ICustomer> Execute(ICreateCustomerControllerProp prop);
}