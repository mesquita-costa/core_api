using core_api.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace core_api.Infra
{
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Auditoria> Auditorias { get; set; }
        //public virtual DbSet<FormaPagamento> FormaPagamentos { get; set; }
        //  public virtual DbSet<Finalizadora> Finalizadoras { get; set; }
        //  public virtual DbSet<FinalizadoraPagamento> FinalizadoraPagamentos { get; set; }


    }
}
