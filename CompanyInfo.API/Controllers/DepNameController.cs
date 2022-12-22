using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepNameController : ControllerBase
    {
        private readonly IDbService _db;
        public DepNameController(IDbService db) => _db = db;
        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.httpGetAllAsync<DepartamentsName, DepartamentsNameDTO>();

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.httpGetOneAsync<DepartamentsName, DepartamentsNameDTO>(id);

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] DepartamentsNameDTO departamentName) =>
            await _db.httpPostAsync<DepartamentsName, DepartamentsNameDTO>(departamentName);

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] DepartamentsNameDTO departamentName) =>
            await _db.httpPutAsync<DepartamentsName, DepartamentsNameDTO>(id, departamentName);

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.httpDeleteAsync<DepartamentsName>(id);
    }
}
