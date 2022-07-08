using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class N_Categorias
    {
        public static DataTable Listar_ca(string cTexto)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Listar_ca(cTexto);
        }

    }
}
