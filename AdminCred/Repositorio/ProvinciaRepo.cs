using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class ProvinciaRepo
    {
        public int GuardarProvincia(Provincium provincia)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(provincia);
                modeloDeDominio.SaveChanges();
                return provincia.IdProvincia;
            }
        }

        public IEnumerable<Provincium> ListarProvincias()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Provincium> result = modeloDeDominio.Provincia.ToList();
                return result;
            }
        }

        public Provincium ObtenerProvincia(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Provincium provincia = modeloDeDominio.Provincia.Where(c => c.IdProvincia == id).FirstOrDefault();
                return provincia;
            }
        }

        public void ActualizarProvincia(Provincium provincia)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(provincia);
                modeloDeDominio.SaveChanges();
            }
        }
    }
}
