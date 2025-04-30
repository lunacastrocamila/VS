using ExamenFinalPGIIVacunas.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using ExamenFinalPGIIVacunas.CapaDatos;

namespace ExamenFinalPGIIVacunas.CapaLogica
{
    public class VacunaCL
    {
        public static List<Vacuna> ObtenerTodas()
        {
            return VacunaDatos.ObtenerTodas();
        }

        public static void Agregar(Vacuna vacuna)
        {
            VacunaDatos.Agregar(vacuna);
        }

        public static void Modificar(Vacuna vacuna)
        {
            VacunaDatos.Modificar(vacuna);
        }

        public static void Eliminar(int idVacuna)
        {
            VacunaDatos.Eliminar(idVacuna);
        }

        public static List<Vacuna> ObtenerPorTipo(string tipo)
        {
            return VacunaDatos.ObtenerPorTipo(tipo);
        }

        public static DataTable ObtenerReportePorTipo()
        {
            return VacunaDatos.ObtenerReportePorTipo();
        }
    }
}