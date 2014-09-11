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
        public DataTable getDatos(string procedimiento,
         string[] nomparametros, params Object[] valparametros)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            Conexion con = new Conexion();
            cmd.Connection = con.conectar();
            cmd.CommandText = procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            if (nomparametros.Length != 0 && nomparametros.Length == valparametros.Length)
            {
                int i = 0;
                foreach (string parametro in nomparametros)
                    cmd.Parameters.AddWithValue(parametro, valparametros[i++]);
            }
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            { }
            return dt;


        }

        public int Ejecutar(string procedimiento,
           string[] nomparametros, params Object[] valparametros)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            Conexion con = new Conexion();
            cmd.Connection = con.conectar();
            cmd.CommandText = procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            if (nomparametros.Length != 0 && nomparametros.Length == valparametros.Length)
            {
                int i = 0;
                foreach (string parametro in nomparametros)
                    cmd.Parameters.AddWithValue(parametro, valparametros[i++]);
            }
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            { }
            return 0;


        }
    }

    
}
