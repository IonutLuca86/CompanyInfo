using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IDbService _db;
        public PositionsController(IDbService db) => _db = db;

        [HttpPost]
        public async Task<IResult> Post([FromBody] PositionDTO position) =>
            await _db.httpPostRefAsync<Position, PositionDTO>(position);

        [HttpDelete]
        public async Task<IResult> Delete(PositionDTO dto) =>
            await _db.httpDeleteAsync<Position, PositionDTO>(dto);
    }
}
