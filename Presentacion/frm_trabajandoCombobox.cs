﻿using System;
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
    public partial class frm_trabajandoCombobox : Form
    {
        public frm_trabajandoCombobox()
        {
            InitializeComponent();
        }

        private void cmb_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_resultado.Text = "Curso Seleccionado:" + cmb_cursos.SelectedItem + " y se encuentra en la posicion " + cmb_cursos.SelectedIndex;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            cmb_cursos.Items.Add(txt_nuevo.Text);
            txt_nuevo.Text = "";
            MessageBox.Show("Curso registrado");
        }
    }
}
