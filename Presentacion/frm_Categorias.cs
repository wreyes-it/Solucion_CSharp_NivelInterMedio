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
using Entidades;

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
            // Call this method for change the header for datagriedview
            this.formato_ca();
        }

        private void Estado(bool lEstado)
        {
            Txt_descripcion_ca.Enabled = lEstado;
            Btn_cancelar.Enabled = lEstado;
            Btn_guardar.Enabled = lEstado;

            Btn_nuevo.Enabled = !lEstado;
            Btn_actualizar.Enabled = !lEstado;


        }


        #endregion

        private void frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_ca(Txt_buscar.Text.Trim());
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_descripcion_ca.Text))
            {
                MessageBox.Show("No se tiene informacion para ser Guardada.","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                string Rpta = "";
                E_Categorias oca = new E_Categorias();
                oca.Codigo_ca = 0;
                oca.Descripcion_ca = Txt_descripcion_ca.Text.Trim();
                Rpta = N_Categorias.Guardar_ca(1, oca);

                if (Rpta.Equals("Ok"))
                {
                    this.Listado_ca("%");
                    MessageBox.Show("Datos Guardados Correctamente","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Rpta,"Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }

        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
