using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SistemAutomProcesoTitulacion
{
    public partial class frmModDocumentosEstud : Form
    {
        public bool EsVistaTutor { get; set; }
        public bool EsVistaCoordinador { get; set; }
        public bool EsVistaTribunal { get; set; }
        public frmModDocumentosEstud()
        {
            InitializeComponent();

            cmbTipoDocumento.Items.AddRange(new string[]
            { "Todos", "Anteproyecto", "Avance", "Proyecto Terminado"
    });
            cmbTipoDocumento.SelectedIndex = 0;

            cmbTipoDocumento.SelectedIndexChanged += cmbTipoDocumento_SelectedIndexChanged;
        }
        public void FiltrarPorTipos(string[] tipos)
        {
            DataTable dt = ConexionBD.ObtenerDocumentosPorTipos(tipos);
            dgvDocumentos.DataSource = dt;
            dgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmModDocumentosEstud_Load(object sender, EventArgs e)
        {
            if (EsVistaTutor)
            {
                cmbTipoDocumento.Visible = false;
                txtRutaArchivo.Visible = false;
                btnExaminar.Visible = false;
                btnSubir.Visible = false;
                btnEliminar.Visible = false;
                btnVer.Visible = true;

                FiltrarPorTipo("Avance");
            }
            else if (EsVistaTribunal)
            {
                cmbTipoDocumento.Visible = true;

                txtRutaArchivo.Visible = false;
                btnExaminar.Visible = false;
                btnEliminar.Visible = false;
                btnSubir.Visible = false;
                btnVer.Visible = true;
                // Mostrar solo tipos relevantes en el ComboBox
                cmbTipoDocumento.Items.Clear();
                cmbTipoDocumento.Items.Add("Avance");
                cmbTipoDocumento.Items.Add("Proyecto Terminado");
                cmbTipoDocumento.SelectedIndex = 0;

                FiltrarPorTipos(new[] { "Avance", "Proyecto Terminado" });
            }
            else
            {
                // Estudiante
                cmbTipoDocumento.Visible = true;
                txtRutaArchivo.Visible = true;
                btnExaminar.Visible = true;
                btnSubir.Visible = true;
                btnEliminar.Visible = true;
                btnVer.Visible = true;

                CargarDocumentos();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Documentos|*.pdf;*.docx;*.doc";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = ofd.FileName;
                MessageBox.Show("📁 Archivo seleccionado: " + ofd.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ruta = txtRutaArchivo.Text;
            if (string.IsNullOrEmpty(ruta) || !File.Exists(ruta))
            {
                MessageBox.Show("⚠️ Selecciona un archivo válido antes de guardar.");
                return;
            }

            string nombre = Path.GetFileName(ruta);
            string tipo = cmbTipoDocumento.SelectedItem.ToString();
            byte[] datos = File.ReadAllBytes(ruta);

            int nuevoId = ConexionBD.InsertarDocumento(nombre, tipo, datos);
            if (nuevoId > 0)
            {
                MessageBox.Show("✅ Documento subido correctamente con ID: " + nuevoId);
                CargarDocumentos();

                string tipoSeleccionado = cmbTipoDocumento.SelectedItem.ToString();
                dgvDocumentos.DataSource = ConexionBD.ObtenerDocumentosPorTipo(tipoSeleccionado);
            }
            else
            {
                MessageBox.Show("❌ Error al subir el documento.");
            }
            txtRutaArchivo.Clear();
        }

        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarDocumentos()
        {
            DataTable dt = ConexionBD.ObtenerDocumentos();
            dgvDocumentos.DataSource = dt;
            dgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MessageBox.Show("Documentos cargados correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ Selecciona un documento para eliminar.");
                return;
            }

            object valorCelda = dgvDocumentos.SelectedRows[0].Cells[0].Value;
            if (valorCelda == null || !int.TryParse(valorCelda.ToString(), out int id))
            {
                MessageBox.Show("❌ No se pudo obtener el ID del documento seleccionado.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este documento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion != DialogResult.Yes)
                return;

            bool eliminado = ConexionBD.EliminarDocumento(id);
            if (eliminado)
            {
                MessageBox.Show("🗑️ Documento eliminado correctamente.");
                CargarDocumentos();
            }
            else
            {
                MessageBox.Show("⚠️ No se encontró el documento en la base de datos.");
            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRutaArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ Selecciona un documento para descargar.");
                return;
            }

            object valorCelda = dgvDocumentos.SelectedRows[0].Cells["IdDocumento"].Value;
            if (valorCelda == null || !int.TryParse(valorCelda.ToString(), out int idDocumento))
            {
                MessageBox.Show("❌ No se pudo obtener el ID del documento seleccionado.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            string nombreArchivo = dgvDocumentos.SelectedRows[0].Cells["RutaArchivo"].Value.ToString();
            sfd.FileName = Path.GetFileName(nombreArchivo);
            sfd.Filter = "Todos los archivos|*.*";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            bool descargado = ConexionBD.DescargarDocumento(idDocumento, sfd.FileName, nombreArchivo);
            if (descargado)
            {
                MessageBox.Show("✅ Archivo descargado correctamente.");
            }
            else
            {
                MessageBox.Show("❌ Error al descargar el archivo.");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ Selecciona un documento para visualizar.");
                return;
            }

            object valorCelda = dgvDocumentos.SelectedRows[0].Cells[0].Value;
            if (valorCelda == null || !int.TryParse(valorCelda.ToString(), out int idDocumento))
            {
                MessageBox.Show("❌ No se pudo obtener el ID del documento seleccionado.");
                return;
            }

            bool visualizado = ConexionBD.VisualizarDocumento(idDocumento);
            if (!visualizado)
            {
                MessageBox.Show("❌ Error al visualizar el documento.");
            }
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = cmbTipoDocumento.SelectedItem.ToString();

            if (tipoSeleccionado == "Todos")
            {
                dgvDocumentos.DataSource = ConexionBD.ObtenerDocumentos(); // sin filtro
            }
            else
            {
                dgvDocumentos.DataSource = ConexionBD.ObtenerDocumentosPorTipo(tipoSeleccionado); // con filtro
            }
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void FiltrarPorTipo(string tipo)
        {
            DataTable dt = ConexionBD.ObtenerDocumentosPorTipo(tipo);
            dgvDocumentos.DataSource = dt;

            dgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("⚠️ No hay documentos de tipo '" + tipo + "' subidos aún.");
            }
        }
    }
}
