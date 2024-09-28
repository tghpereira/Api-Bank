

public class CreateCustomerControllerProp : ICreateCustomerControllerProp
{
    public string Name { get; set; }
    public string Email { get; set; }

    public CreateCustomerControllerProp(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

public class CreateCustomerController : ICreateCustomerController
{
    private readonly ICreateCustomerService CreateCustomerService;
    public CreateCustomerController(
     ICreateCustomerService createCustomerService
     )
    {
        CreateCustomerService = createCustomerService;
    }
    public async Task<ICustomer> Execute(ICreateCustomerControllerProp prop)
    {
        ICreateCustomerServiceProp createCustomerServiceProp = new CreateCustomerServiceProp(prop.Name, prop.Email);
        
        return await CreateCustomerService.Execute(createCustomerServiceProp);
    }
}