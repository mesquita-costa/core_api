using core_api.Model;
using core_api.Model.Interface;


namespace core_api.Infra.Repository
{
    public class BankRepository : IBankRepository
    {
        private readonly Context _context;
        public BankRepository(Context context)
        {
            _context = context;
        }
        public async Task Add(Bank bank)
        {

            await _context.Banks.AddAsync(bank);
            _context.SaveChanges();
        }


        public async Task<Bank>FindById(int id)
        {
            var data = await _context.Banks.FindAsync(id);
            if (data == null)
            {
               return null;
            }
            return data;


        }


        public IList<Bank> GetAll()
        {
            return _context.Banks.ToList();
        }

        public Task Inativar(string id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Bank dados)
        {
            throw new NotImplementedException();
        }

        public bool ValidInactive(string bank)
        {
            throw new NotImplementedException();
        }
    }
}
