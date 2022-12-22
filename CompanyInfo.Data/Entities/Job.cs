

namespace CompanyInfo.Data.Entities
{
    public class Job : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string? JobName { get; set; }
        [MaxLength(100)]
        public string? JobDescription { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; }

    }
}
