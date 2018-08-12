using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        //GET api/values/soma/5/5
        [HttpGet("soma/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Soma(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = Convert.ToDecimal(primeiroNumero) + Convert.ToDecimal(segundoNumero);
                return Ok(sum.ToString());
            }
            return BadRequest("Entrada de dados inválida!");
        }

        //GET api/values/subtracao/5/5
        [HttpGet("subtracao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Subtracao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = Convert.ToDecimal(primeiroNumero) - Convert.ToDecimal(segundoNumero);
                return Ok(sum.ToString());
            }
            return BadRequest("Entrada de dados inválida!");
        }

        //GET api/values/multiplicacao/5/5
        [HttpGet("multiplicacao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Multiplicacao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = Convert.ToDecimal(primeiroNumero) - Convert.ToDecimal(segundoNumero);
                return Ok(sum.ToString());
            }
            return BadRequest("Entrada de dados inválida!");
        }

        //GET api/values/divisao/5/5
        [HttpGet("divisao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Divisao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var sum = Convert.ToDecimal(primeiroNumero) - Convert.ToDecimal(segundoNumero);
                return Ok(sum.ToString());
            }
            return BadRequest("Entrada de dados inválida!");
        }
        private bool IsNumeric(string number)
        {
            decimal retorno;
            bool isNumber = decimal.TryParse(number, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retorno);
            return isNumber;
        }
    }
}