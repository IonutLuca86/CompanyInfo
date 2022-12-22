

namespace CompanyInfo.Data.Entities
{
    public class Position : IReferenceEntity 
    {
        public int EmployeeId { get; set; }
        public int JobId { get; set; }

        public virtual Employee? Employee { get; set; }  
        public virtual Job? Job { get; set; }
    }
}
