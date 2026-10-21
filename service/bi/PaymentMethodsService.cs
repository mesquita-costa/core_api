namespace core_api.service.bi
{
    public class PaymentMethodsService //formas de pagamento
    {
        public object GetData(string? period = null, string? branch = "", string? status = "")
        {
            return new
            {
                period = period ?? "01/08/2026 – 31/08/2026",
                branch = branch ?? "Matriz",
                status = status ?? "Vencido",

                kpis = new[]
                {
                new
                {
                    title = "Total Recebido",
                    value = "R$ 250K",
                    subtitle = "55% das transações",
                    iconName = "trending_up",
                    colorHex = "green"
                },

                new
                {
                    title = "N° de Transações",
                    value = "984",
                    subtitle = "25% das transações",
                    iconName = "menu_book",
                    colorHex = "orange"
                },

                new
                {
                    title = "Ticket Médio",
                    value = "R$ 208,33",
                    subtitle = "20% das transações",
                    iconName = "account_balance_wallet",
                    colorHex = "blue"
                }
            },

                revenueExpenses = Array.Empty<object>(),

                agingAccounts = Array.Empty<object>(),
                paymentMethodDistribution = new object[]
                {
                    new
                    {
                        paymentMethod = "PIX",
                        amount = 85000.0,
                        quantity = 412,
                        percentage = 41.0,
                        averageTicket = 206.31,
                        colorHex = "blue_accent"
                    },
                    new
                    {
                        paymentMethod = "Cartão",
                        amount = 62000.0,
                        quantity = 298,
                        percentage = 30.0,
                        averageTicket = 208.05,
                        colorHex = "blue"
                    },
                    new
                    {
                        paymentMethod = "Dinheiro",
                        amount = 35000.0,
                        quantity = 183,
                        percentage = 17.0,
                        averageTicket = 191.26,
                        colorHex = "green"
                    },
                    new
                    {
                        paymentMethod = "Transferência",
                        amount = 18000.0,
                        quantity = 67,
                        percentage = 9.0,
                        averageTicket = 268.66,
                        colorHex = "orange"
                    },
                    new
                    {
                        paymentMethod = "Outros",
                        amount = 5000.0,
                        quantity = 24,
                        percentage = 2.0,
                        averageTicket = 208.33,
                        colorHex = "grey"
                    }
                }
            };
        }
    }
}
