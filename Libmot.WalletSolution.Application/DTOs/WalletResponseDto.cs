using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.DTOs
{
    public class WalletResponseDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string OwnerFullName { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
