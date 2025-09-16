using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService(ITransferRepository transferRepository) : ITransferService
    {
        private readonly ITransferRepository _transferRepository = transferRepository;

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLog();
        }

        public void Transfer(TransferLog transferLog)
        {
            throw new NotImplementedException();
        }

    }
}
