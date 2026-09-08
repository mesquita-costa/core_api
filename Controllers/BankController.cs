using core_api.Model;
using core_api.Model.Interface;
using Microsoft.AspNetCore.Mvc;

namespace coreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankRepository _repository;
        private readonly IAuditoriaRepository _auditoriarepository;

        public BankController(IBankRepository repository, IAuditoriaRepository auditoriarepository)
        {
            _repository = repository;
            _auditoriarepository = auditoriarepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var banks = _repository.GetAll();
            var auditLog = new Auditoria
            {
                acao = "GET - ALL",
                detalhes = "Listando todos os " + nameof(Bank),
                dataHora = DateTime.UtcNow,
                usuario = "API"
            };
             _auditoriarepository.Add(auditLog);
            return Ok(banks);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var bank = await _repository.FindById(id);
            if (bank == null)
            {
                return NotFound();
            }
            var auditLog = new Auditoria
            {
                acao = "GETID",
                detalhes = "Consultando por Id " + nameof(Bank) + " - Código identificador - " + bank.BankId.ToString("D3"),
                dataHora = DateTime.UtcNow,
                usuario = "API"
            };
            await _auditoriarepository.Add(auditLog);

            return Ok(bank);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Bank bank)
        {
            var cadastroExistente = _repository.FindById(bank.BankId).Result;
            if (cadastroExistente != null)
            {
                var auditLognull = new Auditoria
                {
                    acao = " Tentativa - CREATE",
                    detalhes = "Cadastro existente " + nameof(Bank) + " - Código identificador - " + bank.BankId.ToString("D3"),
                    dataHora = DateTime.UtcNow,
                    usuario = "API"
                };
                await _auditoriarepository.Add(auditLognull);


                return BadRequest("Cadastro existente");

            }

            bank.Name = bank.Name.Trim().ToUpper();
            bank.CreatedAt = DateTime.UtcNow;

            await _repository.Add(bank);

            // Cria o registro de auditoria utilizando o mesmo contexto
            var auditLog = new Auditoria
            {
                acao = "CREATE",
                detalhes = nameof(Bank) + " - Código identificador - " + bank.BankId.ToString("D3"),
                dataHora = bank.CreatedAt,
                usuario = "API"
            };
            await _auditoriarepository.Add(auditLog);

            return Ok(bank);
        }

       
    }
}
