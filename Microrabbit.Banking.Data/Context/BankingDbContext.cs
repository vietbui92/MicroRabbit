using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Microrabbit.Banking.Data.Context
{
    public class BankingDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
