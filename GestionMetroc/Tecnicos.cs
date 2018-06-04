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
    public partial class Tecnicos : Form
    {
        public Tecnicos()
        {
            InitializeComponent();
        }

        private void tecnicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tecnicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Tecnicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Tecnicos' Puede moverla o quitarla según sea necesario.
            this.tecnicosTableAdapter.Fill(this.relaciones.Tecnicos);

        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
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
            bCancelar.Visible = true;
        }

        private void bBuscarEstacion_Click(object sender, EventArgs e)
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
            bCancelar.Visible = true;
        }

        private void bContar_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TecnicosTableAdapter t = new RelacionesTableAdapters.TecnicosTableAdapter();
            var cuenta = t.ContarTecnicos();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " técnicos en la tabla.");
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarNombre.Visible = true;
            bBuscarEstacion.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lNombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.TecnicosTableAdapter t = new RelacionesTableAdapters.TecnicosTableAdapter();
                String b = tbBusqueda.Text;
                tabla = t.BuscarNombre(b);
                tecnicosDataGridView.DataSource = tabla;
                
            }
            else if (lEstacion.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.TecnicosTableAdapter t = new RelacionesTableAdapters.TecnicosTableAdapter();
                String b = tbBusqueda.Text;
                tabla = t.BuscarDni(b);
                tecnicosDataGridView.DataSource = tabla;
            }

            lEstacion.Visible = false;
            lNombre.Visible = false;
            lBorrar.Visible = false;
            botones();
            this.tecnicosTableAdapter.Fill(this.relaciones.Tecnicos);
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarNombre.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
            lEstacion.Visible = false;
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            lBorrar.Visible = true;
            bCancelar.Visible = true;
            bBorrar2.Visible = true;
        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TecnicosTableAdapter t = new RelacionesTableAdapters.TecnicosTableAdapter();
            t.BorrarTecnico(tbBusqueda.Text);
            botones();
            this.tecnicosTableAdapter.Fill(this.relaciones.Tecnicos);
        }

        public void botones() {

            
            bBuscarEstacion.Visible = true;
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

            dniLabel.Visible = false;
            nombreLabel.Visible = false;
            apellidosLabel.Visible = false;
            direccionLabel.Visible = false;
            telefonoLabel.Visible = false;
            emailLabel.Visible = false;
            fechaNacimientoLabel.Visible = false;
            fechaEntradaLabel.Visible = false;
            tipoTrabajoLabel.Visible = false;

            dniTextBox.Visible = false;
            nombreTextBox.Visible = false;
            apellidosTextBox.Visible = false;
            direccionTextBox.Visible = false;
            telefonoTextBox.Visible = false;
            emailTextBox.Visible = false;
            fechaNacimientoDateTimePicker.Visible = false;
            fechaEntradaDateTimePicker.Visible = false;
            tipoTrabajoTextBox.Visible = false;

            bAgregar2.Visible = false;
            bModificar2.Visible = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
            this.tecnicosTableAdapter.Fill(this.relaciones.Tecnicos);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {

            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            bBuscarNombre.Visible = false;


            dniLabel.Visible = true;
            nombreLabel.Visible = true;
            apellidosLabel.Visible = true;
            direccionLabel.Visible = true;
            telefonoLabel.Visible = true;
            emailLabel.Visible = true;
            fechaNacimientoLabel.Visible = true;
            fechaEntradaLabel.Visible = true;
            tipoTrabajoLabel.Visible = true;

            dniTextBox.Visible = true;
            nombreTextBox.Visible = true;
            apellidosTextBox.Visible = true;
            direccionTextBox.Visible = true;
            telefonoTextBox.Visible = true;
            emailTextBox.Visible = true;
            fechaNacimientoDateTimePicker.Visible = true;
            fechaEntradaDateTimePicker.Visible = true;
            tipoTrabajoTextBox.Visible = true;

            bAgregar2.Visible = true;
            bCancelar.Visible = true;
        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TecnicosTableAdapter t = new RelacionesTableAdapters.TecnicosTableAdapter();
            var fechaNacimiento = fechaNacimientoDateTimePicker.Value.ToShortDateString();
            var fechaEntrada = fechaEntradaDateTimePicker.Value.ToShortDateString();
            t.AgregarTecnico(dniTextBox.Text, nombreTextBox.Text, apellidosTextBox.Text, direccionTextBox.Text, Convert.ToInt32(telefonoTextBox.Text), emailTextBox.Text, fechaNacimiento, fechaEntrada, tipoTrabajoTextBox.Text);
            botones();
            this.tecnicosTableAdapter.Fill(this.relaciones.Tecnicos);

        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            bBuscarEstacion.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
            bBuscarNombre.Visible = false;


            dniLabel.Visible = true;
            nombreLabel.Visible = true;
            apellidosLabel.Visible = true;
            direccionLabel.Visible = true;
            telefonoLabel.Visible = true;
            emailLabel.Visible = true;
            fechaNacimientoLabel.Visible = true;
            fechaEntradaLabel.Visible = true;
            tipoTrabajoLabel.Visible = true;

            dniTextBox.Visible = true;
            nombreTextBox.Visible = true;
            apellidosTextBox.Visible = true;
            direccionTextBox.Visible = true;
            telefonoTextBox.Visible = true;
            emailTextBox.Visible = true;
            fechaNacimientoDateTimePicker.Visible = true;
            fechaEntradaDateTimePicker.Visible = true;
            tipoTrabajoTextBox.Visible = true;

            bModificar2.Visible = true;
            bCancelar.Visible = true;
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.TecnicosTableAdapter t = new RelacionesTableAdapters.TecnicosTableAdapter();
            var fechaNacimiento = fechaNacimientoDateTimePicker.Value.ToShortDateString();
            var fechaEntrada = fechaEntradaDateTimePicker.Value.ToShortDateString();
            t.ModificarTecnico(nombreTextBox.Text, apellidosTextBox.Text, direccionTextBox.Text, Convert.ToInt32(telefonoTextBox.Text), emailTextBox.Text, fechaNacimiento, fechaEntrada, tipoTrabajoTextBox.Text, dniTextBox.Text);
            botones();
            this.tecnicosTableAdapter.Fill(this.relaciones.Tecnicos);

        }
    }
}
