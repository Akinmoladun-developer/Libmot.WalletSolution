using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.DTOs.Payment
{
    public class InitiatePaymentRequestDto
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Provider { get; set; }   // Paystack
        public string Reference { get; set; }
    }
}
