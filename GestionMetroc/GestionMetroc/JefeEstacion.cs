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
    public partial class JefeEstacion : Form
    {
        public JefeEstacion()
        {
            InitializeComponent();
        }

        private void jefeEstacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jefeEstacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void JefeEstacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.JefeEstacion' Puede moverla o quitarla según sea necesario.
            this.jefeEstacionTableAdapter.Fill(this.relaciones.JefeEstacion);

        }

        private void bBuscarConductor_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = true;
            tbBusqueda.Visible = true;
            lEstacion.Visible = false;
            bBuscar.Visible = true;
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
        }

        private void bBuscarMatricula_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            lEstacion.Visible = true;
            bBuscar.Visible = true;
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
        }

        private void bContar_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
            var cuenta = j.ContarJefe();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " jefes de estación en la tabla.");
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = true;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarEstacion.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lEstacion.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
                String b = tbBusqueda.Text;
                tabla = j.BuscarEstacion(b);
                jefeEstacionDataGridView.DataSource = tabla;
            }
            else if (lNombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
                String b = tbBusqueda.Text;
                tabla = j.BuscarNombre(b);
                jefeEstacionDataGridView.DataSource = tabla;
            }
            else if (lBorrar.Visible == true)
            {
                RelacionesTableAdapters.JefeEstacionTableAdapter j = new RelacionesTableAdapters.JefeEstacionTableAdapter();
                String b = tbBusqueda.Text;
                // c.BorrarConductor(b);
                // this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);
            }

            lEstacion.Visible = false;
            lNombre.Visible = false;
            lBorrar.Visible = false;
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            lEstacion.Visible = false;
            bBuscar.Visible = true;
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
        }
    }
}
