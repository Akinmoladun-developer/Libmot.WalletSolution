using Libmot.WalletSolution.Domain.Entities;
using Libmot.WalletSolution.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Contracts
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Task<IReadOnlyList<Transaction>> GetByWalletIdAsync(Guid walletId);
        Task<Transaction> GetByReferenceAsync(string reference);
        Task<IReadOnlyList<Transaction>> GetByStatusAsync(TransactionStatus status);
        Task<IReadOnlyList<Transaction>> GetByTypeAsync(TransactionType transactionType);
        Task<IReadOnlyList<Transaction>> GetByWalletIdAndDateRangeAsync(Guid walletId, DateTime from, DateTime to);
        Task<Transaction> GetTransactionWithLedgersAsync(Guid transactionId);
    }
}
