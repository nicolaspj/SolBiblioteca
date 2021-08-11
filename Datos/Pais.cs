using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class Pais
    {
        public static void  Agregar (Entidades.Pais pais)
        {
            string strSQL = " Insert Pais(Nombre) values(@Nombre)";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strSQL, objConexion);
            //params
            objCom.Parameters.AddWithValue("@Nombre", pais.Nombre);
            
            try
            {
                objConexion.Open();
                objCom.ExecuteNonQuery();
                
             }
            catch (SqlException)
            {
                throw new Exception("Error en la conexion");
            }
            catch (Exception)
            {
                throw new Exception("Error en la capa de datos");

            }
            finally
            {
                if (objConexion.State == ConnectionState.Open)
                {
                    objConexion.Close();
                }           
            }
            
        }

        public static List<Entidades.Pais> TraerTodos()
         {
            List<Entidades.Pais> lista = new List<Entidades.Pais>();
            SqlDataReader dr;
            SqlConnection objCon = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand("Select * from pais", objCon);
            objCon.Open();
            dr = objCom.ExecuteReader();
            while (dr.Read())
            {
                Entidades.Pais a = new Entidades.Pais();
                a.Id = Convert.ToInt32(dr["Id"]);
                a.Nombre = dr["Nombre"].ToString();
                lista.Add(a);
            }
            objCon.Close();
            return lista;
        }

        public static void Modificar(Entidades.Pais pais)
        {
           string strSQL = " Update Pais set Nombre = ' " +pais.Nombre+ " 'where id=" + pais.Id;
            SqlConnection objCon = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strSQL, objCon);
            objCon.Open();
            objCom.ExecuteNonQuery();
            objCon.Close();


        }

        public static void BorraPais(int id)
        {
            string strSQL = " delete Pais where id= " + id;
            SqlConnection objCon = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strSQL, objCon);
            objCon.Open();
            objCom.ExecuteNonQuery();
            objCon.Close();

        }
    }
}
