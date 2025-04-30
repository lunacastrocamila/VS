using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinalPGIIVacunas.CapaVista
{
    public partial class FRMVacunas : System.Web.UI.Page
    {
        string cadena = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPacientes();
            }
        }

        protected void CargarPacientes()
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("SELECT id_paciente, nombre FROM paciente", con);
                con.Open();
                ddlPacientes.DataSource = cmd.ExecuteReader();
                ddlPacientes.DataTextField = "nombre";
                ddlPacientes.DataValueField = "id_paciente";
                ddlPacientes.DataBind();
                con.Close();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("InsertarVacuna", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_vacuna", txtNombre.Text);
                cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                cmd.Parameters.AddWithValue("@fecha_aplicacion", Convert.ToDateTime(txtFechaAplicacion.Text));
                cmd.Parameters.AddWithValue("@dosis", txtDosis.Text);
                cmd.Parameters.AddWithValue("@id_paciente", ddlPacientes.SelectedValue);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}