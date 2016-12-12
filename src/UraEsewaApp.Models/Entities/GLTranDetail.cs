using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UraEsewaApp.Models.Entities
{
    public class GLTranDetail : IEntity
    {
        [Column("GLTranDetailId")]
        public int Id { get; set; }


        public double DRAmt { get; set; }

        public double CRAmt { get; set; }

      
        public int GLTranMastId { get; set; }

        [ForeignKey("GLTranMastId")]
        public GLTranMast GLTranMast { get; set; }

      
        public int GLId { get; set; }
        [ForeignKey("GLId")]
        public string GeneralLedger { get; set; }
    }
}
