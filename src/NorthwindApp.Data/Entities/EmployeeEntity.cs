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
        [Column(TypeName = "Date")]
        public DateTime? BirthDate { get; set; }
        [Column(TypeName = "Date")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public DateTime? HireDate { get; set; }
        [MaxLength(255)]
        public string? Address { get; set; }
        [MaxLength(50)]
        public string? Region { get; set; }
        [MaxLength(50)]
        public string? PostalCode { get; set; }
        [MaxLength(20)]
        public string? Country { get; set; }
        [MaxLength(20)]
        public string? HomePhone { get; set; }
        [MaxLength(255)]
        public string? Notes { get; set; }
    }
}
