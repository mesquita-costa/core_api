namespace core_api.service.bi
{
    public class FinancialCashFlowService //fluxo de caixa projetado
    {
        public object GetData(string? period = null, string? branch = "", string? category = "", string? status = "")
        {
            var baseCashFlow = new[]
            {
                    new { period = "semana 1", revenue = 220000.0, expense = 120000.0 },
                    new { period = "semana 2", revenue = 320000.0, expense = 120000.0 },
                    new { period = "semana 3", revenue = 420000.0, expense = 120000.0 },
                    new { period = "semana 4", revenue = 520000.0, expense = 120000.0 },
                    new { period = "semana 5", revenue = 620000.0, expense = 120000.0 }
                };

            var cashFlowItems = baseCashFlow
                .Select(i => new
                {
                    i.period,
                    i.revenue,
                    i.expense,
                    result = i.revenue - i.expense,
                    margin = i.revenue != 0
                        ? $"{Math.Round((i.revenue - i.expense) / i.revenue * 100, 2)}%"
                        : "0%"
                })
                .ToArray();

            return new
            {
                period = period ?? "01/08/2026 – 31/08/2026",
                branch = branch ?? "Matriz",
                category = category ?? "Todas",
                status = status ?? "Vencido",

                kpis = new[]
                {
                        new
                        {
                            title = "Entradas Projetadas",
                            value = "R$ 220.000",
                            subtitle = "Previsto",
                            iconName = "trending_up",
                            colorHex = "green"
                        },

                        new
                        {
                            title = "Saídas Projetadas",
                            value = "R$ 110.000",
                            subtitle = "Previsto",
                            iconName = "trending_down",
                            colorHex = "orange"
                        },

                        new
                        {
                            title = "Resultado Projetado",
                            value = "R$ 110.000",
                            subtitle = "Resultado",
                            iconName = "account_balance_wallet",
                            colorHex = "blue"
                        }
                    },

                revenueExpenses = new[] //receitas /despesas
                {
                        new { label = "Semana 1", revenue = 55.0, expense = 28.0 },
                        new { label = "Semana 2", revenue = 60.0, expense = 30.0 },
                        new { label = "Semana 3", revenue = 50.0, expense = 25.0 },
                        new { label = "Semana 4", revenue = 55.0, expense = 27.0 }
                    },

                cashFlowItems
            };
        }
    }
}
