using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_datagridview : Form
    {
        public frm_datagridview()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombres.Text != "" && txt_email.Text != "")
            {
                dgv_datos.Rows.Add(txt_nombres.Text,txt_email.Text);
                txt_nombres.Text = "";
                txt_email.Text = "";
                MessageBox.Show("Datos Guardados");
            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta; 
            int nFila;

            if (dgv_datos.Rows.Count > 0)   // Verifica que existen filas
            {
                Respuesta = MessageBox.Show("Estás seguro de Eliminar la fila seleccionada","Aviso del Sistema",MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    nFila = dgv_datos.CurrentRow.Index;
                    dgv_datos.Rows.RemoveAt(nFila);

                    // Remove   take information from the list
                    // RemoveAt take information from the index

                    MessageBox.Show("Fila Eliminada");
                }
            }
        }

        private void dgv_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombres.Text = Convert.ToString(dgv_datos.CurrentRow.Cells["column1"].Value);
            txt_email.Text= Convert.ToString(dgv_datos.CurrentRow.Cells["column2"].Value);
        }
    }
}
