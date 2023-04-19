using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSysacad
{
    public class Examen
    {
        public Materia Materia { get; set; }
        public string Fecha { get; set; }
        public float Nota { get; set; }
        public Estudiante Estudiante { get; set; }
        public TipoDeExamen Instancia { get; set; }


    }
}
