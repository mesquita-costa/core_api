namespace core_api.Model.Interface
{
    public interface IAuditoriaRepository
    {

        Task Add(Auditoria bank);
        IList<Auditoria> GetAll();
        Task<Auditoria> FindById(int id);
        Task Update(Auditoria dados);
    }
}
