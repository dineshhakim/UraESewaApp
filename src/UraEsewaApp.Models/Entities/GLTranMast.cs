using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UraEsewaApp.Models.Entities
{
    public class GLTranMast : IEntity
    {
        [Column("GLTranMastId")]
        public int Id { get; set; }

        public string VoucherNo { get; set; }

        public DateTime TransactionDate { get; set; }

       
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public List<GLTranDetail> GLTranDetails { get; set; }
    }
}
