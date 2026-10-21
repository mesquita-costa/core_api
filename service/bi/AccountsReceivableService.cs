namespace core_api.service.bi
{
    public class AccountsReceivableService //contas a receber
    {
        public object GetData(string? period = null, string? branch = "", string? category = "", string? status = "")
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
                    title = "Total a Receber",
                    value = "R$ 185.420",
                    subtitle = "Carteira aberta",
                    iconName = "account_balance_wallet",
                    colorHex = "blue"
                },

                new
                {
                    title = "Vencido",
                    value = "R$ 25.770",
                    subtitle = "Em atraso",
                    iconName = "warning_amber_rounded",
                    colorHex = "red"
                },

                new
                {
                    title = "A Vencer",
                    value = "R$ 210.800",
                    subtitle = "Baixados",
                    iconName = "trending_up",
                    colorHex = "green"
                },

                new
                {
                    title = "Vencendo em 7 dias",
                    value = "R$ 185.420",
                    subtitle = "Carteira aberta",
                    iconName = "account_balance_wallet",
                    colorHex = "blue"
                },

                new
                {
                    title = "Vencendo em 30 dias",
                    value = "R$ 25.770",
                    subtitle = "Em atraso",
                    iconName = "warning_amber_rounded",
                    colorHex = "red"
                },

                new
                {
                    title = "Inadimplência",
                    value = "R$ 210.800",
                    subtitle = "Baixados",
                    iconName = "trending_up",
                    colorHex = "pink"
                }
            },

                revenueExpenses = Array.Empty<object>(),

                agingAccounts = new[]
                {
                new
                {
                    category = "A vencer",
                    amount = 185420.0,
                    colorHex = "blue"
                },

                new
                {
                    category = "1–7 dias",
                    amount = 32000.0,
                    colorHex = "orange"
                },

                new
                {
                    category = "8–30 dias",
                    amount = 28000.0,
                    colorHex = "deepOrange"
                },

                new
                {
                    category = "31–60 dias",
                    amount = 18000.0,
                    colorHex = "red"
                },

                new
                {
                    category = "61–90 dias",
                    amount = 8000.0,
                    colorHex = "brown"
                },

                new
                {
                    category = "+90 dias",
                    amount = 4000.0,
                    colorHex = "darkBrown"
                }
            },


                accountsReceivable = new[]
                {
                new
                {
                    clientName = "Boutique Bella",
                    documentNumber = 45821,
                    dueDate = "05/08/2026",
                    amount="8500.0",
                    status="Vencido"
                },
                new
                {
                    clientName = "Moda & Arte",
                    documentNumber = 45821,
                    dueDate = "12/08/2026",
                    amount="4200.0",
                    status="A vencer"
                },
                new
                {
                    clientName = "Fashion Store",
                    documentNumber = 45826,
                    dueDate = "25/08/2026",
                    amount="9500.0",
                    status="Vencido"
                },
                new
                {
                    clientName = "Loja das Modas",
                    documentNumber = 55823,
                    dueDate = "15/08/2026",
                    amount="8990.0",
                    status="A vencer"
                },
                new
                {
                    clientName = "Ateliê Chique",
                    documentNumber = 45821,
                    dueDate = "05/08/2026",
                    amount="8500.0",
                    status="Vencido"
                },

            }

            };
        }
    }
}
