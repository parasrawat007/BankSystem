using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankSystem.Models
{
    public class TransPresentmentHeader
    {
        public int TransHeadId { get; set; }
        public string FileNo { get; set; }
        public DateTime Date { get; set; }
        public string BankName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public string PresentmentHeaderNo { get; set; }

        public TransPresentmentHeader()
        {

        }

        public TransPresentmentHeader(params object[] data)
        {
            TransHeadId = Convert.ToInt32( data[0]);
            FileNo = data[1].ToString();
            Date = Convert.ToDateTime( data[2]);
            BankName = data[3].ToString();
            IsActive = Convert.ToBoolean(data[4]);
            IsDeleted =Convert.ToBoolean( data[5]);
            CreatedOn = Convert.ToDateTime(data[6]);
            PresentmentHeaderNo = data[7].ToString();
        }
    }
}