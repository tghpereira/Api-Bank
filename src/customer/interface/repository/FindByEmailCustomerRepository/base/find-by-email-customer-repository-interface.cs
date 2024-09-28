public interface IFindByEmailCustomerRepository {
    public Task<ICustomer?> Excute(string email);
}