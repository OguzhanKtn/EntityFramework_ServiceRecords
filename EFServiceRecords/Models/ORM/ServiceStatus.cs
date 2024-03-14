using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFServiceRecords.Models.ORM
{
    [Table("Service_Status")]
    public class ServiceStatus : BaseModel
    {
        [MaxLength(50)]
        public string? StatusName { get; set; }
        public string? Description { get; set; }
    }
}
