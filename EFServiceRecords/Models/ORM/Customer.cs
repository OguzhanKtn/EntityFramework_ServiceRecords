using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFServiceRecords.Models.ORM
{

    [Table("Customers")]
    public class Customer:BaseModel
    {
        [MaxLength(50),Required]
        public string Name { get; set; }
        [MaxLength(50),Required]
        public string Surname { get; set; }
        [MaxLength(13)]
        public string? Phone { get; set; }
        [MaxLength(50),EmailAddress,Required]
        public string Email { get; set; }
        public string? Address { get; set; }

    }
}
