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
    public partial class Estacion : Form
    {
        public Estacion()
        {
            InitializeComponent();
        }

        private void estacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Estacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Estacion' Puede moverla o quitarla según sea necesario.
            this.estacionTableAdapter.Fill(this.relaciones.Estacion);

        }
        
        private void bBuscarEstacion_Click_1(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lnombre.Visible = true;
            tbBusqueda.Visible = true;
            lIdLinea.Visible = false;
            bBuscar.Visible = true;
            bBuscarLinea.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bBuscarJefe_Click_1(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lnombre.Visible = false;
            tbBusqueda.Visible = true;
            lIdLinea.Visible = true;
            bBuscar.Visible = true;
            bBuscarLinea.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bContar_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.EstacionTableAdapter es = new RelacionesTableAdapters.EstacionTableAdapter();
            var cuenta = es.ContarEstaciones();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " estaciones en la tabla.");
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lnombre.Visible = false;
            lIdLinea.Visible = false;
            bBuscar.Visible = false;
            bBuscarLinea.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            tbBusqueda.Visible = true;
            lBorrar.Visible = true;
            bBorrar2.Visible = true;
            bCancelar.Visible = true;


        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarNombre.Visible = true;
            bBuscarLinea.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lIdLinea.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.EstacionTableAdapter es = new RelacionesTableAdapters.EstacionTableAdapter();
                String b = tbBusqueda.Text;
                tabla = es.BuscarIdLinea(b);
                estacionDataGridView.DataSource = tabla;
            }
            else if (lnombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.EstacionTableAdapter es = new RelacionesTableAdapters.EstacionTableAdapter();
                String b = tbBusqueda.Text;
                tabla = es.BuscarNombre(b);
                estacionDataGridView.DataSource = tabla;
            }

            lIdLinea.Visible = false;
            lnombre.Visible = false;
            lBorrar.Visible = false;
            botones();
        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.EstacionTableAdapter es = new RelacionesTableAdapters.EstacionTableAdapter();
            String b = tbBusqueda.Text;
            es.BorrarEstacion(b);

            botones();
        }

        public void botones() {
            bBuscarNombre.Visible = true;
            bBuscarLinea.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;

            lnombre.Visible = false;
            tbBusqueda.Visible = false;
            lIdLinea.Visible = false;
            bBuscar.Visible = false;
            bBorrar2.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = false;

            idLineaLabel.Visible = false;
            idLabel.Visible = false;
            nombreLabel.Visible = false;

            idTextBox.Visible = false;
            idLineaTextBox.Visible = false;
            nombreTextBox.Visible = false;
            bAgregar2.Visible = false;
            bCancelar.Visible = false;
            bModificar2.Visible = false;

            this.estacionTableAdapter.Fill(this.relaciones.Estacion);


        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {

            bBuscarNombre.Visible = false;
            bBuscarLinea.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;

            idLineaLabel.Visible = true;
            idLabel.Visible = true;
            nombreLabel.Visible = true;

            idTextBox.Visible = true;
            idLineaTextBox.Visible = true;
            nombreTextBox.Visible = true;
            bAgregar2.Visible = true;
            bCancelar.Visible = true;
        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.EstacionTableAdapter es = new RelacionesTableAdapters.EstacionTableAdapter();
            es.AgregarEstacion(idTextBox.Text, nombreTextBox.Text, idLineaTextBox.Text);
            botones();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            bBuscarLinea.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;

            idLineaLabel.Visible = true;
            idLabel.Visible = true;
            nombreLabel.Visible = true;

            idTextBox.Visible = true;
            idLineaTextBox.Visible = true;
            nombreTextBox.Visible = true;
            bModificar2.Visible = true;
            bCancelar.Visible = true;
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.EstacionTableAdapter es = new RelacionesTableAdapters.EstacionTableAdapter();
            es.ModificarEstacion(nombreTextBox.Text, idLineaTextBox.Text, idTextBox.Text);
            botones();
        }
    }
}
