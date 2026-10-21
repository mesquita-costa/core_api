namespace core_api.service.bi
{
    public class AccountsPayableService //contas a pagar
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
                    title = "Total a Pagar",
                    value = "R$ 92.350",
                    subtitle = "Em aberto",
                    iconName = "menu_book",
                    colorHex = "pink"
                },

                new
                {
                    title = "Vencido",
                    value = "R$ 12.000",
                    subtitle = "Urgente",
                    iconName = "warning_amber_rounded",
                    colorHex = "red"
                },

                new
                {
                    title = "A Vencer",
                    value = "R$ 143.200",
                    subtitle = "Quitados",
                    iconName = "trending_down",
                    colorHex = "orange"
                },

                new
                {
                    title = "Vencendo em 7 dias",
                    value = "R$ 12.000",
                    subtitle = "Urgente",
                    iconName = "warning_amber_rounded",
                    colorHex = "red"
                },

                new
                {
                    title = "Vencendo em 30 dias",
                    value = "R$ 143.200",
                    subtitle = "Quitados",
                    iconName = "trending_down",
                    colorHex = "orange"
                }
            },

                revenueExpenses = Array.Empty<object>(),

                agingAccounts = new[]
                {
                new
                {
                    category = "Sem. 1",
                    amount = 28000.0,
                    colorHex = "red"
                },

                new
                {
                    category = "Sem. 2",
                    amount = 34000.0,
                    colorHex = "red"
                },

                new
                {
                    category = "Sem. 3",
                    amount = 39000.0,
                    colorHex = "red"
                },

                new
                {
                    category = "Sem. 4",
                    amount = 42000.0,
                    colorHex = "red"
                }
            },
                accountsPayable = new[]
                {
                new
                {
                    supplierName = "Boutique Bella",
                    documentNumber = 45821,
                    dueDate = "05/08/2026",
                    amount="8500.0",
                    status="Vencido"
                },
                new
                {
                    supplierName = "Moda & Arte",
                    documentNumber = 45821,
                    dueDate = "12/08/2026",
                    amount="4200.0",
                    status="A vencer"
                },
                new
                {
                    supplierName = "Fashion Store",
                    documentNumber = 45826,
                    dueDate = "25/08/2026",
                    amount="9500.0",
                    status="Vencido"
                },
                new
                {
                    supplierName = "Loja das Modas",
                    documentNumber = 55823,
                    dueDate = "15/08/2026",
                    amount="8990.0",
                    status="A vencer"
                },
                new
                {
                    supplierName = "Ateliê Chique",
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
