﻿using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler(ITransferRepository transferRepository) : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository = transferRepository;

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount,
                TransferDate = DateTime.Now
            });

            return Task.CompletedTask;
        }
    }
}
