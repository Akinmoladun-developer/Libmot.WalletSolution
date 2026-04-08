using Libmot.WalletSolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Provider { get; set; }  // Paystack or Flutterwave
        public string Status { get; set; }    // Pending, Successful, Failed
        public string Reference { get; set; }

        // Navigation
        public Wallet Wallet { get; set; }
    }
}
