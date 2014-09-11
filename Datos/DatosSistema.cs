using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosSistema
    {
        public DataTable getDatos(string procedimiento, string[] parametros, params object[] valparametros)
        {
            DataTable dt = new DataTable();//creo una nueva tabla
            Conexion con = new Conexion();//instancio la conexión
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.conectar();
            cmd.CommandText = procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            if (procedimiento.Length != 0 && parametros.Length == valparametros.Length)
            {
                int i = 0;
                foreach (string parametro in parametros)
                    cmd.Parameters.AddWithValue(parametro, valparametros[i++]);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    con.desconectar();
                    return dt;
                }
                catch (Exception)
                {
                    con.desconectar();
                    return dt;

                }

            }
            return dt;


        }

    //método ejecutar sentencias

        public int Ejecutar(string procedimiento, String[] parametros, params Object[] valparametros)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            if (procedimiento!=null && parametros.Length==valparametros.Length)
            {
                int i = 0;
                foreach (string parametro in parametros)
                    cmd.Parameters.AddWithValue(parametro, valparametros[i++]);
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
            return 0;
        }
    
    }

    
}
