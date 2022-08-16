using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;              // needed for connect and retrieve information from Sql Server
using System.Data.SqlClient;    // needed for connect and retrieve information from Sql Server
using Entidades;                // needed for access Entidades Layer

namespace Datos
{
    public class D_Categorias           // needed public for sharing throught Layers
    {
        // Metodo para listar Categorias
        public DataTable Listar_ca(string cTexto)
        {
            SqlDataReader Resultado;    
            DataTable MiTabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_ca", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto",SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                MiTabla.Load(Resultado);
                return MiTabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        // Metodo para guardar Categorias
        public string Guardar_ca(int Opcion,E_Categorias oCa)
        {
            string Rpta="";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_SP", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Opcion",SqlDbType.Int).Value = Opcion;
                Comando.Parameters.Add("@Codigo_ca", SqlDbType.Int).Value = oCa.Codigo_ca;
                Comando.Parameters.Add("@Descripcion_ca", SqlDbType.VarChar).Value = oCa.Descripcion_ca;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo registrar el proceso";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        // Metodo para editar Categorias

        // Metodo para Anular Categorias




    }

}
