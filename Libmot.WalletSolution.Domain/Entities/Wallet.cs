using Libmot.WalletSolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Libmot.WalletSolution.Domain.Entities
{
    public class Wallet : BaseEntity
    {
        public Guid UserId { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Currency { get; set; } = "NGN";
        public bool IsActive { get; set; } = true;

        // Navigation
        public User User { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Ledger> Ledgers { get; set; } = new List<Ledger>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
