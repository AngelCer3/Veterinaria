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
    public partial class frmVeterinario : Form
    {
        public frmVeterinario()
        {
            InitializeComponent();
        }

        private void t_veterinarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_veterinarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void ModuladoVeterinario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.t_veterinario' Puede moverla o quitarla según sea necesario.
            this.t_veterinarioTableAdapter.Fill(this.veterinariaDataSet.t_veterinario);

        }
    }
}
