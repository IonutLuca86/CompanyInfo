

namespace CompanyInfo.Common.DTOs
{
    public class PositionDTO
    {
        public int EmployeeId { get; set; }
        public int JobId { get; set; }

        public PositionDTO(int employeeId, int jobId)
        {
            EmployeeId = employeeId;
            JobId = jobId;
        }
    }
}
