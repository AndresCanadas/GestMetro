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

        private void bNominas_Click(object sender, EventArgs e)
        {
            Form Nominas = new Nominas();
            Nominas.Show();
        }

        private void bTecnicos_Click(object sender, EventArgs e)
        {
            Form Tecnicos = new Tecnicos();
            Tecnicos.Show();
        }

        private void bEntrar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Equals("admin") && tbPass.Text.Equals("admin"))
            {
                MessageBox.Show("Bienvenido");
                bConductores.Visible = true;
                bJefeEstacion.Visible = true;
                bCuidados.Visible = true;
                bEstacion.Visible = true;
                bHangar.Visible = true;
                bIncidencias.Visible = true;
                bLineas.Visible = true;
                bNominas.Visible = true;
                bTecnicos.Visible = true;
                bTornos.Visible = true;
                bTrenes.Visible = true;
                bVagones.Visible = true;

                lUsuario.Visible = false;
                lPass.Visible = false;
                tbPass.Visible = false;
                tbUsuario.Visible = false;
                bEntrar.Visible = false;
                pbTitulo.Visible = false;
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void bTornos_Click(object sender, EventArgs e)
        {
            Form Tornos = new Tornos();
            Tornos.Show();
        }

        private void bTrenes_Click(object sender, EventArgs e)
        {
            Form Trenes = new Trenes();
            Trenes.Show();
        }

        private void bVagones_Click(object sender, EventArgs e)
        {
            Form Vagones = new Vagones();
            Vagones.Show();
        }

        private void bAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la aplicacion de gestion de metro. Es facil de manejar, para buscar tienes diferentes opciones en cada tabla.\n" +
                "Para modificar alguna tabla debes en el campo id poner la id de la linea que quieres modificar y acto seguido poner los demas datos. ");
        }
    }
}
