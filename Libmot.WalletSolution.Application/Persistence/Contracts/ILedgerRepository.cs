using Libmot.WalletSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Contracts
{
    public interface ILedgerRepository : IGenericRepository<Ledger>
    {
        Task<IReadOnlyList<Ledger>> GetByWalletIdAsync(Guid walletId);
        Task<IReadOnlyList<Ledger>> GetByTransactionIdAsync(Guid transactionId);
        Task<Ledger> GetLatestByWalletIdAsync(Guid walletId);
        Task<IReadOnlyList<Ledger>> GetByWalletIdAndDateRangeAsync(Guid walletId, DateTime from, DateTime to);
    }
}
