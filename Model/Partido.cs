using System.Collections.Generic;
using System;

namespace Futbol.Model
{
    public class Partido
    {
        public EquipoConGoles EquipoA { get; private set; }
        public EquipoConGoles EquipoB { get; private set; }
        public DateTime Fecha { get; private set; }

        public Partido(EquipoConGoles EquipoA, EquipoConGoles EquipoB, DateTime Fecha)
        {
            this.EquipoA = EquipoA;
            this.EquipoB = EquipoB;
            this.Fecha = Fecha;

            setearPuntos();
        }


        public void setEquipoA(EquipoConGoles EquipoA)
        {
            this.EquipoA = EquipoA;
        }


        public void setEquipoB(EquipoConGoles EquipoB)
        {
            this.EquipoB = EquipoB;
        }

        public void setFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }

        public EquipoConGoles getGanador()
        {
            if (EquipoA.GolesPartido > EquipoB.GolesPartido)
            {
                return EquipoA;
            }
            else if (EquipoA.GolesPartido == EquipoB.GolesPartido)
            {
                return null;
            }
            else
            {
                return EquipoB;
            }
        }

        private void setearPuntos()
        {
            EquipoConGoles equipoGanador = getGanador();

            if (EquipoA == equipoGanador)
            {
                EquipoA.Puntos += 3;
            }
            else if (EquipoB == equipoGanador)
            {
                EquipoB.Puntos += 3;
            }
            else
            {
                EquipoA.Puntos++;
                EquipoB.Puntos++;
            }
        }
    }
}