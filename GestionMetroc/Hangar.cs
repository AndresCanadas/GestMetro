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
    public partial class Hangar : Form
    {
        public Hangar()
        {
            InitializeComponent();
        }

        private void hangarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hangarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Hangar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Hangar' Puede moverla o quitarla según sea necesario.
            this.hangarTableAdapter.Fill(this.relaciones.Hangar);

        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = false;
            lConductor.Visible = true;
            tbBusqueda.Visible = true;
            lMatricula.Visible = false;
            bBuscar.Visible = true;
            bBuscarMatricula.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
        }

        private void bBuscarLinea_Click(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = false;
            lConductor.Visible = false;
            tbBusqueda.Visible = true;
            lMatricula.Visible = true;
            bBuscar.Visible = true;
            bBuscarMatricula.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
        }

        private void bContar_Click_1(object sender, EventArgs e)
        {
            RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
            var cuenta = h.ContarHangar();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " estaciones en la tabla.");
        }

        private void bBorrar_Click_1(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = false;
            lConductor.Visible = false;
            tbBusqueda.Visible = true;
            lMatricula.Visible = false;
            bBuscar.Visible = true;
            bBuscarMatricula.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
        }

        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            bBuscarConductor.Visible = true;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarMatricula.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lMatricula.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
                String b = tbBusqueda.Text;
                tabla = h.BuscarMatricula(b);
                hangarDataGridView.DataSource = tabla;
            }
            else if (lConductor.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
                String b = tbBusqueda.Text;
                tabla = h.BuscarDniConductor(b);
                hangarDataGridView.DataSource = tabla;
            }
            else if (lBorrar.Visible == true)
            {
                RelacionesTableAdapters.HangarTableAdapter h = new RelacionesTableAdapters.HangarTableAdapter();
                String b = tbBusqueda.Text;
                // c.BorrarConductor(b);
                // this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);
            }

            lMatricula.Visible = false;
            lConductor.Visible = false;
            lBorrar.Visible = false;
        }
    }
}
