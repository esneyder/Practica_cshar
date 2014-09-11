using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public SqlConnection con { get; set; }

        private string cadenaconexion() {
            return @"Data source=.,initial catalog=bd,user id=esneyder,password=alvarez123";
        }


        public SqlConnection conectar() {
            con = new SqlConnection(cadenaconexion());
            try
            {
                con.Open();
                return this.con;
            }
            catch (Exception)
            { 
            }
            return null;
        }

        //desconectar

        public void desconectar() {
            if (this.con!=null)
            {
                this.con.Close();
            }
        
        }
    }
}
