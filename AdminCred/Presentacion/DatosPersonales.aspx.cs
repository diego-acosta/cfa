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
    public partial class DatosPersonales : System.Web.UI.Page
    {
        private ProvinciaNego provinciaNego = new ProvinciaNego();
        private LocalidadNego localidadNego = new LocalidadNego();
        private PersonaNego personaNego = new PersonaNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                limpiarFormulario();
                CargarProvincias();
                CargarLocalidades();
            }
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLocalidades();
        }

        private void CargarLocalidades()
        {
            Provincium provincia = provinciaNego.ObtenerProvincia(Convert.ToInt32(ddlProvincia.SelectedValue));
            ddlLocalidad.DataSource = localidadNego.ListarLocalidadesPorProvincia(provincia);
            ddlLocalidad.DataTextField = "nombre";
            ddlLocalidad.DataValueField = "idLocalidad";
            ddlLocalidad.DataBind();
            Provincium provinciaLaboral = provinciaNego.ObtenerProvincia(Convert.ToInt32(ddlProvinciaLaboral.SelectedValue));
            ddlLocalidadLaboral.DataSource = localidadNego.ListarLocalidadesPorProvincia(provinciaLaboral);
            ddlLocalidadLaboral.DataTextField = "nombre";
            ddlLocalidadLaboral.DataValueField = "idLocalidad";
            ddlLocalidadLaboral.DataBind();
        }

        private void CargarProvincias() 
        {
            ddlProvincia.DataSource = provinciaNego.ListarProvincias();
            ddlProvincia.DataTextField = "nombre";
            ddlProvincia.DataValueField = "idProvincia";
            ddlProvincia.DataBind();
            ddlProvinciaLaboral.DataSource = provinciaNego.ListarProvincias();
            ddlProvinciaLaboral.DataTextField = "nombre";
            ddlProvinciaLaboral.DataValueField = "idProvincia";
            ddlProvinciaLaboral.DataBind();
        }

        
        protected void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            txtComentario.Visible = true;
            txtTelefono.Visible = true;
        }

        private void limpiarFormulario()
        {
            txtNombre.Text = null;
            txtDireccion.Text = null;
            txtDireccionLaboral.Text = null;
            txtDni.Text = null;
            txtEmail.Text = null;
            txtNombre.Text = null;
            txtTelefono.Text = null;
            txtTrabajo.Text = null;
            txtComentario.Text = null;
            txtAntiguedad.Text = null;
        }

        private void GuardarPersona()
        {
            Persona persona = new Persona();
            persona.Antiguedad = Convert.ToDecimal(txtAntiguedad.Text);
            persona.Direccion = txtDireccion.Text;
            persona.DireccionLaboral = txtDireccionLaboral.Text;
            persona.Dni = txtDni.Text;
            persona.Email = txtEmail.Text;
            persona.Nombre = txtNombre.Text;
            persona.Trabajo = txtTrabajo.Text;
            persona.IdLocalidad = Int32.Parse(ddlLocalidad.SelectedValue);
            persona.IdlocalidadLaboral = Int32.Parse(ddlLocalidadLaboral.SelectedValue);
            personaNego.GuardarPersona(persona);
            
        }

        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPersona();
            limpiarFormulario();
        }


    }
}