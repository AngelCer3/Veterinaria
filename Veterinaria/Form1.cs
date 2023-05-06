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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModuloCliente_Click(object sender, EventArgs e)
        {
            frmCliente objtFrm = new frmCliente();
            objtFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMascotas objFrm = new frmMascotas();
            objFrm.Show();
        }

        private void btnModuloMascota_Click(object sender, EventArgs e)
        {
            frmVeterinario objtFrm = new frmVeterinario();
            objtFrm.Show();
        }

        private void btnModuloVacuna_Click(object sender, EventArgs e)
        {
            frmDesparasitacion objtFrm = new frmDesparasitacion();
            objtFrm.Show();
            
        }

        private void btnModuloDesparasitacion_Click(object sender, EventArgs e)
        {
            frmVacuna objtFrm = new frmVacuna();
            objtFrm.Show();
        }
    }
}
