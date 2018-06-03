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
    public partial class Cuidados : Form
    {
        public Cuidados()
        {
            InitializeComponent();
        }

        private void cuidadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cuidadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Cuidados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Cuidados' Puede moverla o quitarla según sea necesario.
            this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);

        }

        private void bBuscarDni_Click(object sender, EventArgs e)
        {
            bBuscarMatricula.Visible = false;
            lMatricula.Visible = true;
            tbBusqueda.Visible = true;
            lTecnico.Visible = false;
            bBuscar.Visible = true;
            bBuscarTecnico.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;

        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            bBuscarMatricula.Visible = false;
            lMatricula.Visible = false;
            tbBusqueda.Visible = true;
            lTecnico.Visible = true;
            bBuscar.Visible = true;
            bBuscarTecnico.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = false;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            bBuscarMatricula.Visible = true;
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarTecnico.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lTecnico.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.CuidadosTableAdapter c = new RelacionesTableAdapters.CuidadosTableAdapter();
                String b = tbBusqueda.Text;
                tabla = c.BuscarTecnico(b);
                cuidadosDataGridView.DataSource = tabla;
            }
            else if (lMatricula.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.CuidadosTableAdapter c = new RelacionesTableAdapters.CuidadosTableAdapter();
                String b = tbBusqueda.Text;
                tabla = c.BuscarMatricula(b);
                cuidadosDataGridView.DataSource = tabla;
            }
            else if (lBorrar.Visible == true)
            {
                RelacionesTableAdapters.CuidadosTableAdapter c = new RelacionesTableAdapters.CuidadosTableAdapter();
                String b = tbBusqueda.Text;
               // c.BorrarConductor(b);
                this.cuidadosTableAdapter.Fill(this.relaciones.Cuidados);
            }

            lTecnico.Visible = false;
            lMatricula.Visible = false;
            lBorrar.Visible = false;
        }

        private void bContar_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.CuidadosTableAdapter c = new RelacionesTableAdapters.CuidadosTableAdapter();
            var cuenta = c.ContarCuidados();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " registros de cuidados en la tabla.");
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarMatricula.Visible = false;
            lMatricula.Visible = false;
            tbBusqueda.Visible = true;
            lTecnico.Visible = false;
            bBuscar.Visible = true;
            bBuscarTecnico.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
        }
    }
}
