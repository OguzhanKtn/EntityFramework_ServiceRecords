using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFServiceRecords.Models.ORM
{
    public class ServiceRecordsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-S5STNHF;Database=Service_Records;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<ServiceRecord> ServiceRecords { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<ServiceStatus> ServiceStatus { get; set; }
        public DbSet<WorkAssignment> WorkAssignments { get; set; }
    }
}
