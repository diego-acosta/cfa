using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorio
{
    public class PersonaRepo
    {
        public int GuardarPersona(Persona persona)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(persona);
                modeloDeDominio.SaveChanges();
                return persona.IdPersona;
            }
        }

        public IEnumerable<Persona> ListarPersonas()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Persona> result = modeloDeDominio.Personas.ToList();
                return result;
            }
        }
        
        public Persona ObtenerPersona(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Persona persona = modeloDeDominio.Personas.Where(c => c.IdPersona == id).FirstOrDefault();
                return persona;
            }
        }

        public void ActualizarPersona(Persona persona)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(persona);
                modeloDeDominio.SaveChanges();
            }
        }
    }
}
