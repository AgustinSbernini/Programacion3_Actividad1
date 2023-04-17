using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSysacad
{
    public class Estudiante : Persona
    {
        public Carrera CarreraEnCurso { get; set; }
        public List<Materia> MateriasAprobadas { get; set; }
        public List<Materia> MateriasInscriptas { get; set; }

        public Materia Materia
        {
            get => default;
            set
            {
            }
        }
    }
}
