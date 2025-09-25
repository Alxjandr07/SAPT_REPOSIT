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
    public partial class frmAsignacion : Form
    {
        public frmAsignacion()
        {
            InitializeComponent();
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAsignacion_Load(object sender, EventArgs e)
        {
            CargarDocentesEnComboBoxes();
            Coordinador coordinador = new Coordinador();
            dgvEstudiantes.DataSource = coordinador.ObtenerEstudiantes();
        }

        private void CargarDocentesEnComboBoxes()
        {
            List<string> docentes = Coordinador.ObtenerNombresDocentes();

            cmbTribunal1.Items.AddRange(docentes.ToArray());
            cmbTribunal2.Items.AddRange(docentes.ToArray());
            cmbTribunal3.Items.AddRange(docentes.ToArray());
            cmbDirector.Items.AddRange(docentes.ToArray());
            cmbTutor.Items.AddRange(docentes.ToArray());
        }

    }
}
