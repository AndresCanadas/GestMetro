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
    public partial class Cuidados : Form
    {
        public Cuidados()
        {
            InitializeComponent();
        }

        private void cuidadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cuidadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Cuidados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Cuidados' Puede moverla o quitarla según sea necesario.
            this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            idLabel.Visible = true;
            fechaEntradaLabel.Visible = true;
            horaEntradaLabel.Visible = true;
            fechaSalidaLabel.Visible = true;
            horaSalidaLabel.Visible = true;
            matriculaTrenLabel.Visible = true;
            tipoAtencionLabel.Visible = true;
            dniTecnicoLabel.Visible = true;
            caracteristicasLabel.Visible = true;

            idTextBox.Visible = true;
            fechaEntradaDateTimePicker.Visible = true;
            horaEntradaTextBox.Visible = true;
            fechaSalidaDateTimePicker.Visible = true;
            horaSalidaTextBox.Visible = true;
            matriculaTrenTextBox.Visible = true;
            tipoAtencionTextBox.Visible = true;
            dniTecnicoTextBox.Visible = true;
            caracteristicasTextBox.Visible = true;

            bCancelar.Visible = true;
            bAgregar2.Visible = true;

            bBuscarMatricula.Visible = false;
            bBuscarTecnico.Visible = false;
            bContar.Visible = false;
            bAgregar.Visible = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.CuidadosTableAdapter c = new RelacionesTableAdapters.CuidadosTableAdapter();
            var fechaSalida = fechaSalidaDateTimePicker.Value.ToShortDateString();
            var fechaEntrada= fechaEntradaDateTimePicker.Value.ToShortDateString();
            c.AgregarCuidado(idTextBox.Text, fechaEntrada,horaEntradaTextBox.Text, fechaSalida,horaSalidaTextBox.Text, matriculaTrenTextBox.Text, tipoAtencionTextBox.Text, dniTecnicoTextBox.Text, caracteristicasTextBox.Text, valoracionTextBox.Text);
            botones();
            this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);
        }

        public void botones() {

            idLabel.Visible = false;
            fechaEntradaLabel.Visible = false;
            horaEntradaLabel.Visible = false;
            fechaSalidaLabel.Visible = false;
            horaSalidaLabel.Visible = false;
            matriculaTrenLabel.Visible = false;
            tipoAtencionLabel.Visible = false;
            dniTecnicoLabel.Visible = false;
            caracteristicasLabel.Visible = false;

            idTextBox.Visible = false;
            fechaEntradaDateTimePicker.Visible = false;
            horaEntradaTextBox.Visible = false;
            fechaSalidaDateTimePicker.Visible = false;
            horaSalidaTextBox.Visible = false;
            matriculaTrenTextBox.Visible = false;
            tipoAtencionTextBox.Visible = false;
            dniTecnicoTextBox.Visible = false;
            caracteristicasTextBox.Visible = false;
            bCancelar.Visible = false;
            bAgregar2.Visible = false;
            lMatricula.Visible = false;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            lTecnico.Visible = false;
            lBorrar.Visible = false;

            bBuscarMatricula.Visible = true;
            bBuscarTecnico.Visible = true;
            bContar.Visible = true;
            bAgregar.Visible = true;

            this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);
        }

        private void bBorrar_Click_1(object sender, EventArgs e)
        {
            bBuscarMatricula.Visible = false;
            lMatricula.Visible = false;
            tbBusqueda.Visible = true;
            lTecnico.Visible = false;
            bBuscar.Visible = true;
            bBuscarTecnico.Visible = false;
            bContar.Visible = false;
            bAgregar.Visible = false;
            lBorrar.Visible = true;
            bCancelar.Visible = true;
        }

        private void bContar_Click_1(object sender, EventArgs e)
        {
            RelacionesTableAdapters.CuidadosTableAdapter c = new RelacionesTableAdapters.CuidadosTableAdapter();
            var cuenta = c.ContarCuidados();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " registros de cuidados en la tabla.");
        }

        private void bBuscarTecnico_Click(object sender, EventArgs e)
        {
            bBuscarMatricula.Visible = false;
            lMatricula.Visible = false;
            tbBusqueda.Visible = true;
            lTecnico.Visible = true;
            bBuscar.Visible = true;
            bBuscarTecnico.Visible = false;
            bContar.Visible = false;
            bAgregar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bBuscarMatricula_Click(object sender, EventArgs e)
        {
            bBuscarMatricula.Visible = false;
            lMatricula.Visible = true;
            tbBusqueda.Visible = true;
            bBuscar.Visible = true;
            lTecnico.Visible = false;

            bBuscarTecnico.Visible = false;
            bContar.Visible = false;
            bAgregar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarMatricula.Visible = true;
            bBuscarTecnico.Visible = true;
            bContar.Visible = true;
            bAgregar.Visible = true;
            if (lTecnico.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.CuidadosTableAdapter c = new RelacionesTableAdapters.CuidadosTableAdapter();
                String b = tbBusqueda.Text;
                tabla = c.BuscarTecnico(b);
                cuidadosDataGridView.DataSource = tabla;
            }
            else if (lMatricula.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.CuidadosTableAdapter c = new RelacionesTableAdapters.CuidadosTableAdapter();
                String b = tbBusqueda.Text;
                tabla = c.BuscarMatricula(b);
                cuidadosDataGridView.DataSource = tabla;
            }

            lTecnico.Visible = false;
            lMatricula.Visible = false;
            lBorrar.Visible = false;
            botones();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            idLabel.Visible = true;
            fechaEntradaLabel.Visible = true;
            horaEntradaLabel.Visible = true;
            fechaSalidaLabel.Visible = true;
            horaSalidaLabel.Visible = true;
            matriculaTrenLabel.Visible = true;
            tipoAtencionLabel.Visible = true;
            dniTecnicoLabel.Visible = true;
            caracteristicasLabel.Visible = true;

            idTextBox.Visible = true;
            fechaEntradaDateTimePicker.Visible = true;
            horaEntradaTextBox.Visible = true;
            fechaSalidaDateTimePicker.Visible = true;
            horaSalidaTextBox.Visible = true;
            matriculaTrenTextBox.Visible = true;
            tipoAtencionTextBox.Visible = true;
            dniTecnicoTextBox.Visible = true;
            caracteristicasTextBox.Visible = true;

            bCancelar.Visible = true;

            bBuscarMatricula.Visible = false;
            bBuscarTecnico.Visible = false;
            bContar.Visible = false;
            bAgregar.Visible = false;
        }

    }
}
