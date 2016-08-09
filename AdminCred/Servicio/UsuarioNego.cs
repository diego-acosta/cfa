using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class UsuarioNego
    {
        private UsuarioRepo usuarioRepo = new UsuarioRepo();

        public int GuardarUsuario(Usuario usuario)
        {
            return usuarioRepo.GuardarUsuario(usuario);
        }

        public IEnumerable<Usuario> ListaUsuarios()
        {
            return usuarioRepo.ListarUsuarios();
        }

        public Usuario ObtenerUsuario(int id)
        {
            return usuarioRepo.ObtenerUsuario(id);
        }

        public Usuario ObtenerUsuarioPorUsrYPwd(String nombreUsuario,String pass)
        {
            return usuarioRepo.ObtenerUsuarioPorUsrYPwd(nombreUsuario,pass);
        }
        public void ActualizarUsuario(Usuario usuario)
        {
            usuarioRepo.ActualizarUsuario(usuario);
        }
    }
}
