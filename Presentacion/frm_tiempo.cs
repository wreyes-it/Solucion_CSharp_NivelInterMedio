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
    public partial class frm_tiempo : Form
    {
        // Declaracion de Variables

        int Contador = 0; // si es countup
        //int Contador = 21;  // Inicializando para el uso del Timer si es countdown

        // Fin Declaracion de Variables

        public frm_tiempo()
        {
            InitializeComponent();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            // Segun Google el Intervalor para el Timer para 1 segundo en el Timer es 1000
            //timer1.Interval = 1000;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (Contador < 100)
            {
                Contador++;
                // Contador--;  // Para countdown
                txt_contador.Text = Convert.ToString(Contador);
                //progressBar1.Value= Contador;
                progressBar1.Increment(1);

            } else
            {
                timer1.Stop();
            }
            */

            // Permite resetear Contador para hacer countdown
            /*
            if (Contador < 1)
            {
                Contador = 21;
            }
            */

            // La segunda forma del progressbar y el timer

            if (progressBar1.Value < 100)
            {
                progressBar1.Increment(1);
                txt_contador.Text = Convert.ToString(progressBar1.Value);
            }
            else
            {
                timer1.Stop();
            }



        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
