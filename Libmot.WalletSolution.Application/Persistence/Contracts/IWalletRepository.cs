using Libmot.WalletSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Contracts
{
    public interface IWalletRepository : IGenericRepository<Wallet>
    {
        Task<Wallet> GetByUserIdAsync(Guid userId);
        Task<Wallet> GetWalletWithTransactionsAsync(Guid walletId);
        Task<Wallet> GetWalletWithLedgersAsync(Guid walletId);
        Task UpdateBalanceAsync(Guid walletId, decimal newBalance);
        Task<bool> IsActiveAsync(Guid walletId);
    }
}
