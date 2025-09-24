using System;
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
    public partial class frmGestionReunion : Form
    {
        public frmGestionReunion()
        {
            InitializeComponent();
            btnMarcar.Click += btnMarcar_Click;
            btnDesmarcar.Click += btnDesmarcar_Click;
            this.Load += frmGestionReunion_Load;
        }


        private void tsbModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            DateTime dia = monthCalendar1.SelectionStart;
            string lugar = txtLugarReunion.Text.Trim();

            if (string.IsNullOrWhiteSpace(lugar))
            {
                MessageBox.Show("⚠️ Por favor, ingresa el lugar de la reunión.");
                return;
            }

            if (!monthCalendar1.BoldedDates.Contains(dia))
            {
                monthCalendar1.AddBoldedDate(dia);
                monthCalendar1.UpdateBoldedDates();

                // 👇 Puedes ajustar la hora fija aquí
                string horaFija = "10:00";
                string texto = $"📅 {dia:dddd dd/MM/yyyy} a las {horaFija} en {lugar}";

                ConexionBD.AgregarInformacionReunion(texto);
                ActualizarLabelReuniones();
            }
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            DateTime dia = monthCalendar1.SelectionStart;
            string texto = $"El día {dia.ToShortDateString()} se convoca a una reunión.";

            if (monthCalendar1.BoldedDates.Contains(dia))
            {
                monthCalendar1.RemoveBoldedDate(dia);
                monthCalendar1.UpdateBoldedDates();
                ConexionBD.EliminarInformacionReunion(texto); // Elimina de la BD
            }

            MensajeReuniones = ConexionBD.ObtenerTodasLasInformacionesReuniones(); // Actualiza el label
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblMensaje.Text = $"El día {e.Start.ToShortDateString()} está seleccionado.";
        }

        private void ActualizarLabelReuniones()
        {
            var mensajes = ConexionBD.ObtenerTodasLasInformacionesReuniones();

            if (string.IsNullOrWhiteSpace(mensajes))
            {
                lblMensaje.Text = "Sin Reuniones Activas";
            }
            else
            {
                lblMensaje.Text = "Reuniones Activas:\n" + mensajes;
            }
        }

        public void ConfigurarModo(bool esCoordinador)
        {
            btnMarcar.Visible = esCoordinador;
            btnDesmarcar.Visible = esCoordinador;
            btnEliminarReuniones.Visible = esCoordinador;
            monthCalendar1.Enabled = esCoordinador;
            txtLugarReunion.Visible = esCoordinador;
            lblTituloLugarReunion.Visible = esCoordinador;
        }

        public string MensajeReuniones
        {
            get => lblMensaje.Text;
            set => lblMensaje.Text = value;
        }

        private void frmGestionReunion_Load(object sender, EventArgs e)
        {
            // Establece la fecha mínima como hoy
            monthCalendar1.MinDate = DateTime.Today;
            MensajeReuniones = ConexionBD.ObtenerTodasLasInformacionesReuniones();
        }

        private void btnEliminarReuniones_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
           "¿Estás seguro de que deseas eliminar TODAS las reuniones?",
           "Confirmar eliminación",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
                return;

            ConexionBD.EliminarTodasLasReuniones();

            // Limpia el calendario visualmente
            foreach (DateTime fecha in monthCalendar1.BoldedDates)
            {
                monthCalendar1.RemoveBoldedDate(fecha);
            }
            monthCalendar1.UpdateBoldedDates();

            // Limpia el label
            lblMensaje.Text = "No hay reuniones programadas.";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
