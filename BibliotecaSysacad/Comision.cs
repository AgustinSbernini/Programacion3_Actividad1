using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSysacad
{
    public class Comision
    {
        public int HorarioInicio { get; set; }
        public int HorarioFin { get; set; }

        public ETurno Turno
        {
            get => default;
            set
            {
            }
        }

        public Docente Docente
        {
            get => default;
            set
            {
            }
        }

        public Persona Ayudante { get; set; }
    }
}
