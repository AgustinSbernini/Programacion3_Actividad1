using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSysacad
{
    public class Carrera
    {
        public float Duracion { get; set; }
        public string Nombre { get; set; }
        public string PerfilEgresado { get; set; }
        public string PlanDeEstudio { get; set; }
        public List<Materia> Materias { get; set; }
        public int CantidadMaterias { get { return Materias.Count; } }
        public List<string> Requisitos { get; set; }

        public Materia Materia
        {
            get => default;
            set
            {
            }
        }
    }
}
