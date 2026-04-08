using Libmot.WalletSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.Persistence.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByPhoneNumberAsync(string phoneNumber);
        Task<User> GetUserWithWalletAsync(Guid userId);
        Task<bool> EmailExistsAsync(string email);
    }
}
