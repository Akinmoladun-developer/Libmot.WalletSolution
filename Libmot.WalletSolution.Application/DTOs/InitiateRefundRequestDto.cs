using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.DTOs
{
    public class InitiateRefundRequestDto
    {
        public Guid TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
    }
}
