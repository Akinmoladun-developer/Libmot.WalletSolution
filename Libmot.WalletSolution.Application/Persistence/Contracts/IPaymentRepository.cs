using Libmot.WalletSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Contracts
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
        Task<IReadOnlyList<Payment>> GetByWalletIdAsync(Guid walletId);
        Task<Payment> GetByReferenceAsync(string reference);
        Task<IReadOnlyList<Payment>> GetByProviderAsync(string provider);
        Task<IReadOnlyList<Payment>> GetByStatusAsync(string status);
    }
}
