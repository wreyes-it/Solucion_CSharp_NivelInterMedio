﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            /// Defino el Servidor de Datos (local o remoto)

            this.Base = "MiBaseDatos";
            this.Servidor = "SERVIDOR";
            this.Usuario = "user_sistema";
            this.Clave = "soporte";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database= "+this.Base+"; User Id="+this.Usuario+"; Password="+this.Clave;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }

            return Cadena;
        }

        /// Evalue la forma de conexion

        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();   
            }
            return Con;
        }

    }

}
