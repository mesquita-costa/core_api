namespace core_api.service.bi
{
    public class RevenueCategoryService // categorias de receita
    {
        public object GetData(string? period = null, string? branch = "", string? status = "")
        {
            return new
            {
                period = period ?? "01/08/2026 – 31/08/2026",
                branch = branch ?? "Matriz",
                status = status ?? "Vencido",
                totalRevenue = 397000.0,
                categoryRevenueDistribution = new object[]
                {
                    new
                    {
                        title = "Vendas",
                        amount = 350000.0,
                        percentage = 88.0,
                        colorHex = "blue",
                        subCategories = new object[]
                        {
                            new { title = "PDV", amount = 210000.0, percentage = 53.0 },
                            new { title = "Catálogo", amount = 90000.0, percentage = 23.0 },
                            new { title = "E-commerce", amount = 50000.0, percentage = 13.0 }
                        }
                    },
                    new
                    {
                        title = "Serviços",
                        amount = 35000.0,
                        percentage = 9.0,
                        colorHex = "teal",
                        subCategories = Array.Empty<object>()
                    },
                    new
                    {
                        title = "Outras Receitas",
                        amount = 12000.0,
                        percentage = 3.0,
                        colorHex = "indigo",
                        subCategories = Array.Empty<object>()
                    }
                }
            };
        }
    }
}