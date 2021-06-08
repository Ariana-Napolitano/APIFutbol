using Futbol.Model;
using System.Collections.Generic;
using System;
namespace Futbol.DAO
{
    public class PartidosDao
    {
        private readonly static PartidosDao instance = new PartidosDao();

        private PartidosDao()
        {
            EquipoConGoles Boca = new EquipoConGoles("Boca", 3);

            EquipoConGoles River = new EquipoConGoles("River", 1);

            Partido BocaRiver = new Partido(Boca, River, new DateTime(2021, 5, 29));
            allPartidos.Add(BocaRiver);

            EquipoConGoles Racing = new EquipoConGoles("Racing", 2);
            EquipoConGoles Riber = new EquipoConGoles("River", 2);
            Partido RiverRacing = new Partido(Riber, Racing, new DateTime(2021, 6, 5));
            allPartidos.Add(RiverRacing);
        }

        public static PartidosDao getInstance()
        {
            return instance;
        }

        private List<Partido> allPartidos = new List<Partido>();

        public List<Partido> getAll()
        {

            return allPartidos;
        }
        public Partido getUltimo()
        {

            return null;
        }

    }
}