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
            Coordinador coordinador = new Coordinador();
            dgvEstudiantes.DataSource = coordinador.ObtenerEstudiantes();

        }
    }
}
