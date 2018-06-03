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
            bModificar.Visible = false;
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
            bModificar.Visible = false;
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
            lJefe.Visible = false;
            bBuscar.Visible = true;
            bBuscarJefe.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
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
            bModificar.Visible = true;
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
            else if (lBorrar.Visible == true)
            {
                RelacionesTableAdapters.IncidenciasTableAdapter i = new RelacionesTableAdapters.IncidenciasTableAdapter();
                String b = tbBusqueda.Text;
                // c.BorrarConductor(b);
                // this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);
            }

            lJefe.Visible = false;
            lEstacion.Visible = false;
            lBorrar.Visible = false;
        }
    }
}
