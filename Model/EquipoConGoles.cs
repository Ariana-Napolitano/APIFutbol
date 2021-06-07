using System.Collections.Generic;

namespace Futbol.Model
{
    public class EquipoConGoles : Equipo
    {
        public EquipoConGoles(string Nombre, int GolesPartido)
        {
            this.Nombre = Nombre;
            this.GolesPartido = GolesPartido;
        }
        public int GolesPartido { get; set; }

    }
}