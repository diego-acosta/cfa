using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class PersonaNego
    {
        private PersonaRepo personaRepo = new PersonaRepo();

        public int GuardarPersona(Persona persona)
        {
            return personaRepo.GuardarPersona(persona);
        }

        public IEnumerable<Persona> ListaPersonas()
        {
            return personaRepo.ListarPersonas();
        }
        
        public Persona ObtenerPersona(int id)
        {
            return personaRepo.ObtenerPersona(id);
        }

        public void ActualizarPersona(Persona persona)
        {
            personaRepo.ActualizarPersona(persona);
        }
    
    }
}
