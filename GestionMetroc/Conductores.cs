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
    public partial class Conductores : Form
    {
        public Conductores()
        {
            InitializeComponent();
        }

        private void conductoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conductoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Conductores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Conductores' Puede moverla o quitarla según sea necesario.
            this.conductoresTableAdapter.Fill(this.relaciones.Conductores);

        }

        private void bBuscarDni_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            lDni.Visible = true;
            tbBusqueda.Visible = true;
            bBuscar.Visible = true;
            lNombre.Visible = false;
            bBuscarNombre.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;

        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            lDni.Visible = false;
            tbBusqueda.Visible = true;
            lNombre.Visible = true;
            bBuscar.Visible = true;
            bBuscarNombre.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = true;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarNombre.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lNombre.Visible == true) {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.ConductoresTableAdapter c = new RelacionesTableAdapters.ConductoresTableAdapter();
                String b = tbBusqueda.Text;
                tabla = c.BuscarNombre(b);
                conductoresDataGridView.DataSource = tabla;
            } else if (lDni.Visible == true) {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.ConductoresTableAdapter c = new RelacionesTableAdapters.ConductoresTableAdapter();
                String b = tbBusqueda.Text;
                tabla = c.BusquedaDni(b);
                conductoresDataGridView.DataSource = tabla;
            }

            lNombre.Visible = false;
            lDni.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = false;
            botones();
        }

        private void bContar_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.ConductoresTableAdapter c = new RelacionesTableAdapters.ConductoresTableAdapter();
            var cuenta = c.ContarConductores();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " conductores en la tabla.");
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            lDni.Visible = false;
            tbBusqueda.Visible = true;
            lNombre.Visible = false;
            bBorrar2.Visible = true;
            bBuscarNombre.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
            bCancelar.Visible = true;

        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.ConductoresTableAdapter c = new RelacionesTableAdapters.ConductoresTableAdapter();
            String b = tbBusqueda.Text;
            c.BorrarConductor(b);
            this.conductoresTableAdapter.Fill(this.relaciones.Conductores);
            botones();
            this.conductoresTableAdapter.Fill(this.relaciones.Conductores);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            dniTextBox.Visible = true;
            nombreTextBox.Visible = true;
            nombreEstudioTextBox.Visible = true;
            apellidosTextBox.Visible = true;
            direccionTextBox.Visible = true;
            telefonoTextBox.Visible = true;
            emailTextBox.Visible = true;
            fechaTitulacionDateTimePicker.Visible = true;
            fechaIngresoDateTimePicker.Visible = true;
            fechaNacimientoDateTimePicker.Visible = true;
            centroTitulacionTextBox.Visible = true;

            LabelDni.Visible = true;
            LabelNombre.Visible = true;
            labelApellidos.Visible = true;
            labelDireccion.Visible = true;
            labelTelefono.Visible = true;
            labelEmail.Visible = true;
            labelIngreso.Visible = true;
            labelNacimiento.Visible = true;
            labelEstudio.Visible = true;
            labelTitu.Visible = true;
            labelCentro.Visible = true;
            bCancelar.Visible = true;
            bAgregar2.Visible = true;

            bBuscarDni.Visible = false;
            bBuscarNombre.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }

        public void botones() {
            bBuscarDni.Visible = true;
            bBuscarNombre.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;

            dniTextBox.Visible = false;
            nombreEstudioTextBox.Visible = false;
            apellidosTextBox.Visible = false;
            direccionTextBox.Visible = false;
            telefonoTextBox.Visible = false;
            emailTextBox.Visible = false;
            fechaIngresoDateTimePicker.Visible = false;
            fechaNacimientoDateTimePicker.Visible = false;
            centroTitulacionTextBox.Visible = false;
            LabelDni.Visible = false;
            LabelNombre.Visible = false;
            labelApellidos.Visible = false;
            labelDireccion.Visible = false;
            labelTelefono.Visible = false;
            labelEmail.Visible = false;
            labelIngreso.Visible = false;
            labelNacimiento.Visible = false;
            labelEstudio.Visible = false;
            labelTitu.Visible = false;
            labelCentro.Visible = false;
            bCancelar.Visible = false;
            lDni.Visible = false;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            lNombre.Visible = false;
            bAgregar2.Visible = false;
            bBorrar2.Visible = false;
            nombreTextBox.Visible = false;
            fechaTitulacionDateTimePicker.Visible = false;
            bModificar2.Visible = false;
            lBorrar.Visible = false;

            this.conductoresTableAdapter.Fill(this.relaciones.Conductores);
        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.ConductoresTableAdapter c = new RelacionesTableAdapters.ConductoresTableAdapter();
            var fechaIngreso = fechaIngresoDateTimePicker.Value.ToShortDateString();
            var fechaNacimiento = fechaNacimientoDateTimePicker.Value.ToShortDateString();
            var fechaTitulacion = fechaTitulacionDateTimePicker.Value.ToShortDateString();
            c.AgregarConductor(dniTextBox.Text, nombreTextBox.Text, apellidosTextBox.Text, direccionTextBox.Text, Convert.ToInt32(telefonoTextBox.Text), emailTextBox.Text, fechaIngreso,fechaNacimiento,nombreEstudioTextBox.Text, fechaTitulacion, centroTitulacionTextBox.Text);
            botones();
            this.conductoresTableAdapter.Fill(this.relaciones.Conductores);
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            bBuscarNombre.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;

            dniTextBox.Visible = true;
            nombreTextBox.Visible = true;
            nombreEstudioTextBox.Visible = true;
            apellidosTextBox.Visible = true;
            direccionTextBox.Visible = true;
            telefonoTextBox.Visible = true;
            emailTextBox.Visible = true;
            fechaTitulacionDateTimePicker.Visible = true;
            fechaIngresoDateTimePicker.Visible = true;
            fechaNacimientoDateTimePicker.Visible = true;
            centroTitulacionTextBox.Visible = true;

            LabelDni.Visible = true;
            LabelNombre.Visible = true;
            labelApellidos.Visible = true;
            labelDireccion.Visible = true;
            labelTelefono.Visible = true;
            labelEmail.Visible = true;
            labelIngreso.Visible = true;
            labelNacimiento.Visible = true;
            labelEstudio.Visible = true;
            labelTitu.Visible = true;
            labelCentro.Visible = true;
            bCancelar.Visible = true;
            bModificar2.Visible = true;
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.ConductoresTableAdapter c = new RelacionesTableAdapters.ConductoresTableAdapter();
            var fechaIngreso = fechaIngresoDateTimePicker.Value.ToShortDateString();
            var fechaNacimiento = fechaNacimientoDateTimePicker.Value.ToShortDateString();
            var fechaTitulacion = fechaTitulacionDateTimePicker.Value.ToShortDateString();
            c.ModificarConductor(nombreTextBox.Text, apellidosTextBox.Text, direccionTextBox.Text, Convert.ToInt32(telefonoTextBox.Text), emailTextBox.Text, fechaIngreso, fechaNacimiento, nombreEstudioTextBox.Text, fechaTitulacion, centroTitulacionTextBox.Text, dniTextBox.Text, dniTextBox.Text);
            botones();
            this.conductoresTableAdapter.Fill(this.relaciones.Conductores);
        }
    }
}
