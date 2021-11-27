using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(firstNumber))
            {
                var sum = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input.");
        }

        [HttpGet("subtract/{firstNumber}/{secondNumber}")]
        public IActionResult GetSubtract(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(firstNumber))
            {
                var sub = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid input.");
        }

        [HttpGet("multiplies/{firstNumber}/{secondNumber}")]
        public IActionResult GetMultiplies(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(firstNumber))
            {
                var mult = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);
                return Ok(mult.ToString());
            }
            return BadRequest("Invalid input.");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult GetDivision(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(firstNumber) && !IsZero(secondNumber))
            {
                var div = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);
                return Ok(div.ToString());
            }
            return BadRequest("Invalid input.");
        }

        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult GetAverage(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(firstNumber))
            {
                var avg = (Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber)) / 2;
                return Ok(avg.ToString());
            }
            return BadRequest("Invalid input.");
        }

        [HttpGet("squareroot/{number}")]
        public IActionResult GetSquareRoot(string number)
        {
            if (IsNumeric(number))
            {
                var sqr = Convert.ToDouble(number);
                return Ok(Math.Sqrt(sqr).ToString());
            }
            return BadRequest("Invalid input.");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            return double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        }

        private bool IsZero(string strNumber)
        {
            if (double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out double number))
            {
                if (number != 0)
                    return false;
            }

            return true;
        }
    }
}