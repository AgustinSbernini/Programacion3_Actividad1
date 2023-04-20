using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaSysacad
{
    public class Usuario
    {
        public int Legajo { get; set; }
        public string MailAcademico { get; set; }
        public List<string> Roles { get; set; }

    }
}