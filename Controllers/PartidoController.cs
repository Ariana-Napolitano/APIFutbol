using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using Futbol.Model;
using Futbol.Services;



namespace Futbol.Controllers
{
    [ApiController]
    [Route("futbol/partidos")]
    public class PartidoController : ControllerBase
    {


        private readonly ILogger<PartidoController> _logger;

        public PartidoController(ILogger<PartidoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Partido> Get()
        {
            PartidoService partidoService = PartidoService.getInstance();
            return partidoService.GetAll();
        }
    }
}
