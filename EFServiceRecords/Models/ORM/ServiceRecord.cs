using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFServiceRecords.Models.ORM
{
    [Table("Service_Records")]
    public class ServiceRecord : BaseModel
    {
        [MaxLength(50)]
        public string Brand { get; set; }
        [MaxLength(20)]
        public string DeviceType { get; set; }
        [MaxLength(20)]
        public string Model { get; set; }
        [MaxLength(20),Required]
        public string SerialNo { get; set; }
        [Required]
        public string FaultDescription { get; set; }
        public DateTime AcceptanceDate { get; set; }
        public DateTime EstimatedCompletionDate { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? ServiceStatusId { get; set; }
        public ServiceStatus ServiceStatus { get; set; }
    }
}
