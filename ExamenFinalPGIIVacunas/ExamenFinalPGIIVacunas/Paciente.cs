using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinalPGIIVacunas
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}