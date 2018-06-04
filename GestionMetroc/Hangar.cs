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
    public partial class Hangar : Form
    {
        public Hangar()
        {
            InitializeComponent();
        }

        private void hangarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hangarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Hangar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Hangar' Puede moverla o quitarla según sea necesario.
            this.hangarTableAdapter.Fill(this.relaciones.Hangar);

        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = false;
            lConductor.Visible = true;
            tbBusqueda.Visible = true;
            lMatricula.Visible = false;
            bBuscar.Visible = true;
            bBuscarMatricula.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bBuscarLinea_Click(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = false;
            lConductor.Visible = false;
            tbBusqueda.Visible = true;
            lMatricula.Visible = true;
            bBuscar.Visible = true;
            bBuscarMatricula.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bContar_Click_1(object sender, EventArgs e)
        {
            RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
            var cuenta = h.ContarHangar();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " estaciones en la tabla.");
        }

        private void bBorrar_Click_1(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = false;
            lConductor.Visible = false;
            tbBusqueda.Visible = true;
            lMatricula.Visible = false;
            bBuscarMatricula.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
            bCancelar.Visible = true;
            bBorrar2.Visible = true;
        }

        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = true;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarMatricula.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lMatricula.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
                String b = tbBusqueda.Text;
                tabla = h.BuscarMatricula(b);
                hangarDataGridView.DataSource = tabla;
            }
            else if (lConductor.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
                String b = tbBusqueda.Text;
                tabla = h.BuscarDniConductor(b);
                hangarDataGridView.DataSource = tabla;
            }

            lMatricula.Visible = false;
            lConductor.Visible = false;
            lBorrar.Visible = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {

            botones();
        }

        public void botones() {
            bBuscarConductor.Visible = true;
            bBuscarMatricula.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;

            lConductor.Visible = false;
            tbBusqueda.Visible = false;
            lMatricula.Visible = false;
            bBuscar.Visible = false;
            lBorrar.Visible = false;
            bBorrar2.Visible = false;
            bCancelar.Visible = false;

            idLabel.Visible = false;
            dniConductorLabel.Visible = false;
            plazaLabel.Visible = false;
            fechaEntradaLabel.Visible = false;
            horaEntradaLabel.Visible = false;
            fechaSalidaLabel.Visible = false;
            horaSalidaLabel.Visible = false;
            matriculaTrenLabel.Visible = false;

            idTextBox.Visible = false;
            dniConductorTextBox.Visible = false;
            plazaTextBox.Visible = false;
            fechaEntradaDateTimePicker.Visible = false;
            horaEntradaTextBox.Visible = false;
            fechaSalidaDateTimePicker.Visible = false;
            horaSalidaTextBox.Visible = false;
            matriculaTrenTextBox.Visible = false;
            bAgregar2.Visible = false;
            bModificar2.Visible = false;
            this.hangarTableAdapter.Fill(this.relaciones.Hangar);
        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
            h.BorrarHangar(tbBusqueda.Text);
            botones();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = false;
            bBuscarMatricula.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;

            idLabel.Visible = true;
            dniConductorLabel.Visible = true;
            plazaLabel.Visible = true;
            fechaEntradaLabel.Visible = true;
            horaEntradaLabel.Visible = true;
            fechaSalidaLabel.Visible = true;
            horaSalidaLabel.Visible = true;
            matriculaTrenLabel.Visible = true;

            idTextBox.Visible = true;
            dniConductorTextBox.Visible = true;
            plazaTextBox.Visible = true;
            fechaEntradaDateTimePicker.Visible = true;
            horaEntradaTextBox.Visible = true;
            fechaSalidaDateTimePicker.Visible = true;
            horaSalidaTextBox.Visible = true;
            matriculaTrenTextBox.Visible = true;
            bAgregar2.Visible = true;
            bCancelar.Visible = true;

        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
            var fechaSalida = fechaSalidaDateTimePicker.Value.ToShortDateString();
            var fechaEntrada = fechaEntradaDateTimePicker.Value.ToShortDateString();
            h.AgregarHangar(idTextBox.Text, dniConductorTextBox.Text, Convert.ToInt32(plazaTextBox.Text), fechaEntrada, horaEntradaTextBox.Text, fechaSalida, horaSalidaTextBox.Text, matriculaTrenTextBox.Text);
            botones();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = false;
            bBuscarMatricula.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;

            idLabel.Visible = true;
            dniConductorLabel.Visible = true;
            plazaLabel.Visible = true;
            fechaEntradaLabel.Visible = true;
            horaEntradaLabel.Visible = true;
            fechaSalidaLabel.Visible = true;
            horaSalidaLabel.Visible = true;
            matriculaTrenLabel.Visible = true;

            idTextBox.Visible = true;
            dniConductorTextBox.Visible = true;
            plazaTextBox.Visible = true;
            fechaEntradaDateTimePicker.Visible = true;
            horaEntradaTextBox.Visible = true;
            fechaSalidaDateTimePicker.Visible = true;
            horaSalidaTextBox.Visible = true;
            matriculaTrenTextBox.Visible = true;
            bModificar2.Visible = true;
            bCancelar.Visible = true;
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
            var fechaSalida = fechaSalidaDateTimePicker.Value.ToShortDateString();
            var fechaEntrada = fechaEntradaDateTimePicker.Value.ToShortDateString();
            h.ModificarHangar(dniConductorTextBox.Text, Convert.ToInt32(plazaTextBox.Text), fechaEntrada, horaEntradaTextBox.Text, fechaSalida, horaSalidaTextBox.Text, matriculaTrenTextBox.Text, idTextBox.Text);
            botones();
        }
    }
}
