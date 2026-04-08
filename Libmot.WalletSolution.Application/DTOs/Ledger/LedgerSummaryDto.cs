using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.DTOs.Ledger
{
    public class LedgerSummaryDto
    {
        public Guid WalletId { get; set; }
        public decimal TotalCredit { get; set; }
        public decimal TotalDebit { get; set; }
        public decimal CurrentBalance { get; set; }
        public int TotalTransactionCount { get; set; }
        public DateTime LastTransactionDate { get; set; }
    }
}
