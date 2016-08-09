using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class ProvinciaNego
    {
        private ProvinciaRepo provinciaRepo = new ProvinciaRepo();
        public int GuardarProvincia(Provincium provincia)
        {
            return provinciaRepo.GuardarProvincia(provincia);
        }

        public IEnumerable<Provincium> ListarProvincias()
        {
            return provinciaRepo.ListarProvincias();
        }

        public Provincium ObtenerProvincia(int id)
        {
            return provinciaRepo.ObtenerProvincia(id);
        }

        public void ActualizarProvincia(Provincium provincia)
        {
            provinciaRepo.ActualizarProvincia(provincia);
        }
    }
}
