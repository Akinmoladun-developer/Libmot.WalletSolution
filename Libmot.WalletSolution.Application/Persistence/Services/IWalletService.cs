using Libmot.WalletSolution.Application.DTOs.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Services
{
    public interface IWalletService
    {
        Task<WalletResponseDto> GetWalletByUserIdAsync(Guid userId);
        Task<WalletResponseDto> CreateWalletAsync(Guid userId);
        Task<decimal> GetBalanceAsync(Guid walletId);
        Task<bool> ActivateWalletAsync(Guid walletId);
        Task<bool> DeactivateWalletAsync(Guid walletId);
    }
}
