using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.DTOs.Payment
{
    public class PaymentResponseDto
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }
        public string Reference { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
