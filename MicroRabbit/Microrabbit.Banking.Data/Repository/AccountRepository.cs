using Microrabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;

namespace Microrabbit.Banking.Data.Repository
{
    public class AccountRepository(BankingDbContext ctx) : IAccountRepository
    {
        private BankingDbContext _ctx = ctx;

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
