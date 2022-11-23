using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacioneiAqui.Models;
using Microsoft.EntityFrameworkCore;

namespace EstacioneiAqui.Context
{
    public class EstacionamentoContext : DbContext
    {
        public EstacionamentoContext(DbContextOptions<EstacionamentoContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}