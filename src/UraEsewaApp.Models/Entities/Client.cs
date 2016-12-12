using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UraEsewaApp.Models
{
    [Table("Client")]
    public class Client : IEntity
    {
        [Column("ClientId")]
        public int Id { get; set; }

        [StringLength(10)]
        public string ClientCode { get; set; }

        [StringLength(100)]
        public string ClientName { get; set; }      

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(50)]
        public string ContactNo { get; set; }

        [StringLength(200)]
        public string Address { get; set; }      
        
        [StringLength(50)]
        public string EmaildId { get; set; }  
      
       
        [StringLength(100)]
        public string ContactPersonName { get; set; }        
        
        public decimal OutstandingBalance { get; set; }

        public string ClientGLCode { get; set; }




    }
}
