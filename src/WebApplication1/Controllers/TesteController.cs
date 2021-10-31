using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication1.Infra.CrossCutting.ClosedXml.Dtos;
using WebApplication1.Infra.CrossCutting.ClosedXml.Interfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly ICloseXml _closedXml;

        public TesteController(ICloseXml closedXml)
        {
            _closedXml = closedXml;
        }

        [HttpGet]
        [Route("xls")]
        public IActionResult ObterRelatorioXls()
        {
            try
            {
                var closedXml = new ClosedXmlDto
                {
                    Colunas = new List<string>
                    {
                        "ID",
                        "Nome",
                        "Data Cadastro"
                    }
                };

                _closedXml.GerarXls(closedXml);

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, new
                {
                    success = false,
                    errors = new List<string> { "Serviço indisponível, tente novamente mais tarde!" }
                });
            }
        }
    }
}
