using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentController : ControllerBase
    {
        private readonly IDbService _db;
        public DepartamentController(IDbService db) => _db = db;
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.httpConnectionGetAllAsync<Departament, DepartamentDTO>();

        [HttpPost]
        public async Task<IResult> Post([FromBody] DepartamentDTO departament) =>
            await _db.httpPostRefAsync<Departament, DepartamentDTO>(departament);

        [HttpDelete]
        public async Task<IResult> Delete(DepartamentDTO departament) =>
            await _db.httpDeleteAsync<Departament, DepartamentDTO>(departament);
    }
}
