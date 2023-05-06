using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class frmDesparasitacion : Form
    {
        public frmDesparasitacion()
        {
            InitializeComponent();
        }

        private void t_desperacitacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_desperacitacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void frmDesparasitacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.t_desperacitacion' Puede moverla o quitarla según sea necesario.
            this.t_desperacitacionTableAdapter.Fill(this.veterinariaDataSet.t_desperacitacion);

        }
    }
}
