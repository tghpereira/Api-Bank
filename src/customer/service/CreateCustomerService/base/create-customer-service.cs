

class CreateCustomerServiceProp : ICreateCustomerServiceProp
{
    public string Name { get; set; }
    public string Email { get; set; }

    public CreateCustomerServiceProp(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

public class CreateCustomerService: ICreateCustomerService {
    private readonly ICreateCustomerRepository CreateCustomerRepository;
    private readonly IFindByEmailCustomerRepository FindByEmailCustomerRepository;
    public CreateCustomerService
    (
        ICreateCustomerRepository createCustomerRepository, 
        IFindByEmailCustomerRepository findByEmailCustomerRepository
    ){
        CreateCustomerRepository = createCustomerRepository;
        FindByEmailCustomerRepository = findByEmailCustomerRepository;
    }
    public async Task<ICustomer> Execute(ICreateCustomerServiceProp prop){

        ICustomer uniqueEmail = await FindByEmailCustomerRepository.Excute(prop.Email);

        if(uniqueEmail != null){
            throw new InvalidOperationException("Um cliente com este email já existe.");
        }

        ICustomer create = await CreateCustomerRepository.Excute(prop.Name, prop.Email);

        return create;
    }
}