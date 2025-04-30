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
    public partial class FRMPacientes : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM paciente", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvPacientes.DataSource = dt;
                gvPacientes.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("InsertarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@dni", txtDni.Text);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", Convert.ToDateTime(txtFechaNacimiento.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            CargarPacientes();
        }
    }
}