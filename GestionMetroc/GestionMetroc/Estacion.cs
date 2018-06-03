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
            tbBusqueda.Visible = true;
            lIdLinea.Visible = false;
            bBuscar.Visible = true;
            bBuscarLinea.Visible = false;
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
            else if (lBorrar.Visible == true)
            {
                RelacionesTableAdapters.EstacionTableAdapter es = new RelacionesTableAdapters.EstacionTableAdapter();
                String b = tbBusqueda.Text;
                // c.BorrarConductor(b);
                // this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);
            }

            lIdLinea.Visible = false;
            lnombre.Visible = false;
            lBorrar.Visible = false;
        }
    }
}
