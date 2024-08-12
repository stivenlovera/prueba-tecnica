using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("programa/algoritmo/solucion")]
    public class Solucion : ControllerBase
    {
        [HttpPost]
        public Result Solucion1([FromBody] SolucionDto solucionDto)
        {
            var algoritmo = new Sections();
            var resultado = algoritmo.problem2(solucionDto.Valor1, solucionDto.Valor2);
            return new Result
            {
                Status = 1,
                Message = "resultado procesado",
                Data = resultado
            };
        }
    }
    public class SolucionDto
    {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
    }
    public class Result
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
    }
}