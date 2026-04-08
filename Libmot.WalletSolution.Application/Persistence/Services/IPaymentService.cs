using Libmot.WalletSolution.Application.DTOs.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Services
{
    public interface IPaymentService
    {
        Task<PaymentResponseDto> InitiatePaymentAsync(InitiatePaymentRequestDto request);
        Task<PaymentResponseDto> VerifyPaymentAsync(string reference);
        Task<IReadOnlyList<PaymentResponseDto>> GetPaymentsByWalletIdAsync(Guid walletId);
    }
}
