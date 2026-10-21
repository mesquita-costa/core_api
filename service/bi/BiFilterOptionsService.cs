namespace core_api.service.bi
{
    public class BiFilterOptionsService // Opções de filtros do BI
    {
        public object GetData()
        {
            return new
            {
                branches = new string[]
                {
                    "Todas as Filiais",
                    "Filial Centro",
                    "Filial Norte",
                    "Filial Sul"
                },
                categories = new string[]
                {
                    "Todas as Categorias",
                    "Vendas",
                    "Serviços",
                    "Outras Receitas"
                },
                statuses = new string[]
                {
                    "Todos os Status",
                    "Ativos",
                    "Pendentes",
                    "Cancelados"
                }
            };
        }
    }
}