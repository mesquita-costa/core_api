using core_api.service.bi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiController : ControllerBase
    {
        private readonly AccountsPayableService _accountspayableservice;
        private readonly AccountsReceivableService _accountsreceivableservice;
        private readonly FinancialCashFlowService _financialcashflowservice;
        private readonly FinancialOverviewService _financialoverviewservice;
        private readonly PaymentMethodsService _paymentmethodsservice;
        private readonly RevenueCategoryService _revenueCategoryService;
        private readonly ExpenseCategoryService _expansiveCategoryService;
        private readonly BiFilterOptionsService _biFilterOptionsService;
        public BiController(
            AccountsPayableService accountspayableservice,
            AccountsReceivableService accountsreceivableservice,
            FinancialCashFlowService financialcashflowservice,
            FinancialOverviewService financialoverviewservice,
            PaymentMethodsService paymentmethodsservice,
            RevenueCategoryService revenueCategoryService,
            ExpenseCategoryService expansiveCategoryService,
            BiFilterOptionsService biFilterOptionsService)
        {
            _accountspayableservice = accountspayableservice;
            _accountsreceivableservice = accountsreceivableservice;
            _financialcashflowservice = financialcashflowservice;
            _financialoverviewservice = financialoverviewservice;
            _paymentmethodsservice = paymentmethodsservice;
            _revenueCategoryService = revenueCategoryService;
            _expansiveCategoryService = expansiveCategoryService;
            _biFilterOptionsService = biFilterOptionsService;
        }

        [HttpGet]
        [Route("accounts-payable")]
        [EndpointSummary("contas a pagar")]
        public IActionResult GetData_accountspayableservice([FromQuery] string? period, string? branch, string? category, string? status)
        {
            var data = _accountspayableservice.GetData(period);

            return Ok(data);
        }
        [HttpGet]
        [Route("accounts-receivable")]
        [EndpointSummary("contas a receber")]
        public IActionResult GetData_accountsreceivableservice([FromQuery] string? period, string? branch, string? category, string? status)
        {
            var data = _accountsreceivableservice.GetData(period);

            return Ok(data);
        }
        [HttpGet]
        [Route("financial-cash-flow")]
        [EndpointSummary("fluxo de caixa projetado")]
        public IActionResult GetData_financialcashflowservice([FromQuery] string? period, string? branch, string? category, string? status)
        {
            var data = _financialcashflowservice.GetData(period);

            return Ok(data);
        }
        [HttpGet]
        [Route("financial-overview")]
        [EndpointSummary("visão geral financeira")]
        public IActionResult GetData_financialoverviewservice([FromQuery] string? period, string? branch, string? category, string? status)
        {
            return Ok(_financialoverviewservice.GetData(period, branch, category, status));
        }
        [HttpGet]
        [Route("payment-methods")]
        [EndpointSummary("Consultar métodos de pagamento")]
        public IActionResult GetData_paymentmethodsservice([FromQuery] string? period, string? branch, string? status)
        {
            return Ok(_paymentmethodsservice.GetData(period));
        }
        [HttpGet]
        [Route("revenue-category")]
        [EndpointSummary("Receitas por Categoria")]
        public IActionResult GetData_revenueCategoryService([FromQuery] string? period, string? branch,string? status)
        {
            return Ok(_revenueCategoryService.GetData(period));
        }
        [HttpGet]
        [Route("expense-category")]
        [EndpointSummary("Despesas por Categoria")]
        public IActionResult GetData_expansiveCategoryService([FromQuery] string? period, string? branch, string? status)
        {
            return Ok(_expansiveCategoryService.GetData(period));
        }
        [HttpGet]
        [Route("filter-options")]
        [EndpointSummary("Filtros BI Finaceiro")]
        public IActionResult GetData__biFilterOptionsService()
        {
            return Ok(_biFilterOptionsService.GetData());
        }

    }
}
