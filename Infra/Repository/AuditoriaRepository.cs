using core_api.Model;
using core_api.Model.Interface;
using Microsoft.EntityFrameworkCore;

namespace core_api.Infra.Repository
{
    public class AuditoriaRepository : IAuditoriaRepository
    {
        private readonly Context _context;

        public AuditoriaRepository(Context context)
        {
            _context = context;
        }

        public async Task Add(Auditoria bank)
        {
            await _context.Auditorias.AddAsync(bank);
            _context.SaveChanges();
        }

        public async Task<Auditoria> FindById(int id)
        {
            return await _context.Auditorias.FirstAsync(c => c.Id == id);
        }

        public IList<Auditoria> GetAll()
        {
            return _context.Auditorias.OrderByDescending(b => b.dataHora).ToList();
        }


        public Task Update(Auditoria dados)
        {
            throw new NotImplementedException();
        }
        
    }
}
