using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.DTOs.Transaction
{
    public class DebitWalletRequestDto
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
    }
}
