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
            bCancelar.Visible = true;
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
            bBuscar.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
            bBorrar2.Visible = false;
            bCancelar.Visible = true;
            bBorrar2.Visible = true;
            bCancelar.Visible = true;
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
            bCancelar.Visible = true;

            if (lNombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.LineasTableAdapter j = new RelacionesTableAdapters.LineasTableAdapter();
                String b = tbBusqueda.Text;
                tabla = j.BuscarNombre(b);
                lineasDataGridView.DataSource = tabla;
            }
            lNombre.Visible = false;
            lBorrar.Visible = false;
            botones();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bAgregar2.Visible = true;
            idLabel.Visible = true;
            nombreLabel.Visible = true;
            idTextBox.Visible = true;
            nombreTextBox.Visible = true;
            bCancelar.Visible = true;
        }

        private void BAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.LineasTableAdapter j = new RelacionesTableAdapters.LineasTableAdapter();
            String id = idTextBox.Text;
            String nombre = nombreTextBox.Text;
            j.AgregarLinea(id, nombre);
            bAgregar2.Visible = false;
            idLabel.Visible = false;
            nombreLabel.Visible = false;
            idTextBox.Visible = false;
            nombreTextBox.Visible = false;
            bBuscarNombre.Visible = true;
            bBuscar.Visible = false;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bCancelar.Visible = false;
            this.lineasTableAdapter.Fill(this.relaciones.Lineas);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }

        public void botones() {
            bAgregar2.Visible = false;
            idLabel.Visible = false;
            nombreLabel.Visible = false;
            idTextBox.Visible = false;
            bCancelar.Visible = false;
            nombreTextBox.Visible = false;
            bBuscarNombre.Visible = true;
            bBuscar.Visible = false;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            bCancelar.Visible = false;
            bBorrar2.Visible = false;
            bBorrar2.Visible = false;
            tbBusqueda.Visible = false;
            lBorrar.Visible = false;
            tbNombreNuevo.Visible = false;
            lNuevoNombre.Visible = false;
            bModificar2.Visible = false;
            lNombre.Visible = false;
            bBuscar.Visible = false;
            bCancelar.Visible = false;
            this.lineasTableAdapter.Fill(this.relaciones.Lineas);
        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.LineasTableAdapter j = new RelacionesTableAdapters.LineasTableAdapter();
            String b = tbBusqueda.Text;
            j.BorrarLinea(b);
            botones();
            this.lineasTableAdapter.Fill(this.relaciones.Lineas);

        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bAgregar2.Visible = false;
            idLabel.Visible = true;
            nombreLabel.Visible = false;
            idTextBox.Visible = true;
            bCancelar.Visible = true;
            bModificar2.Visible = true;
            tbNombreNuevo.Visible = true;
            lNuevoNombre.Visible = true;
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.LineasTableAdapter j = new RelacionesTableAdapters.LineasTableAdapter();
            String b = tbBusqueda.Text;
            j.ModificarLinea(tbNombreNuevo.Text, idTextBox.Text);
            tbNombreNuevo.Visible = false;
            lNuevoNombre.Visible = false;
            idTextBox.Visible = false;
            bCancelar.Visible = false;
            bModificar2.Visible = false;
            idLabel.Visible = false;
            botones();
            this.lineasTableAdapter.Fill(this.relaciones.Lineas);

        }
    }
}
