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
    public partial class Trenes : Form
    {
        public Trenes()
        {
            InitializeComponent();
        }

        private void trenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trenesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Trenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Trenes' Puede moverla o quitarla según sea necesario.
            this.trenesTableAdapter.Fill(this.relaciones.Trenes);

        }

        private void bBuscarDni_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            lNombre.Visible = true;
            tbBusqueda.Visible = true;
            lEstacion.Visible = false;
            bBuscar.Visible = true;
            bBuscarSueldo.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bBuscarSueldo_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            lEstacion.Visible = true;
            bBuscar.Visible = true;
            bBuscarSueldo.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bContar_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TrenesTableAdapter n = new RelacionesTableAdapters.TrenesTableAdapter();
            var cuenta = n.ContarTrenes();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " trenes en la tabla.");
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            lEstacion.Visible = false;
            bBuscarSueldo.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
            bCancelar.Visible = true;
            bBorrar2.Visible = true;
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            matriculaLabel.Visible = true;
            dniConductorLabel.Visible = true;
            nombreLabel.Visible = true;
            modeloLabel.Visible = true;
            fechaConstruccionLabel.Visible = true;
            potenciaLabel.Visible = true;
            velocidadMaxLabel.Visible = true;
            frenosSeLabel.Visible = true;
            sistemaAALabel.Visible = true;

            matriculaTextBox.Visible = true;
            dniConductorTextBox.Visible = true;
            nombreTextBox.Visible = true;
            modeloTextBox.Visible = true;
            fechaConstruccionDateTimePicker.Visible = true;
            potenciaTextBox.Visible = true;
            velocidadMaxTextBox.Visible = true;
            frenosSeTextBox.Visible = true;
            sistemaAATextBox.Visible = true;

            bAgregar2.Visible = true;
            bCancelar.Visible = true;


            bBuscarDni.Visible = false;
            bBuscarSueldo.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            matriculaLabel.Visible = true;
            dniConductorLabel.Visible = true;
            nombreLabel.Visible = true;
            modeloLabel.Visible = true;
            fechaConstruccionLabel.Visible = true;
            potenciaLabel.Visible = true;
            velocidadMaxLabel.Visible = true;
            frenosSeLabel.Visible = true;
            sistemaAALabel.Visible = true;

            matriculaTextBox.Visible = true;
            dniConductorTextBox.Visible = true;
            nombreTextBox.Visible = true;
            modeloTextBox.Visible = true;
            fechaConstruccionDateTimePicker.Visible = true;
            potenciaTextBox.Visible = true;
            velocidadMaxTextBox.Visible = true;
            frenosSeTextBox.Visible = true;
            sistemaAATextBox.Visible = true;
            bModificar2.Visible = true;
            bCancelar.Visible = true;


            bBuscarDni.Visible = false;
            bBuscarSueldo.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
        }

        public void botones() {
            bBuscarDni.Visible = true;
            bBuscarSueldo.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;

            lNombre.Visible = false;
            tbBusqueda.Visible = false;
            lEstacion.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = false;
            bBorrar2.Visible = false;
            bModificar2.Visible = false;
            bAgregar2.Visible = false;
            bBuscar.Visible = false;

            matriculaLabel.Visible = false;
            dniConductorLabel.Visible = false;
            nombreLabel.Visible = false;
            modeloLabel.Visible = false;
            fechaConstruccionLabel.Visible = false;
            potenciaLabel.Visible = false;
            velocidadMaxLabel.Visible = false;
            frenosSeLabel.Visible = false;
            sistemaAALabel.Visible = false;

            matriculaTextBox.Visible = false;
            dniConductorTextBox.Visible = false;
            nombreTextBox.Visible = false;
            modeloTextBox.Visible = false;
            fechaConstruccionDateTimePicker.Visible = false;
            potenciaTextBox.Visible = false;
            velocidadMaxTextBox.Visible = false;
            frenosSeTextBox.Visible = false;
            sistemaAATextBox.Visible = false;
            bAgregar2.Visible = false;
            bCancelar.Visible = false;
            bModificar2.Visible = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarDni.Visible = true;
            bBuscarSueldo.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lEstacion.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.TrenesTableAdapter n = new RelacionesTableAdapters.TrenesTableAdapter();
                String b = tbBusqueda.Text;
                tabla = n.BuscarMatricula(b);
                trenesDataGridView.DataSource = tabla;
            }
            else if (lNombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.TrenesTableAdapter n = new RelacionesTableAdapters.TrenesTableAdapter();
                String b = tbBusqueda.Text;
                tabla = n.BuscarPotencia(Convert.ToInt32(b));
                trenesDataGridView.DataSource = tabla;
            }

            lEstacion.Visible = false;
            lNombre.Visible = false;
            lBorrar.Visible = false;
            botones();
            this.trenesTableAdapter.Fill(this.relaciones.Trenes);
        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TrenesTableAdapter n = new RelacionesTableAdapters.TrenesTableAdapter();
            String b = tbBusqueda.Text;
            n.BorrarTren(b);
            botones();
            this.trenesTableAdapter.Fill(this.relaciones.Trenes);
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TrenesTableAdapter n = new RelacionesTableAdapters.TrenesTableAdapter();
            var fecha = fechaConstruccionDateTimePicker.Value.ToShortDateString();
            n.ModificarTren(dniConductorTextBox.Text, nombreTextBox.Text, modeloTextBox.Text, fecha, Convert.ToInt32(potenciaTextBox.Text), Convert.ToInt32(velocidadMaxTextBox.Text), frenosSeTextBox.Text, sistemaAATextBox.Text, matriculaTextBox.Text);
            botones();
            this.trenesTableAdapter.Fill(this.relaciones.Trenes);
        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TrenesTableAdapter n = new RelacionesTableAdapters.TrenesTableAdapter();
            var fecha = fechaConstruccionDateTimePicker.Value.ToShortDateString();
            n.AgregarTren(matriculaTextBox.Text, dniConductorTextBox.Text, nombreTextBox.Text, modeloTextBox.Text, fecha, Convert.ToInt32(potenciaTextBox.Text), Convert.ToInt32(velocidadMaxTextBox.Text), frenosSeTextBox.Text, sistemaAATextBox.Text);
            botones();
            this.trenesTableAdapter.Fill(this.relaciones.Trenes);
        }
    }
}
