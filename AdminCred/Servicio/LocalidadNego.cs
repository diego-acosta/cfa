using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;


namespace Negocio
{
    public class LocalidadNego
    {
        private LocalidadRepo localidadRepo = new LocalidadRepo();

        public int GuardarLocalidad(Localidad localidad)
        {
            return localidadRepo.GuardarLocalidad(localidad);
        }

        public IEnumerable<Localidad> ListaLocalidades()
        {
            return localidadRepo.ListarLocalidades();
        }

        public IEnumerable<Localidad> ListarLocalidadesPorProvincia(Provincium provincia)
        {
            return localidadRepo.ListarLocalidadesPorProvincia(provincia);
        }

        public Localidad ObtenerLocalidad(int id)
        {
            return localidadRepo.ObtenerLocalidad(id);
        }

        public void ActualizarLocalidad(Localidad localidad)
        {
            localidadRepo.ActualizarLocalidad(localidad);
        }
    }
}
