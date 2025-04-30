using System;
using System.Collections.Generic;
using System.Web;
using ExamenFinalPGIIVacunas.CapaDatos;

namespace ExamenFinalPGIIVacunas.CapaLogica
{
    public class PacienteCL
    {
        public static List<Paciente> ObtenerTodos()
        {
            return PacienteDatos.ObtenerTodos();
        }

        public static void Agregar(Paciente paciente)
        {
            PacienteDatos.Agregar(paciente);
        }

        public static void Modificar(Paciente paciente)
        {
            PacienteDatos.Modificar(paciente);
        }

        public static void Eliminar(int idPaciente)
        {
            PacienteDatos.Eliminar(idPaciente);
        }
    }
}
