﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAutomProcesoTitulacion
{
    public partial class frmEntregarDocumentos : Form
    {
        private Estudiante estudiante;

        public frmEntregarDocumentos(Estudiante estudiante)
        {
            InitializeComponent();
            this.estudiante = estudiante;
            this.Load += frmEntregarDocumentos_Load;
        }
        public frmEntregarDocumentos()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (this.panelContenedorDocEst.Controls.Count > 0)
                this.panelContenedorDocEst.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.panelContenedorDocEst.Controls.Add(formHijo);
            this.panelContenedorDocEst.Tag = formHijo;
            formHijo.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmModDocumentosEstud());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelContenedorDocEst_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmEntregarDocumentos_Load(object sender, EventArgs e)
        {
            // Asegura que el panel se ajuste al tamaño del formulario
            panelContenedorDocEst.Dock = DockStyle.Fill;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
