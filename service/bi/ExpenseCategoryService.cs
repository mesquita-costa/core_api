namespace core_api.service.bi
{
    public class ExpenseCategoryService // categorias de receita
    {
        public object GetData(string? period = null, string? branch = "", string? status = "")
        {
            return new
            {
                period = period ?? "01/08/2026 – 31/08/2026",
                branch = branch ?? "Matriz",
                status = status ?? "Vencido",

                totalRevenue = 397000.0,
                categoryExpenseDistribution = new object[]
                {
                    new
                    {
                        title = "Fornecedores",
                        amount = 150000.0,
                        percentage = 58.0,
                        colorHex = "red",
                        subCategories = new object[]
                        {
                            new { title = "Materia-prima", amount = 110000.0, percentage = 33.0 },
                            new { title = "Embalagens", amount = 90000.0, percentage = 23.0 },
                           
                        }
                    },
                    new
                    {
                        title = "Pessoal",
                        amount = 35000.0,
                        percentage = 9.0,
                        colorHex = "teal",
                        subCategories = Array.Empty<object>()
                    },
                    new
                    {
                        title = "Impostos",
                        amount = 12000.0,
                        percentage = 3.0,
                        colorHex = "indigo",
                        subCategories = Array.Empty<object>()
                    },
                      new
                    {
                        title = "Serviços",
                        amount = 12000.0,
                        percentage = 3.0,
                        colorHex = "indigo",
                        subCategories = Array.Empty<object>()
                    },
                        new
                    {
                        title = "Outras",
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