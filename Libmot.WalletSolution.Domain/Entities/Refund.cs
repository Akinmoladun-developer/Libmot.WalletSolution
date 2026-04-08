using Libmot.WalletSolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Domain.Entities
{
    public class Refund : BaseEntity
    {
        public Guid TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }

        // Navigation
        public Transaction Transaction { get; set; }
    }
}
