using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UraEsewaApp.Models
{
    public class RequestType : IEntity
    {
        //Values: Topup, RechargeCard, Ticket
        [Column("RequestTypeId")]
        public int Id { get; set; }
        public string RequestName { get; set; }
    }
}
