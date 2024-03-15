using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFServiceRecords.Models.ORM
{
    [Table("Work_Assignments")]
    public class WorkAssignment:BaseModel
    {
        public int? StaffId { get; set; }
        public Staff? Staff { get; set; }
        public int? ServiceRecordId { get; set; }
        public ServiceRecord? ServiceRecord { get; set; }
    }
}
