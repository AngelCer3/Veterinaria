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
    public partial class frmMascotas : Form
    {
        public frmMascotas()
        {
            InitializeComponent();
        }

        private void t_mascotaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_mascotaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void ModuladoMascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.t_mascota' Puede moverla o quitarla según sea necesario.
            this.t_mascotaTableAdapter.Fill(this.veterinariaDataSet.t_mascota);

        }
    }
}
