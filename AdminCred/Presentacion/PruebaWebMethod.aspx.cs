using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class PruebaWebMethod : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                ddlProvincias.DataSource = GetProvincias();
                ddlProvincias.DataTextField = "nombre";
                ddlProvincias.DataValueField = "idProvincia";
                ddlProvincias.DataBind();

                //ddlCiudades.DataSource = GetCiudadesByPais(Convert.ToInt32(ddlProvincias.SelectedValue));
                //ddlCiudades.DataTextField = "nombre";
                //ddlCiudades.DataValueField = "idProvincia";
                //ddlCiudades.DataBind();
            }

        }

        [WebMethod]
        public static String GetCiudadesByPais(int idProvincia)
        {
            var query = from item in GetCiudades()
                        where Convert.ToInt32(item.IdProvincia) == idProvincia
                        select new Localidad
                        {
                            IdLocalidad = Convert.ToInt32(item.IdLocalidad),
                            Nombre = Convert.ToString(item.Nombre),
                            IdProvincia = Convert.ToInt32(item.IdProvincia)
                        };

            return Newtonsoft.Json.JsonConvert.SerializeObject(query);

        }

        private static IEnumerable<Provincium> GetProvincias()
        {
            ProvinciaNego provinciaNego = new ProvinciaNego();
            return provinciaNego.ListarProvincias();
        }

        private static IEnumerable<Localidad> GetCiudades()
        {
            LocalidadNego localidadNego = new LocalidadNego();
            return localidadNego.ListaLocalidades();
        }
    }
}