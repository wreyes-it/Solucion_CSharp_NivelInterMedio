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
    public partial class MiPrimerFormulario : Form
    {
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        // Inicio de mis Variables
        int NestadoGuarda = 0;

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 1;      // Nuevo Registro
            lst_mantenimiento.Enabled = false;

            txt_codigo.Text = "";
            txt_descripion.Text = "";

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = true;
            grb_botones_principales.Enabled = false;

            //txt_codigo.Select();  Lo mismo que Focus
            txt_codigo.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_descripion.Text = "";

            grb_mantenimiento.Enabled = false;
            grb_botones_principales.Enabled = true;
            lst_mantenimiento.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Registro;

            Registro = txt_codigo.Text.Trim() + " | " + txt_descripion.Text.Trim(); 

            if (NestadoGuarda == 1) // Nuevo Registro
            {
                lst_mantenimiento.Items.Add(Registro);
            } 
            else
            {
                int ElementoSeleccionado = lst_mantenimiento.SelectedIndex;

                lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem); 
                lst_mantenimiento.Items.Insert(ElementoSeleccionado, Registro); 
            }

            /*
            MessageBox.Show("Registro Guardado","Mensaje", MessageBoxButtons.OK, 
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1, 0,
                                   "mspaint.chm",
                                   "mspaint.chm::/paint_brush.htm");  */

            MessageBox.Show("Dato Guardado");

            txt_codigo.Text = "";
            txt_descripion.Text = "";

            grb_mantenimiento.Enabled = false;
            grb_botones_principales.Enabled = true;
            lst_mantenimiento.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);
            MessageBox.Show("Dato Eliminado");
        }


        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            string Textoseleccionado;
            int LongitudTexto;
            
            Textoseleccionado = this.lst_mantenimiento.SelectedItem.ToString().Trim();
            LongitudTexto = Textoseleccionado.Length;

            this.txt_codigo.Text = Textoseleccionado.Substring(0,3);
            this.txt_descripion.Text = Textoseleccionado.Substring(6,LongitudTexto-6).Trim();

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 2;          // Actualiza Registro
            lst_mantenimiento.Enabled = false;

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = false;
            grb_botones_principales.Enabled = false;

            //txt_codigo.Select();  Lo mismo que Focus
            txt_codigo.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
