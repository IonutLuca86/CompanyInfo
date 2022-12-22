
namespace CompanyInfo.Data.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string? FirstName { get; set; }
        [MaxLength(50),Required]
        public string? LastName { get; set;}
        [Required]
        public decimal? Salary { get; set; }
        
        public bool? UnionMember { get; set; }
        [Required]
        public int DepartamentId { get; set; }
        public virtual Departament? Departament { get; set;}
        public virtual ICollection<Job>? Jobs { get; set; }

        
    }
}
