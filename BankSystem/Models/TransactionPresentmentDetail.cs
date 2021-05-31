using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankSystem.Models
{
    public class TransactionPresentmentDetail
    {
        public int PId { get; set; }
        public Decimal Amount { get; set; }

        public int TransHeadId { get; set; }
        public string FileNo { get; set; }
        public string BankName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public string PresentmentHeaderNo { get; set; }
    }
}