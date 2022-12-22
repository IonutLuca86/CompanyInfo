

using System.ComponentModel.DataAnnotations;

namespace CompanyInfo.Common.DTOs
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? OrganisationNumber { get; set; }
        public string? MainOffice { get; set; }
    }
}
