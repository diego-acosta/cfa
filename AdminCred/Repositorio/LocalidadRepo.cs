using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class LocalidadRepo
    {
        public int GuardarLocalidad(Localidad localidad)
        {
            using (ModeloDeDominio modeloDeDominio=new ModeloDeDominio())
            {
                modeloDeDominio.Add(localidad);
                modeloDeDominio.SaveChanges();
                return localidad.IdLocalidad;
            }
        }

        public IEnumerable<Localidad> ListarLocalidades()
        {
            using (ModeloDeDominio modeloDeDominio=new ModeloDeDominio())
            {
                IEnumerable<Localidad> result = modeloDeDominio.Localidads.ToList();
                return result;
            }
        }

        public IEnumerable<Localidad> ListarLocalidadesPorProvincia(Provincium provincia)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Localidad> result = modeloDeDominio.Localidads.Where(c => c.IdProvincia == provincia.IdProvincia).ToList();
                return result;
            }
        }

        public Localidad ObtenerLocalidad(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Localidad localidad = modeloDeDominio.Localidads.Where(c => c.IdLocalidad == id).FirstOrDefault();
                return localidad;
            }
        }

        public void ActualizarLocalidad(Localidad localidad)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(localidad);
                modeloDeDominio.SaveChanges();
            }
        }
    }
}
