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
    public partial class frm_NumericUpdown : Form
    {
        public frm_NumericUpdown()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string DiaTexto="";
            decimal Nrodia;
            Nrodia = num_nrodia.Value;
        
            switch (Nrodia)
            {
                case 1:
                    DiaTexto = "Lunes";
                    break;
                case 2:
                    DiaTexto = "Martes";
                    break;
                case 3:
                    DiaTexto = "Miercoles";
                    break;
                case 4:
                    DiaTexto = "Jueves";
                    break;
                case 5:
                    DiaTexto = "Viernes";
                    break;
                case 6:
                    DiaTexto = "Sabado";
                    break;
                case 7:
                    DiaTexto = "Domingo";
                    break;
                default:
                    DiaTexto = "Ninguno";
                    break;
            }

            txt_resultado.Text = DiaTexto.ToUpper();

        }
    }
}
