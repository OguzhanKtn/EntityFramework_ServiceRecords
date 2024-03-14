using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFServiceRecords.Models.ORM
{
    [Table("Spare_Parts")]
    public class SparePart : BaseModel
    {
        [MaxLength(50),Required]
        public string Name { get; set; }
        [MaxLength(50), Required]
        public string Brand { get; set; }
        [MaxLength(50), Required]
        public string Model { get; set; }
        public int? UnitsInStock { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
