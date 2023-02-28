using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Data.Entities
{
    [Table("Employees")]
    public class EmployeeEntity : BaseEntity
    {
        [MaxLength(20)]
        public string LastName { get; set; } = string.Empty;
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(255)]
        public string? Title { get; set; }
        [MaxLength(255)]
        public string? TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        [MaxLength(255)]
        public string? Address { get; set; }
        [MaxLength(100)]
        public string? City { get; set; }
        [MaxLength(100)]
        public string? Region { get; set; }
        [MaxLength(100)]
        public string? PostalCode { get; set; }
        [MaxLength(100)]
        public string? Country { get; set; }
        [MaxLength(20)]
        public string? HomePhone { get; set; }
        [MaxLength(20)]
        public string? Extension { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Photo { get; set; }
        [MaxLength(500)]
        public string? Notes { get; set; }
        [MaxLength(255)]
        public int? ReportsTo { get; set; }
        [MaxLength(255)]
        public string? PhotoPath { get; set; }
    }
}
