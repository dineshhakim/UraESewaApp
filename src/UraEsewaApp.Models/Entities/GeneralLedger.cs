using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UraEsewaApp.Models.Entities
{
    public class GeneralLedger : IEntity
    {
        [Column("GLId")]
        public int Id { get; set; }

        public string GlCode { get; set; }
        public string GLName { get; set; }

        public string GLType { get; set; }

        public int ParentGLId { get; set; }
    }
}
