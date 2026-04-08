using Libmot.WalletSolution.Application.DTOs.Ledger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Services
{
    public interface ILedgerService
    {
        Task<IReadOnlyList<LedgerResponseDto>> GetLedgerByWalletIdAsync(Guid walletId);
        Task<IReadOnlyList<LedgerResponseDto>> GetLedgerByDateRangeAsync(Guid walletId, DateTime from, DateTime to);
        Task<LedgerResponseDto> GetLatestEntryAsync(Guid walletId);
    }
}
