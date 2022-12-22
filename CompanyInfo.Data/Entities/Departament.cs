


namespace CompanyInfo.Data.Entities
{
    public class Departament : IReferenceEntity
    {
        public int Id { get; set; }
        public int DepartamentNameID { get; set; }
        public virtual DepartamentsName? DepartamentsName { get; set; }
        public int CompanyID { get; set; }
        public virtual Company? Company { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
