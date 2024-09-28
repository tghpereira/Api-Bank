var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

IFindByEmailCustomerRepository findByEmailCustomerRepository = new FindByEmailCustomerRepository();
ICreateCustomerRepository createCustomerRepository = new CreateCustomerRepository();
ICreateCustomerService createCustomerService = new CreateCustomerService(createCustomerRepository, findByEmailCustomerRepository);
ICreateCustomerController createCustomerController = new CreateCustomerController(createCustomerService);

app.MapGet("/", () => "Hello World!");


app.MapPost("/", async (CreateCustomerControllerProp createCustomerControllerProp) => {
    ICustomer customer = await createCustomerController.Execute(createCustomerControllerProp);
    return Results.Ok(customer);
});

app.Run();

