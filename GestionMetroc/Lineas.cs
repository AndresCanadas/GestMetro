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
    public partial class Lineas : Form
    {
        public Lineas()
        {
            InitializeComponent();
        }

        private void lineasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lineasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Lineas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Lineas' Puede moverla o quitarla según sea necesario.
            this.lineasTableAdapter.Fill(this.relaciones.Lineas);

        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = true;
            tbBusqueda.Visible = true;
            bBuscar.Visible = true;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
        }

        private void bContar_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.LineasTableAdapter j = new RelacionesTableAdapters.LineasTableAdapter();
            var cuenta = j.ContarLineas();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " lineas en la tabla.");
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            bBuscar.Visible = true;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = true;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;

            if (lNombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.LineasTableAdapter j = new RelacionesTableAdapters.LineasTableAdapter();
                String b = tbBusqueda.Text;
                tabla = j.BuscarNombre(b);
                lineasDataGridView.DataSource = tabla;
            }
            else if (lBorrar.Visible == true)
            {
                RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
                String b = tbBusqueda.Text;
                // c.BorrarConductor(b);
                // this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);
            }
            lNombre.Visible = false;
            lBorrar.Visible = false;
        }
    }
}
