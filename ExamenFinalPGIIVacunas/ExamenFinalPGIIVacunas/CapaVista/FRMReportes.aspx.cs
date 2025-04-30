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
    public partial class FRMReportes : System.Web.UI.Page
    {
        string cadena = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT tipo, COUNT(*) AS Cantidad FROM vacuna GROUP BY tipo";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvReporte.DataSource = dt;
                gvReporte.DataBind();
            }
        }
    }
}