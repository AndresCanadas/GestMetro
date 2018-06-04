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
    public partial class JefeEstacion : Form
    {
        public JefeEstacion()
        {
            InitializeComponent();
        }

        private void jefeEstacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jefeEstacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void JefeEstacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.JefeEstacion' Puede moverla o quitarla según sea necesario.
            this.jefeEstacionTableAdapter.Fill(this.relaciones.JefeEstacion);

        }

        private void bBuscarConductor_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = true;
            tbBusqueda.Visible = true;
            lEstacion.Visible = false;
            bBuscar.Visible = true;
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bBuscarMatricula_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            lEstacion.Visible = true;
            bBuscar.Visible = true;
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bContar_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
            var cuenta = j.ContarJefe();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " jefes de estación en la tabla.");
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
           
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarNombre.Visible = true;
            bBuscarEstacion.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lEstacion.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
                String b = tbBusqueda.Text;
                tabla = j.BuscarEstacion(b);
                jefeEstacionDataGridView.DataSource = tabla;
            }
            else if (lNombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
                String b = tbBusqueda.Text;
                tabla = j.BuscarNombre(b);
                jefeEstacionDataGridView.DataSource = tabla;
            }

            lEstacion.Visible = false;
            lNombre.Visible = false;
            lBorrar.Visible = false;
            botones();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            lEstacion.Visible = false;
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
            bCancelar.Visible = true;
            bBorrar2.Visible = true;
        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
            String b = tbBusqueda.Text;
            j.BorrarJefe(b);
            botones();
        }

        public void botones() {
            bBuscarNombre.Visible = true;
            bBuscarEstacion.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;

            dniLabel.Visible = false;
            nombreLabel.Visible = false;
            apellidosLabel.Visible = false;
            estacionLabel.Visible = false;
            fechaEntradaLabel.Visible = false;

            dniTextBox.Visible = false;
            nombreTextBox.Visible = false;
            apellidosTextBox.Visible = false;
            estacionTextBox.Visible = false;
            fechaEntradaDateTimePicker.Visible = false;
            bAgregar2.Visible = false;
            bCancelar.Visible = false;
            bModificar2.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            lEstacion.Visible = false;
            bBorrar2.Visible = false;
            lBorrar.Visible = false;
            this.jefeEstacionTableAdapter.Fill(this.relaciones.JefeEstacion);


        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;

            dniLabel.Visible = true;
            nombreLabel.Visible = true;
            apellidosLabel.Visible = true;
            estacionLabel.Visible = true;
            fechaEntradaLabel.Visible = true;

            dniTextBox.Visible = true;
            nombreTextBox.Visible = true;
            apellidosTextBox.Visible = true;
            estacionTextBox.Visible = true;
            fechaEntradaDateTimePicker.Visible = true;
            bAgregar2.Visible = true;
            bCancelar.Visible = true;

        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
            var fechaEntrada = fechaEntradaDateTimePicker.Value.ToShortDateString();
            j.AgregarJefe(dniTextBox.Text, nombreTextBox.Text, apellidosTextBox.Text, estacionTextBox.Text, fechaEntrada);
            botones();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;

            dniLabel.Visible = true;
            nombreLabel.Visible = true;
            apellidosLabel.Visible = true;
            estacionLabel.Visible = true;
            fechaEntradaLabel.Visible = true;

            dniTextBox.Visible = true;
            nombreTextBox.Visible = true;
            apellidosTextBox.Visible = true;
            estacionTextBox.Visible = true;
            fechaEntradaDateTimePicker.Visible = true;
            bModificar2.Visible = true;
            bCancelar.Visible = true;
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
            var fechaEntrada = fechaEntradaDateTimePicker.Value.ToShortDateString();
            j.ModificarJefe(nombreTextBox.Text, apellidosTextBox.Text, estacionTextBox.Text, fechaEntrada, dniTextBox.Text);
            botones();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }
    }
}
