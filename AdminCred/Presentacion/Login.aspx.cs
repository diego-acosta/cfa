using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        private UsuarioNego usuarioNego = new UsuarioNego();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        public Usuario ValidateUserDetail(string username, string password)
        {   
            return usuarioNego.ObtenerUsuarioPorUsrYPwd(username,password);
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            //Usuario usuario = new Usuario();
            Usuario usuario = ValidateUserDetail(txtuserid.Text, txtpassword.Text);
            if (usuario != null)
            {
                Session["userlogin"] = txtuserid.Text;
                Response.Redirect("index.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Wrong user id aand password.')", true);
            }
        }

        
        
        
    
    }
}