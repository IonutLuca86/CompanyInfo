﻿

using System.ComponentModel.DataAnnotations;

namespace CompanyInfo.Common.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Salary { get; set; }
        public bool? UnionMember { get; set; }
        public int DepartamentId { get; set; }
       
    }
}
