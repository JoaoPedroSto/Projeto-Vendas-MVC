using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoVendasMVC.Models.ViewModels;

namespace ProjetoVendasMVC.Data
{
    public class ProjetoVendasMVCContext : DbContext
    {
        public ProjetoVendasMVCContext (DbContextOptions<ProjetoVendasMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoVendasMVC.Models.ViewModels.Departament> Departament { get; set; }
    }
}
