using Libmot.WalletSolution.Application.DTOs.Refund;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Services
{
    public interface IRefundService
    {
        Task<RefundResponseDto> InitiateRefundAsync(InitiateRefundRequestDto request);
        Task<RefundResponseDto> GetRefundByIdAsync(Guid refundId);
        Task<IReadOnlyList<RefundResponseDto>> GetRefundsByTransactionIdAsync(Guid transactionId);
    }
}
