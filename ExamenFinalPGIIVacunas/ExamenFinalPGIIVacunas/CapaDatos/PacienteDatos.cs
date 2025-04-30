using ExamenFinalPGIIVacunas.CapaLogica;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExamenFinalPGIIVacunas.CapaDatos
{
    public class PacienteDatos
    {
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public static List<Paciente> ObtenerTodos()
        {
            List<Paciente> lista = new List<Paciente>();
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM paciente", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Paciente p = new Paciente
                    {
                        IdPaciente = Convert.ToInt32(reader["id_paciente"]),
                        Nombre = reader["nombre"].ToString(),
                        DNI = reader["dni"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["fecha_nacimiento"])
                    };
                    lista.Add(p);
                }
            }
            return lista;
        }

        public static void Agregar(Paciente paciente)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("InsertarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@dni", paciente.DNI);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", paciente.FechaNacimiento);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Modificar(Paciente paciente)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("ActualizarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_paciente", paciente.IdPaciente);
                cmd.Parameters.AddWithValue("@nuevo_nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@nuevo_dni", paciente.DNI);
                cmd.Parameters.AddWithValue("@nuevo_fecha_nacimiento", paciente.FechaNacimiento);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int idPaciente)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("EliminarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_paciente", idPaciente);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
