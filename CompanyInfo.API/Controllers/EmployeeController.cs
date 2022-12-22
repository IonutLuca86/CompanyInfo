using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeeController(IDbService db) => _db = db;
        //GET: api/<CompanyController>
        [HttpGet]
        public async Task<IResult> Get() =>
           await _db.httpGetAllAsync<Employee, EmployeeDTO>();


        //GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.httpGetOneAsync<Employee, EmployeeDTO>(id);


        // POST api/<CompanyController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeeDTO employee) =>
            await _db.httpPostAsync<Employee, EmployeeDTO>(employee);

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] EmployeeDTO employee) =>
            await _db.httpPutAsync<Employee, EmployeeDTO>(id, employee);

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.httpDeleteAsync<Employee>(id);

        [HttpGet("Full")]
        public async  Task<IResult> GetFull() => await _db.httpGetFull();
       
    }
}
