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
    public partial class Tornos : Form
    {
        public Tornos()
        {
            InitializeComponent();
        }

        private void tornosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tornosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Tornos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Tornos' Puede moverla o quitarla según sea necesario.
            this.tornosTableAdapter.Fill(this.relaciones.Tornos);

        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = true;
            tbBusqueda.Visible = true;
            lEstacion.Visible = false;
            bBuscar.Visible = true;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = true;
        }

        private void bBuscarEstacion_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            lEstacion.Visible = true;
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
            RelacionesTableAdapters.TecnicosTableAdapter t = new RelacionesTableAdapters.TecnicosTableAdapter();
            var cuenta = t.ContarTecnicos();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " técnicos en la tabla.");
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            lEstacion.Visible = false;
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
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            bBuscarNombre.Visible = false;

            idLabel.Visible = true;
            npeLabel.Visible = true;
            npsLabel.Visible = true;
            estacionLabel.Visible = true;

            idTextBox.Visible = true;
            npeTextBox.Visible = true;
            npsTextBox.Visible = true;
            estacionTextBox.Visible = true;

            bAgregar2.Visible = true;
            bCancelar.Visible = true;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            bBuscarNombre.Visible = false;


            idLabel.Visible = true;
            npeLabel.Visible = true;
            npsLabel.Visible = true;
            estacionLabel.Visible = true;

            idTextBox.Visible = true;
            npeTextBox.Visible = true;
            npsTextBox.Visible = true;
            estacionTextBox.Visible = true;

            bModificar2.Visible = true;
            bCancelar.Visible = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }

        public void botones() {
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            bBuscarNombre.Visible = true;

            lNombre.Visible = false;
            tbBusqueda.Visible = false;
            lEstacion.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = false;
            bBuscar.Visible = false;
            bBorrar2.Visible = false;

            idLabel.Visible = false;
            npeLabel.Visible = false;
            npsLabel.Visible = false;
            estacionLabel.Visible = false;

            idTextBox.Visible = false;
            npeTextBox.Visible = false;
            npsTextBox.Visible = false;
            estacionTextBox.Visible = false;

            bModificar2.Visible = false;
            bCancelar.Visible = false;
            bAgregar2.Visible = false;
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TornosTableAdapter t = new RelacionesTableAdapters.TornosTableAdapter();
            t.ModificarTorno(npeTextBox.Text, npsTextBox.Text, estacionTextBox.Text, Convert.ToInt32(idTextBox.Text));
            botones();
            this.tornosTableAdapter.Fill(this.relaciones.Tornos);
        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TornosTableAdapter t = new RelacionesTableAdapters.TornosTableAdapter();
            t.AgregarTornos(Convert.ToInt32(idTextBox.Text), npeTextBox.Text, npsTextBox.Text, estacionTextBox.Text);
            botones();
            this.tornosTableAdapter.Fill(this.relaciones.Tornos);
        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TornosTableAdapter t = new RelacionesTableAdapters.TornosTableAdapter();
            t.BorrarTornos(Convert.ToInt32(tbBusqueda.Text));
            botones();
            this.tornosTableAdapter.Fill(this.relaciones.Tornos);
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarNombre.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lNombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.TornosTableAdapter t = new RelacionesTableAdapters.TornosTableAdapter();
                String b = tbBusqueda.Text;
                tabla = t.BuscarEstacion(b);
                tornosDataGridView.DataSource = tabla;

            }

            lEstacion.Visible = false;
            lNombre.Visible = false;
            lBorrar.Visible = false;
            botones();
        }
    }
}
