using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UraEsewaApp.Models
{
    public class RequestStatus : IEntity
    {
        [Column("RequestStatusId")]
        public int Id { get; set; }

        public string RequestStatusName { get; set; }
    }
}
