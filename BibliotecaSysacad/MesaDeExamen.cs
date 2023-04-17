using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSysacad
{
    internal class MesaDeExamen
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }

        public Materia Materia { get; set; }
        public List<Estudiante> Estudiantes { get; set; }





    }
}
