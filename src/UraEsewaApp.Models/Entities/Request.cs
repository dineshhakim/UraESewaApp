using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UraEsewaApp.Models
{
    public class Request : IEntity
    {
        [Column("RequestId")]
        public int Id { get; set; }

        public int CompanyId { get; set; }


        public int RequestTypeId { get; set; }
        [ForeignKey("RequestTypeId")]
        public RequestType RequestType { get; set; }

        public string Token { get; set; }

        public string JsonData { get; set; }

        public double Amount { get; set; }

        public DateTime RequestDate { get; set; }

        public int RequestedBy { get; set; }

        public DateTime ModifiedDate { get; set; }


        public int RequestStatusId { get; set; }
        [ForeignKey("RequestStatusId")]
        public RequestStatus RequestStatus { get; set; }

        public string VoucherNo { get; set; }

        public string ReferenceId { get; set; }
    }
}
