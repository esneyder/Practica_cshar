using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Persona
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }
        public string ciudad { get; set; }
        //método para insertar en la base de datos
        public int nuevaPersona(Persona persona)
        {
            DatosSistema datos = new DatosSistema();
            string[] parametros = {"@operacion",
                                      "@cedula",
                                      "@nombre",
                                      "@apellido",
                                      "@fechaNacimiento",
                                      "@edad",
                                      "@ciudad"};
            return datos.Ejecutar("spPersonaIA", parametros, "I", persona.cedula,
                                persona.nombre,
                                persona.apellido,
                                persona.fechaNacimiento,
                                persona.edad,
                                persona.ciudad);

        }

        //método para actulizar en la base de datos
        public int actualizar(Persona persona)
        {
            DatosSistema datos = new DatosSistema();
            string[] paramentros = {"@operacion",
                                       "@cedula",
                                       "@nombre",
                                       "@apellido",
                                       "@fechaNacimiento",
                                       "@edad",
                                       " @ciudad" };
            return datos.Ejecutar("spPersonaIA",
                        paramentros, "A", persona.cedula,
                        persona.nombre,
                        persona.apellido,
                        persona.fechaNacimiento,
                        persona.ciudad);


        }
    }
}
