namespace Presentacion
{
    partial class MiPrimerFormulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiPrimerFormulario));
            this.grb_mantenimiento = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_descripion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_botones_principales = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lst_mantenimiento = new System.Windows.Forms.ListBox();
            this.grb_mantenimiento.SuspendLayout();
            this.grb_botones_principales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_mantenimiento
            // 
            this.grb_mantenimiento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grb_mantenimiento.Controls.Add(this.btn_guardar);
            this.grb_mantenimiento.Controls.Add(this.btn_cancelar);
            this.grb_mantenimiento.Controls.Add(this.txt_descripion);
            this.grb_mantenimiento.Controls.Add(this.label2);
            this.grb_mantenimiento.Controls.Add(this.txt_codigo);
            this.grb_mantenimiento.Controls.Add(this.label1);
            this.grb_mantenimiento.Enabled = false;
            this.grb_mantenimiento.Location = new System.Drawing.Point(47, 83);
            this.grb_mantenimiento.Name = "grb_mantenimiento";
            this.grb_mantenimiento.Size = new System.Drawing.Size(414, 248);
            this.grb_mantenimiento.TabIndex = 10;
            this.grb_mantenimiento.TabStop = false;
            this.grb_mantenimiento.Text = "Mantenimiento";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(181, 162);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(87, 162);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_descripion
            // 
            this.txt_descripion.Location = new System.Drawing.Point(91, 101);
            this.txt_descripion.MaxLength = 30;
            this.txt_descripion.Name = "txt_descripion";
            this.txt_descripion.Size = new System.Drawing.Size(278, 22);
            this.txt_descripion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripción";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(91, 63);
            this.txt_codigo.MaxLength = 3;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_codigo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            // 
            // grb_botones_principales
            // 
            this.grb_botones_principales.Controls.Add(this.btn_salir);
            this.grb_botones_principales.Controls.Add(this.btn_reporte);
            this.grb_botones_principales.Controls.Add(this.btn_eliminar);
            this.grb_botones_principales.Controls.Add(this.btn_actualizar);
            this.grb_botones_principales.Controls.Add(this.btn_nuevo);
            this.grb_botones_principales.Location = new System.Drawing.Point(47, 364);
            this.grb_botones_principales.Name = "grb_botones_principales";
            this.grb_botones_principales.Size = new System.Drawing.Size(585, 129);
            this.grb_botones_principales.TabIndex = 11;
            this.grb_botones_principales.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(462, 21);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(102, 85);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.ForeColor = System.Drawing.Color.White;
            this.btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte.Image")));
            this.btn_reporte.Location = new System.Drawing.Point(353, 21);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(102, 85);
            this.btn_reporte.TabIndex = 11;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(242, 21);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(102, 85);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(130, 21);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(102, 85);
            this.btn_actualizar.TabIndex = 9;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.Location = new System.Drawing.Point(20, 21);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(102, 85);
            this.btn_nuevo.TabIndex = 8;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // lst_mantenimiento
            // 
            this.lst_mantenimiento.FormattingEnabled = true;
            this.lst_mantenimiento.ItemHeight = 16;
            this.lst_mantenimiento.Location = new System.Drawing.Point(482, 83);
            this.lst_mantenimiento.Name = "lst_mantenimiento";
            this.lst_mantenimiento.Size = new System.Drawing.Size(330, 244);
            this.lst_mantenimiento.TabIndex = 12;
            this.lst_mantenimiento.Click += new System.EventHandler(this.lst_mantenimiento_Click);
            // 
            // MiPrimerFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 505);
            this.Controls.Add(this.lst_mantenimiento);
            this.Controls.Add(this.grb_botones_principales);
            this.Controls.Add(this.grb_mantenimiento);
            this.Name = "MiPrimerFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Mantenimiento";
            this.grb_mantenimiento.ResumeLayout(false);
            this.grb_mantenimiento.PerformLayout();
            this.grb_botones_principales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_mantenimiento;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_descripion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_botones_principales;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.ListBox lst_mantenimiento;
    }
}