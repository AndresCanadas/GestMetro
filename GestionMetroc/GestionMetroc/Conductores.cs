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
    public partial class Conductores : Form
    {
        public Conductores()
        {
            InitializeComponent();
        }

        private void conductoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conductoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Conductores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Conductores' Puede moverla o quitarla según sea necesario.
            this.conductoresTableAdapter.Fill(this.relaciones.Conductores);

        }

        private void bBuscarDni_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            lDni.Visible = true;
            tbBusqueda.Visible = true;
            lNombre.Visible = false;
            bBuscar.Visible = true;
            bBuscarNombre.Visible = false;
            bContar.Visible = false;

        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            lDni.Visible = false;
            tbBusqueda.Visible = true;
            lNombre.Visible = true;
            bBuscar.Visible = true;
            bBuscarNombre.Visible = false;
            bContar.Visible = false;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = true;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarNombre.Visible = true;
            bContar.Visible = true;
            if (lNombre.Visible == true) {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.ConductoresTableAdapter c = new RelacionesTableAdapters.ConductoresTableAdapter();
                String b = tbBusqueda.Text;
                tabla = c.BuscarNombre(b);
                conductoresDataGridView.DataSource = tabla;
            } else if (lDni.Visible == true) {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.ConductoresTableAdapter c = new RelacionesTableAdapters.ConductoresTableAdapter();
                String b = tbBusqueda.Text;
                tabla = c.BusquedaDni(b);
                conductoresDataGridView.DataSource = tabla;
            }

            lNombre.Visible = false;
            lDni.Visible = false;
        }
    }
}
