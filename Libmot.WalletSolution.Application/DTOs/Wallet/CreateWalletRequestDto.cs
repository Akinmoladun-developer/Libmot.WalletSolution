using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.DTOs.Wallet
{
    public class CreateWalletRequestDto
    {
        public Guid UserId { get; set; }
        public string Currency { get; set; } = "NGN";
    }
}
