using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortalChamado.Models;

namespace PortalChamado.Data
{
    public class PortalChamadoContext : DbContext
    {
        public PortalChamadoContext (DbContextOptions<PortalChamadoContext> options)
            : base(options)
        {
        }

        public DbSet<PortalChamado.Models.Acesso> Acesso { get; set; }
    }
}
