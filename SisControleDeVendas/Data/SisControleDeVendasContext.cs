using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisControleDeVendas.Models;

namespace SisControleDeVendas.Data
{
    public class SisControleDeVendasContext : DbContext
    {
        public SisControleDeVendasContext (DbContextOptions<SisControleDeVendasContext> options)
            : base(options)
        {
        }

        public DbSet<SisControleDeVendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<SisControleDeVendas.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<SisControleDeVendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<SisControleDeVendas.Models.Venda> Venda { get; set; } = default!;
    }
}
