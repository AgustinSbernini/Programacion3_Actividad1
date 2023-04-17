using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSysacad
{
    public class Materia
    {
        public Carrera Carrera { get; set; }
        public int Horas { get; set; }
        public List<Materia> Correlativas { get; set; }
        public List<Docente> Docentes { get; set; }

        public TipoCursado TipoCursado
        {
            get => default;
            set
            {
            }
        }

        public Comision Comision
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
    }
}
