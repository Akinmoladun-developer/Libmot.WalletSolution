using Libmot.WalletSolution.Domain.Common;
using Libmot.WalletSolution.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus Status { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }

        // Navigation
        public Wallet Wallet { get; set; }
        public ICollection<Ledger> Ledgers { get; set; } = new List<Ledger>();
        public ICollection<Refund> Refunds { get; set; } = new List<Refund>();
    }
}
