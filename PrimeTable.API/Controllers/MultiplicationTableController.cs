using Microsoft.AspNetCore.Mvc;
using PrimeTable.Domain.Entities;
using PrimeTable.Domain.Interfaces;

namespace PrimeTable.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiplicationTableController : ControllerBase
    {

        private readonly IMultiplicationTableService _multiplicationTableService;

        public MultiplicationTableController(IMultiplicationTableService multiplicationTableService)
        {
            _multiplicationTableService = multiplicationTableService;
        }

        [HttpGet("{size}")]
        public ActionResult<MultiplicationTable> GetMultiplicationTable(int size)
        {
            try
            {
                var table = _multiplicationTableService.CreateMultiplicationTable(size);
                return Ok(table);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
