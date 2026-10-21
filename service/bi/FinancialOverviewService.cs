namespace core_api.service.bi
{
    public class FinancialOverviewService //visão geral financeira
    {
        public object GetData(string? period = null, string? branch="", string? category = "", string? status = "")
        {
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
                    title = "A Receber",
                    value = "R$ 185.000",
                    subtitle = "12,5% do total",
                    iconName = "account_balance_wallet",
                    colorHex = "blue"
                },
                new
                {
                    title = "A Pagar",
                    value = "R$ 92.350",
                    subtitle = "6,3% do total",
                    iconName = "menu_book",
                    colorHex = "pink"
                },
                new
                {
                    title = "Recebido",
                    value = "R$ 210.800",
                    subtitle = "+8,4% vs. ant.",
                    iconName = "trending_up",
                    colorHex = "green"
                },
                new
                {
                    title = "Pago",
                    value = "R$ 143.200",
                    subtitle = "+5,1% vs. ant.",
                    iconName = "trending_down",
                    colorHex = "orange"
                },
                new
                {
                    title = "Vencido",
                    value = "R$ 25.770",
                    subtitle = "3 documentos",
                    iconName = "warning_amber_rounded",
                    colorHex = "red"
                },
                new
                {
                    title = "Resultados",
                    value = "R$ 25.770",
                    subtitle = "3 documentos",
                    iconName = "warning_amber_rounded",
                    colorHex = "red"
                }
            },

                revenueExpenses = new[]
                {
                new
                {
                    label = "Semana 1",
                    revenue = 42.0,
                    expense = 30.0
                },
                new
                {
                    label = "Semana 2",
                    revenue = 48.0,
                    expense = 35.0
                },
                new
                {
                    label = "Semana 3",
                    revenue = 52.0,
                    expense = 30.0
                },
                new
                {
                    label = "Semana 4",
                    revenue = 60.0,
                    expense = 35.0
                }
            },

                // Contas vencidas
                agingAccounts = new[]
                {
                new
                {
                    category = "A Vencer",
                    amount = 250.0,
                    colorHex = "blue"
                },
                new
                {
                    category = "Vencido 7d",
                    amount = 30.0,
                    colorHex = "orange"
                },
                new
                {
                    category = "Vencido 15d",
                    amount = 100.0,
                    colorHex = "orange"
                },
                new
                {
                    category = "Vencido 30d",
                    amount = 60.0,
                    colorHex = "orange"
                },
                new
                {
                    category = "Vencido",
                    amount = 30.0,
                    colorHex = "red"
                }
            },

                // Principais receitas
                mainRevenues = new[]
                {
                new
                {
                    title = "Vendas",
                    percentage = 0.80,
                    amount = 120000.0,
                    colorHex = "green"
                },
                new
                {
                    title = "Serviços",
                    percentage = 0.90,
                    amount = 65000.0,
                    colorHex = "green"
                },
                new
                {
                    title = "Outras",
                    percentage = 0.30,
                    amount = 65000.0,
                    colorHex = "green"
                }
            },

                // Principais despesas
                mainExpenses = new[]
                {
                new
                {
                    title = "Fornecedores",
                    percentage = 0.56,
                    amount = 120000.0,
                    colorHex = "red"
                },
                new
                {
                    title = "Pessoal",
                    percentage = 0.21,
                    amount = 45000.5,
                    colorHex = "red"
                },
                new
                {
                    title = "Impostos",
                    percentage = 0.10,
                    amount = 22000.5,
                    colorHex = "red"
                },
                new
                {
                    title = "Serviços",
                    percentage = 0.08,
                    amount = 18000.0,
                    colorHex = "red"
                },
                new
                {
                    title = "Outras",
                    percentage = 0.05,
                    amount = 10000.0,
                    colorHex = "red"
                }
            }
            };
        }
    }
}
