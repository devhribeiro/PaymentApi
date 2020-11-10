using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Models {
    public class PaymentDetail 
    {
        [Key]
        public int PmId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwerName { get; set; }
        [Required]
        [Column(TypeName = "varchar(16)")]
        public string CardName { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ExpitarionDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }
    }
}
