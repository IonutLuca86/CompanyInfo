

namespace CompanyInfo.Data.Entities
{
    public class DepartamentsName : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string? DepartamentName { get; set; }
        public virtual ICollection<Departament>? Departaments { get; set; }
    }
}
