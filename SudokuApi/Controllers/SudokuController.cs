using Microsoft.AspNetCore.Mvc;

namespace SudokuApi.Controllers
{

    [ApiController]
    [Route("api[controller]")]
    public class SudokuController : ControllerBase
    {
        [HttpPost("sudokusolver")]
        public IActionResult Post([FromBody] int[][][] data)
        {


            try
            {

                foreach (var matrix in data)
                {
                    foreach (var array in matrix)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = 5;
                        }
                    }
                }

                return Ok(new { result = data });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { error = ex.Message });
            }






        }




    }
}
