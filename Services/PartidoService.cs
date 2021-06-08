using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using Futbol.Model;
using Futbol.DAO;
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
            return PartidosDao.getInstance().getAll();
        }
    }
}