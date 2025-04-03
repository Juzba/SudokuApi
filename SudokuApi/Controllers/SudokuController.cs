using Microsoft.AspNetCore.Mvc;
using SudokuApi.SudokuSolver;

namespace SudokuApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SudokuController : ControllerBase
    {
        static int _count = 0;

        [HttpPost("solve")]
        public IActionResult Post([FromBody] int[][][] data)
        {
            string returnedText = "Spuštěno Online: " + ++_count;

            try
            {

                if (data == null || data.Length != 9 || data[0].Length != 9 || data[0][0].Length != 10)
                {
                    return StatusCode(401, new { error = "Received data null or Array lenght is Wrong!" });
                }

                int[][][] returnedArray = SudokuMain.Main(data);

                return Ok(new { returnedArray, returnedText, success = true });


            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }



        [HttpPost("savedata")]

        public IActionResult SaveData([FromBody] int[][][] data)
        {



            try
            {
                if (data == null || data.Length != 9 || data[0].Length != 9 || data[0][0].Length != 10)
                {
                    return StatusCode(401, new { error = "Received data null or Array lenght is Wrong!" });
                }

                return Ok(new { success = true });



            }
            catch (Exception ex)
            {

                return StatusCode(500, new { ex.Message });
            }


        }



    }
}
