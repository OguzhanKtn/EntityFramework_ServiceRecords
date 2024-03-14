using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFServiceRecords.Models.ORM
{
    [Table("Invoices")]
    public class Invoice : BaseModel
    {
        public DateTime CreationDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int? ServiceRecordId { get; set; }
        public ServiceRecord ServiceRecord { get; set; }
    }
}
