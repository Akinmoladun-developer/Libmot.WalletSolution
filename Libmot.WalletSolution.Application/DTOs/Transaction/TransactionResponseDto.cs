using Libmot.WalletSolution.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libmot.WalletSolution.Application.DTOs.Transaction
{
    public class TransactionResponseDto
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus Status { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
