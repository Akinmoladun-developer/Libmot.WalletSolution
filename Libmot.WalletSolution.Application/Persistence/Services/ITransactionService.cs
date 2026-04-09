using Libmot.WalletSolution.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Services
{
    public interface ITransactionService
    {
        Task<TransactionResponseDto> CreditWalletAsync(CreditWalletRequestDto request);
        Task<TransactionResponseDto> DebitWalletAsync(DebitWalletRequestDto request);
        Task<TransactionResponseDto> GetTransactionByIdAsync(Guid transactionId);
        Task<TransactionResponseDto> GetTransactionByReferenceAsync(string reference);
        Task<IReadOnlyList<TransactionResponseDto>> GetTransactionsByWalletIdAsync(Guid walletId);
        Task<IReadOnlyList<TransactionResponseDto>> GetTransactionsByDateRangeAsync(Guid walletId, DateTime from, DateTime to);
    }
}
