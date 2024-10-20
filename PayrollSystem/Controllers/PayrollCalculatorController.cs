using AdaptorPattern.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PayrollSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollCalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult<decimal> calculate(Employee employee)
        {
            var calculator = new PayrollCalculator();
            return Ok(calculator.Calculate(employee));
        }
    }
}
