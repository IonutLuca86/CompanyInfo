using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.Data.Entities
{
    public class FullEmployee : IEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Salary { get; set; }
        public bool? UnionMember { get; set; }
        public string? DepartamentName { get; set; }
        public string? Company { get; set; }
        public string? Office { get; set; }
        public string? JobTitle { get; set; }
    }
}
