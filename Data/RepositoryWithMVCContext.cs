#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryWithMVC.Models;

namespace RepositoryWithMVC.Data
{
    public class RepositoryWithMVCContext : DbContext
    {
        public RepositoryWithMVCContext (DbContextOptions<RepositoryWithMVCContext> options)
            : base(options)
        {
        }

        public DbSet<RepositoryWithMVC.Models.Account> Account { get; set; }

        public DbSet<RepositoryWithMVC.Models.Customer> Customer { get; set; }
    }
}
