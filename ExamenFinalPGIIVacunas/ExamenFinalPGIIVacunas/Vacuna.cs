using System;

namespace ExamenFinalPGIIVacunas.CapaEntidades
{
    public class Vacuna
    {
        public int IdVacuna { get; set; }
        public string NombreVacuna { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Dosis { get; set; }


        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }  


    }
}
