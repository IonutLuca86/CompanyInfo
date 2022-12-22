




namespace CompanyInfo.Data.Entities
{
    public class Company: IEntity
    {
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string? CompanyName { get; set; }
        [MaxLength(20),Required]
        public string? OrganisationNumber { get; set;}
        [MaxLength(50)]
        public string? MainOffice { get; set; }

        public virtual ICollection<Departament>? Departaments { get; set;}
    }
}
