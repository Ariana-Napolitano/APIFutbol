using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using Futbol.Model;
namespace Futbol.Services
{
    public class PartidoService
    {
        private readonly static PartidoService instance = new PartidoService();

        private PartidoService() { }

        public static PartidoService getInstance()
        {
            return instance;
        }

        public IEnumerable<Partido> GetAll()
        {

            EquipoConGoles Boca = new EquipoConGoles("Boca", 3);

            EquipoConGoles River = new EquipoConGoles("River", 1);

            Partido BocaRiver = new Partido(Boca, River, new DateTime());

            List<Partido> respuesta = new List<Partido>() { BocaRiver };

            return respuesta;
        }
    }
}