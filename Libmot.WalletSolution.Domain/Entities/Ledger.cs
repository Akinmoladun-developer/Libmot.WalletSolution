using Libmot.WalletSolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Domain.Entities
{
    public class Ledger : BaseEntity
    {
        public Guid WalletId { get; set; }
        public Guid TransactionId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal BalanceBefore { get; set; }
        public decimal BalanceAfter { get; set; }

        // Navigation
        public Wallet Wallet { get; set; }
        public Transaction Transaction { get; set; }
    }
}
