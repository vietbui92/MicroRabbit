using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Microrabbit.Banking.Data.Context
{
    public class BankingDbContext(DbContextOptions<BankingDbContext> options) : DbContext(options)
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
