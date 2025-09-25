using System;
using System.Data;
using System.Windows.Forms;

namespace SistemAutomProcesoTitulacion
{
    public partial class frmNotificacion : Form
    {
        private int idEstudiante;

        public frmNotificacion(int idEstudiante)
        {
            InitializeComponent();
            this.idEstudiante = idEstudiante;
            CargarNotificaciones();
        }

        private void CargarNotificaciones(bool soloNoLeidos = false)
        {
            dgvNotificacion.AutoGenerateColumns = true;

            // Obtiene las notificaciones según la lógica de negocio
            DataTable dt = Notificacion.ObtenerNotificacionesEstudiante(idEstudiante, soloNoLeidos);

            // Asigna el resultado al DataGridView
            dgvNotificacion.DataSource = dt;

            // Oculta columnas que no quieres mostrar
            if (dgvNotificacion.Columns.Contains("IdNotificacion"))
                dgvNotificacion.Columns["IdNotificacion"].Visible = false;
            if (dgvNotificacion.Columns.Contains("Estado"))
                dgvNotificacion.Columns["Estado"].Visible = false;
        }

        private void dgvNotificacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNotificacion.Columns[e.ColumnIndex].Name == "Leido" && e.RowIndex >= 0)
            {
                int idNotificacion = Convert.ToInt32(dgvNotificacion.Rows[e.RowIndex].Cells["IdNotificacion"].Value);
                Notificacion.MarcarComoLeido(idNotificacion, idEstudiante);
                CargarNotificaciones();
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            CargarNotificaciones(false);
        }

        private void btnNoLeido_Click(object sender, EventArgs e)
        {
            CargarNotificaciones(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvNotificacion.CurrentRow != null)
            {
                // Verifica si la notificación está leída
                var leidoCell = dgvNotificacion.CurrentRow.Cells["Leido"].Value;
                bool estaLeida = leidoCell != null && Convert.ToBoolean(leidoCell);

                if (!estaLeida)
                {
                    MessageBox.Show("No puedes eliminar una notificación que no ha sido leída.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idNotificacion = Convert.ToInt32(dgvNotificacion.CurrentRow.Cells["IdNotificacion"].Value);
                Notificacion.OcultarNotificacion(idNotificacion, idEstudiante);
                CargarNotificaciones();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvNotificacion.CurrentRow != null)
            {
                // Muestra los datos en los TextBox
                if (dgvNotificacion.Columns.Contains("Para"))
                {
                    txtPara.Text = dgvNotificacion.CurrentRow.Cells["Para"].Value?.ToString();
                }
                else
                {
                    MessageBox.Show("La columna 'Para' no está disponible.");
                }

                txtAsunto.Text = dgvNotificacion.CurrentRow.Cells["Asunto"].Value?.ToString();
                txtMensaje.Text = dgvNotificacion.CurrentRow.Cells["Mensaje"].Value?.ToString();

                // Marca como leída la notificación
                int idNotificacion = Convert.ToInt32(dgvNotificacion.CurrentRow.Cells["IdNotificacion"].Value);
                Notificacion.MarcarComoLeido(idNotificacion, idEstudiante);

                // Recarga las notificaciones para actualizar el estado
                CargarNotificaciones();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Limpia los TextBox
            txtPara.Clear();
            txtAsunto.Clear();
            txtMensaje.Clear();
        }
    }
}
