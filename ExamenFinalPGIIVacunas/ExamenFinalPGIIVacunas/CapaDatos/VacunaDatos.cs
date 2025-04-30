using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExamenFinalPGIIVacunas.CapaDatos
{
    public class VacunaDatos
    {
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public static List<Vacuna> ObtenerTodas()
        {
            List<Vacuna> lista = new List<Vacuna>();
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("ObtenerTodasVacunas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Vacuna v = new Vacuna
                    {
                        IdVacuna = Convert.ToInt32(reader["id_vacuna"]),
                        NombreVacuna = reader["nombre_vacuna"].ToString(),
                        Tipo = reader["tipo"].ToString(),
                        FechaAplicacion = Convert.ToDateTime(reader["fecha_aplicacion"]),
                        Dosis = reader["dosis"].ToString(),
                        NombrePaciente = reader["paciente"].ToString()
                    };
                    lista.Add(v);
                }
            }
            return lista;
        }

        public static void Agregar(Vacuna vacuna)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("InsertarVacuna", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_vacuna", vacuna.NombreVacuna);
                cmd.Parameters.AddWithValue("@tipo", vacuna.Tipo);
                cmd.Parameters.AddWithValue("@fecha_aplicacion", vacuna.FechaAplicacion);
                cmd.Parameters.AddWithValue("@dosis", vacuna.Dosis);
                cmd.Parameters.AddWithValue("@id_paciente", vacuna.IdPaciente);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Modificar(Vacuna vacuna)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("ActualizarVacuna", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_vacuna", vacuna.IdVacuna);
                cmd.Parameters.AddWithValue("@nuevo_nombre_vacuna", vacuna.NombreVacuna);
                cmd.Parameters.AddWithValue("@nuevo_tipo", vacuna.Tipo);
                cmd.Parameters.AddWithValue("@nuevo_fecha", vacuna.FechaAplicacion);
                cmd.Parameters.AddWithValue("@nuevo_dosis", vacuna.Dosis);
                cmd.Parameters.AddWithValue("@nuevo_id_paciente", vacuna.IdPaciente);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int idVacuna)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("EliminarVacuna", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_vacuna", idVacuna);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Vacuna> ObtenerPorTipo(string tipo)
        {
            List<Vacuna> lista = new List<Vacuna>();
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("ObtenerVacunasPorTipo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", tipo);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Vacuna v = new Vacuna
                    {
                        IdVacuna = Convert.ToInt32(reader["id_vacuna"]),
                        NombreVacuna = reader["nombre_vacuna"].ToString(),
                        Tipo = reader["tipo"].ToString(),
                        FechaAplicacion = Convert.ToDateTime(reader["fecha_aplicacion"]),
                        Dosis = reader["dosis"].ToString(),
                        NombrePaciente = reader["paciente"].ToString()
                    };
                    lista.Add(v);
                }
            }
            return lista;
        }

        public static DataTable ObtenerReportePorTipo()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = @"SELECT tipo AS NombreTipo, COUNT(id_vacuna) AS CantidadVacunas
                                 FROM vacuna
                                 GROUP BY tipo";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}

