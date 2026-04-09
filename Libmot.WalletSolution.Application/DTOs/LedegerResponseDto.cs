using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.DTOs
{
    public class LedgerResponseDto
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public Guid TransactionId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal BalanceBefore { get; set; }
        public decimal BalanceAfter { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
