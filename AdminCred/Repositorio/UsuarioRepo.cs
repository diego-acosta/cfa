using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class UsuarioRepo
    {
        public int GuardarUsuario(Usuario usuario)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(usuario);
                modeloDeDominio.SaveChanges();
                return usuario.IdUsuario;
            }
        }

        public IEnumerable<Usuario> ListarUsuarios()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Usuario> result = modeloDeDominio.Usuarios.ToList();
                return result;
            }
        }

        public Usuario ObtenerUsuario(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Usuario usuario = modeloDeDominio.Usuarios.Where(c => c.IdUsuario == id).FirstOrDefault();
                return usuario;
            }
        }

        public Usuario ObtenerUsuarioPorUsrYPwd(String nombreUsuario, String pass)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Usuario usuario = modeloDeDominio.Usuarios.Where(c => c.NombreUsuario == nombreUsuario && c.Password == pass).FirstOrDefault();
                return usuario;
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(usuario);
                modeloDeDominio.SaveChanges();
            }
        }
    }
}
