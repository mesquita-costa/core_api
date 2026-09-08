namespace core_api.Model.Interface
{
    public interface IBankRepository
    {

        Task Add(Bank bank);
        bool ValidInactive(string bank);
        IList<Bank> GetAll();
        Task<Bank> FindById(int id);
        Task Inativar(string id);
        Task Update(Bank dados);
    }
}
