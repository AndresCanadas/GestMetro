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
            Form incidencias = new Incidencias();
            incidencias.Show();
        }

        private void bLineas_Click(object sender, EventArgs e)
        {
            Form Lineas = new Lineas();
            Lineas.Show();
        }

        private void bConductores_Click(object sender, EventArgs e)
        {
            Form Conductores = new Conductores();
            Conductores.Show();
        }

        private void bCuidados_Click(object sender, EventArgs e)
        {
            Form Cuidados = new Cuidados();
            Cuidados.Show();
        }

        private void bEstacion_Click(object sender, EventArgs e)
        {
            Form Estacion = new Estacion();
            Estacion.Show();
        }

        private void bHangar_Click(object sender, EventArgs e)
        {
            Form Hangar = new Hangar();
            Hangar.Show();
        }

        private void bJefeEstacion_Click(object sender, EventArgs e)
        {
            Form Jefe = new JefeEstacion();
            Jefe.Show();
        }
    }
}
