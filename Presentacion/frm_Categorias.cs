using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class frm_Categorias : Form
    {
        public frm_Categorias()
        {
            InitializeComponent();
        }

        // Son Metodos de trabajo, finalidad tener agrupados que sean importantes
        #region "Mis Metodos"
        
        private void formato_ca()
        {
            Dgv_principal.Columns[0].Width = 80;
            Dgv_principal.Columns[0].HeaderText = "CODIGO";
            Dgv_principal.Columns[1].Width = 200;
            Dgv_principal.Columns[1].HeaderText = "CATEGORIA";
        }

        // changed to private because only is accesible from this form (frm_categorias)
        private void Listado_ca(string cTexto)
        {
            Dgv_principal.DataSource = Negocio.N_Categorias.Listar_ca(cTexto);
            this.formato_ca();
        }
        #endregion

        private void frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
