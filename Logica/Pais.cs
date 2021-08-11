using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Logica
{
    public class Pais
    {
        public void Agregar (Entidades.Pais pais)
        {
            try
            {
                Datos.Pais.Agregar(pais);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); 
            }
            
        }

        public void Modifica ( Entidades.Pais pais)
        {
            try
            {
                Datos.Pais.Modificar(pais);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarPais( int id)
        {
            Datos.Pais.BorraPais(id);
        }

        public List<Entidades.Pais> TraerTodos()
        {
           return Datos.Pais.TraerTodos();
        }
    }
}
