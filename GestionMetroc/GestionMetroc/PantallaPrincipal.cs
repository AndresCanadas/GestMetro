using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMetroc
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void bIncidencias_Click(object sender, EventArgs e)
        {
            var incidencias = new Prueba();
            incidencias.Show();
        }

        private void bLineas_Click(object sender, EventArgs e)
        {
            
        }

        private void bConductores_Click(object sender, EventArgs e)
        {
            Form Conductores = new Conductores();
            Conductores.Show();
        }
    }
}
