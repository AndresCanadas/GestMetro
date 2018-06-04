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
    public partial class Incidencias : Form
    {
        public Incidencias()
        {
            InitializeComponent();
        }

        private void incidenciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incidenciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Incidencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Incidencias' Puede moverla o quitarla según sea necesario.
            this.incidenciasTableAdapter.Fill(this.relaciones.Incidencias);

        }

        private void bBuscarEstacion_Click(object sender, EventArgs e)
        {
            bBuscarEstacion.Visible = false;
            lEstacion.Visible = true;
            tbBusqueda.Visible = true;
            lJefe.Visible = false;
            bBuscar.Visible = true;
            bBuscarJefe.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            lBorrar.Visible = false;
        }

        private void bBuscarJefe_Click(object sender, EventArgs e)
        {
            bBuscarEstacion.Visible = false;
            lEstacion.Visible = false;
            tbBusqueda.Visible = true;
            lJefe.Visible = true;
            bBuscar.Visible = true;
            bBuscarJefe.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            lBorrar.Visible = false;
        }

        private void bContar_Click_1(object sender, EventArgs e)
        {
            RelacionesTableAdapters.IncidenciasTableAdapter i = new RelacionesTableAdapters.IncidenciasTableAdapter();
            var cuenta = i.ContarIncidencias();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " registros de incidencias en la tabla.");
        }

        private void bBorrar_Click_1(object sender, EventArgs e)
        {
            bBuscarEstacion.Visible = false;
            lEstacion.Visible = false;
            tbBusqueda.Visible = true;
            bBorrar2.Visible = true;
            lBorrar.Visible = true;
            lJefe.Visible = false;
            
            bBuscarJefe.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            
            bCancelar.Visible = true;
        }

        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            bBuscarEstacion.Visible = true;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarJefe.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            if (lJefe.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.IncidenciasTableAdapter i = new RelacionesTableAdapters.IncidenciasTableAdapter();
                String b = tbBusqueda.Text;
                tabla = i.BuscarJefe(b);
                incidenciasDataGridView.DataSource = tabla;
            }
            else if (lEstacion.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.IncidenciasTableAdapter i = new RelacionesTableAdapters.IncidenciasTableAdapter();
                String b = tbBusqueda.Text;
                tabla = i.BuscarEstacion(b);
                incidenciasDataGridView.DataSource = tabla;
            }

            lJefe.Visible = false;
            lEstacion.Visible = false;
            lBorrar.Visible = false;
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            idTextBox.Visible = true;
            fechaDateTimePicker.Visible = true;
            horaTextBox.Visible = true;
            nombreEstacionTextBox.Visible = true;
            caracteristicasTextBox.Visible = true;
            valoracionTextBox.Visible = true;
            dniJefeTextBox.Visible = true;
            LabelId.Visible = true;
            LabelFecha.Visible = true;
            LabelHora.Visible = true;
            LabelNombre.Visible = true;
            LabelCarac.Visible = true;
            LabelValoracion.Visible = true;
            LabelDni.Visible = true;
            bAgregar2.Visible = true;
            bCancelar.Visible = true;
            bBuscarEstacion.Visible = false;
            bBuscarJefe.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.IncidenciasTableAdapter i = new RelacionesTableAdapters.IncidenciasTableAdapter();
            int b = Convert.ToInt32(tbBusqueda.Text);
            i.BorrarIncidencia(b);
        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.IncidenciasTableAdapter i = new RelacionesTableAdapters.IncidenciasTableAdapter();
            i.AgregarIncidencia(Convert.ToInt32(idTextBox.Text), fechaDateTimePicker.ToString(), horaTextBox.Text, nombreEstacionTextBox.Text, caracteristicasTextBox.Text, valoracionTextBox.Text, dniJefeTextBox.Text);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            idTextBox.Visible = false;
            fechaDateTimePicker.Visible = false;
            horaTextBox.Visible = false;
            nombreEstacionTextBox.Visible = false;
            caracteristicasTextBox.Visible = false;
            valoracionTextBox.Visible = false;
            dniJefeTextBox.Visible = false;
            LabelId.Visible = false;
            LabelFecha.Visible = false;
            LabelHora.Visible = false;
            LabelNombre.Visible = false;
            LabelCarac.Visible = false;
            LabelValoracion.Visible = false;
            LabelDni.Visible = false;
            bAgregar2.Visible = false;
            bCancelar.Visible = false;
            bBuscarEstacion.Visible = true;
            bBuscarJefe.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            tbBusqueda.Visible = false;
            tbBusqueda.Visible = false;
            bBorrar2.Visible = false;
            lBorrar.Visible = false;
        }
    }
}
