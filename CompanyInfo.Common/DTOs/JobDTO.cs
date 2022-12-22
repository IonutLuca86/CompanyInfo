

using System.ComponentModel.DataAnnotations;

namespace CompanyInfo.Common.DTOs
{
    public class JobDTO
    {
        public int Id { get; set; }
        public string? JobName { get; set; }
        public string? JobDescription { get; set; }
    }
}
