
public class Customer: ICustomer {
    public Guid Id {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}

  public Customer(string name, string email){
    Id = Guid.NewGuid();
    Name = name;
    Email = email;
  }
}