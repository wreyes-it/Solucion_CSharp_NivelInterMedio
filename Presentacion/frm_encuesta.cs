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
    public partial class frm_encuesta : Form
    {
        public frm_encuesta()
        {
            InitializeComponent();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            string Resultado;
            Resultado = "";

            if (chk_vfp.Checked)
            {
                //Resultado = Resultado + chk_vfp.Text;
                Resultado += chk_vfp.Text + ", ";
            }
            if (chk_csharp.Checked)
            {
                //Resultado = Resultado + chk_csharp.Text;
                Resultado += chk_csharp.Text + ", ";
            }
            if (chk_vbnet.Checked)
            {
                //Resultado= Resultado + chk_vbnet.Text;
                Resultado += chk_vbnet.Text + ", ";
            }
            if (chk_java.Checked)
            {
                //Resultado=Resultado + chk_java.Text;
                Resultado += chk_java.Text;
            }

            // Evaluando proceso de seleccion del radiobutton

            if (rdb_presencial.Checked)
            {
                Resultado += " :::: " + rdb_presencial.Text + " :::: ";
            } else if (rdb_virtual.Checked)
            {
                Resultado += " :::: " + rdb_virtual.Text + " :::: "; 
            }

            txt_resultado.Text = Resultado;
        }
    }
}
