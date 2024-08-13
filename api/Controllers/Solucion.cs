using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using api.Models;
using Dapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace api.Controllers
{
    [ApiController]
    [Route("programa/algoritmo/solucion")]
    public class Solucion : ControllerBase
    {
        private readonly Sections sections;

        public Solucion(Sections sections)
        {
            this.sections = sections;
        }
        [HttpPost]
        public async Task<Result> Solucion1([FromBody] SolucionDto solucionDto)
        {
            var resultado = sections.problem2(solucionDto.Valor1, solucionDto.Valor2);

            var result = new Result
            {
                Status = 1,
                Message = "resultado procesado",
                Data = resultado
            };

            var connection = new MySqlConnection("Server=localhost; User=root; Password=; Database=persistencia");
            await connection.OpenAsync();

            var sql = "INSERT INTO persistencia (request, response, usuario) VALUES (@Request, @Response, @Usuario)";
            string request = JsonSerializer.Serialize(solucionDto);
            string response = JsonSerializer.Serialize(result);
            var values = new Persistencia { Request = request, Response = response, Usuario = "ali" };
            var insert = await connection.ExecuteAsync(sql, values);

            return result;
        }
    }
    public class SolucionDto
    {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public string Usuario { get; set; }
    }
    public class Result
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
    }
}