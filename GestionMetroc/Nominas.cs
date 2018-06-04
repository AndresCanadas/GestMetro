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
    public partial class Nominas : Form
    {
        public Nominas()
        {
            InitializeComponent();
        }

        private void nominasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nominasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Nominas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Nominas' Puede moverla o quitarla según sea necesario.
            this.nominasTableAdapter.Fill(this.relaciones.Nominas);

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
            RelacionesTableAdapters.NominasTableAdapter n = new RelacionesTableAdapters.NominasTableAdapter();
            var cuenta = n.ContarNominas();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " nóminas en la tabla.");
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
                RelacionesTableAdapters.NominasTableAdapter n = new RelacionesTableAdapters.NominasTableAdapter();
                String b = tbBusqueda.Text;
                tabla = n.buscarSueldoNeto(Convert.ToInt32(b));
                nominasDataGridView.DataSource = tabla;
            }
            else if (lNombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.NominasTableAdapter n = new RelacionesTableAdapters.NominasTableAdapter();
                String b = tbBusqueda.Text;
                tabla = n.BuscarDni(b);
                nominasDataGridView.DataSource = tabla;
            }

            lEstacion.Visible = false;
            lNombre.Visible = false;
            lBorrar.Visible = false;
            botones();
            this.nominasTableAdapter.Fill(this.relaciones.Nominas);
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

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.NominasTableAdapter n = new RelacionesTableAdapters.NominasTableAdapter();
            String b = tbBusqueda.Text;
            n.BorrarNominas(b);
            botones();
            
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

            idLabel.Visible = false;
            fechaLabel.Visible = false;
            periodoLabel.Visible = false;
            dniEmpleadoLabel.Visible = false;
            sueldoBrutoLabel.Visible = false;
            descuentoSSLabel.Visible = false;
            descuentoIRPFLabel.Visible = false;
            plusTrienosLabel.Visible = false;
            plusProductividadLabel.Visible = false;
            sueldoNetoLabel.Visible = false;
            tipoContratoLabel.Visible = false;
            precioHoraLabel.Visible = false;
            totalHorasLabel.Visible = false;

            idTextBox.Visible = false;
            fechaDateTimePicker.Visible = false;
            periodoTextBox.Visible = false;
            dniEmpleadoTextBox.Visible = false;
            sueldoBrutoTextBox.Visible = false;
            descuentoSSTextBox.Visible = false;
            descuentoIRPFTextBox.Visible = false;
            plusTrienosTextBox.Visible = false;
            plusProductividadTextBox.Visible = false;
            sueldoNetoTextBox.Visible = false;
            tipoContratoTextBox.Visible = false;
            precioHoraTextBox.Visible = false;
            totalHorasTextBox.Visible = false;
            bAgregar2.Visible = false;
            bCancelar.Visible = false;
            bModificar2.Visible = false;
            this.nominasTableAdapter.Fill(this.relaciones.Nominas);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            idLabel.Visible = true;
            fechaLabel.Visible = true;
            periodoLabel.Visible = true;
            dniEmpleadoLabel.Visible = true;
            sueldoBrutoLabel.Visible = true;
            descuentoSSLabel.Visible = true;
            descuentoIRPFLabel.Visible = true;
            plusTrienosLabel.Visible = true;
            plusProductividadLabel.Visible = true;
            sueldoNetoLabel.Visible = true;
            tipoContratoLabel.Visible = true;
            precioHoraLabel.Visible = true;
            totalHorasLabel.Visible = true;

            idTextBox.Visible = true;
            fechaDateTimePicker.Visible = true;
            periodoTextBox.Visible = true;
            dniEmpleadoTextBox.Visible = true;
            sueldoBrutoTextBox.Visible = true;
            descuentoSSTextBox.Visible = true;
            descuentoIRPFTextBox.Visible = true;
            plusTrienosTextBox.Visible = true;
            plusProductividadTextBox.Visible = true;
            sueldoNetoTextBox.Visible = true;
            tipoContratoTextBox.Visible = true;
            precioHoraTextBox.Visible = true;
            totalHorasTextBox.Visible = true;
            bAgregar2.Visible = true;
            bCancelar.Visible = true;


            bBuscarDni.Visible = false;
            bBuscarSueldo.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;

        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.NominasTableAdapter n = new RelacionesTableAdapters.NominasTableAdapter();
            var fecha = fechaDateTimePicker.Value.ToShortDateString();
            n.AgregarNomina(idTextBox.Text, fecha, periodoTextBox.Text, dniEmpleadoTextBox.Text, Convert.ToInt32(sueldoBrutoTextBox.Text), Convert.ToInt32(descuentoSSTextBox.Text), Convert.ToInt32(descuentoIRPFTextBox.Text), Convert.ToInt32(plusTrienosTextBox.Text), Convert.ToInt32(plusProductividadTextBox.Text), Convert.ToInt32(sueldoNetoTextBox.Text), tipoContratoTextBox.Text, Convert.ToInt32(precioHoraTextBox.Text), Convert.ToInt32(totalHorasTextBox.Text));
            botones();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            idLabel.Visible = true;
            fechaLabel.Visible = true;
            periodoLabel.Visible = true;
            dniEmpleadoLabel.Visible = true;
            sueldoBrutoLabel.Visible = true;
            descuentoSSLabel.Visible = true;
            descuentoIRPFLabel.Visible = true;
            plusTrienosLabel.Visible = true;
            plusProductividadLabel.Visible = true;
            sueldoNetoLabel.Visible = true;
            tipoContratoLabel.Visible = true;
            precioHoraLabel.Visible = true;
            totalHorasLabel.Visible = true;

            idTextBox.Visible = true;
            fechaDateTimePicker.Visible = true;
            periodoTextBox.Visible = true;
            dniEmpleadoTextBox.Visible = true;
            sueldoBrutoTextBox.Visible = true;
            descuentoSSTextBox.Visible = true;
            descuentoIRPFTextBox.Visible = true;
            plusTrienosTextBox.Visible = true;
            plusProductividadTextBox.Visible = true;
            sueldoNetoTextBox.Visible = true;
            tipoContratoTextBox.Visible = true;
            precioHoraTextBox.Visible = true;
            totalHorasTextBox.Visible = true;
            bModificar2.Visible = true;
            bCancelar.Visible = true;


            bBuscarDni.Visible = false;
            bBuscarSueldo.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.NominasTableAdapter n = new RelacionesTableAdapters.NominasTableAdapter();
            var fecha = fechaDateTimePicker.Value.ToShortDateString();
            n.ModificarNomina(fecha, periodoTextBox.Text, dniEmpleadoTextBox.Text, Convert.ToInt32(sueldoBrutoTextBox.Text), Convert.ToInt32(descuentoSSTextBox.Text), Convert.ToInt32(descuentoIRPFTextBox.Text), Convert.ToInt32(plusTrienosTextBox.Text), Convert.ToInt32(plusProductividadTextBox.Text), Convert.ToInt32(sueldoNetoTextBox.Text), tipoContratoTextBox.Text, Convert.ToInt32(precioHoraTextBox.Text), Convert.ToInt32(totalHorasTextBox.Text), idTextBox.Text);
            botones();
        }
    }


}
