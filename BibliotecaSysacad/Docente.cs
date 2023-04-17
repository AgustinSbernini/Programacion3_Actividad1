using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSysacad
{
    public class Docente : Persona
    {
        public List<Materia> MateriasACargo { get; set; }

        public Materia Materia
        {
            get => default;
            set
            {
            }
        }
    }
}
