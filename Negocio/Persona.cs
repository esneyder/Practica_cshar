using Datos;
using System;
using System.Collections.Generic;
using System.Data;
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
        //metodo para eliminar un registro de la base de datos

        public int eliminarRegistro(int cedula) {
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@operacion", "@cedula" };
            return datos.Ejecutar("spPersonaSE", parametros, "E", cedula);

        }

        //mostrar registro 
        public DataTable mostrarRegistro() {
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@operacion","@cedula"};
            return datos.getDatos("spPersonaSE", parametros, "t", 0);
        }
        //consultar registros
        public Persona getPersona(Persona per) {
            DataTable dt = new DataTable();
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@operacion","@cedula"};
            dt = datos.getDatos("spPersonaSE",parametros,"S",0);
            Persona p = new Persona();
            foreach (DataRow fila in dt.Rows)
            { 
                p.cedula=fila["cedula"].ToString();
                p.nombre=fila["nombre"].ToString();
                p.apellido=fila["apellido"].ToString();
                p.fechaNacimiento=Convert.ToDateTime(fila["fechaNacimiento"].ToString());
                p.edad=Convert.ToInt32(fila["edad"].ToString());
                p.ciudad=fila["ciudad"].ToString();
            }
            return p;
        
        }
    }
}
