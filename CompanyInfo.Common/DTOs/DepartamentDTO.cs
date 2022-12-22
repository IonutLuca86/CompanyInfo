
namespace CompanyInfo.Common.DTOs
{
    public class DepartamentDTO
    {
        public int Id { get; set; }
        public int DepartamentNameID { get; set; }
        public int CompanyID { get; set; }

        public DepartamentDTO(int id, int departamentNameID, int companyID)
        {
            Id = id;
            DepartamentNameID = departamentNameID;
            CompanyID = companyID;
        }
    }
}
