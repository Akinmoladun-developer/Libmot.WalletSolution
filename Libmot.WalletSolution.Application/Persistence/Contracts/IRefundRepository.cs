using Libmot.WalletSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Contracts
{
    public interface IRefundRepository : IGenericRepository<Refund>
    {
        Task<IReadOnlyList<Refund>> GetByTransactionIdAsync(Guid transactionId);
        Task<IReadOnlyList<Refund>> GetByStatusAsync(string status);
    }
}
