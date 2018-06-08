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
    public partial class Vagones : Form
    {
        public Vagones()
        {
            InitializeComponent();
        }

        private void vagonesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vagonesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Vagones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Vagones' Puede moverla o quitarla según sea necesario.
            this.vagonesTableAdapter.Fill(this.relaciones.Vagones);

        }

        private void bBuscarDni_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
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
            RelacionesTableAdapters.TrenesTableAdapter n = new RelacionesTableAdapters.TrenesTableAdapter();
            var cuenta = n.ContarTrenes();
            MessageBox.Show("Hay en total de " + cuenta.ToString() + " trenes en la tabla.");
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            bBuscarDni.Visible = false;
            lNombre.Visible = false;
            tbBusqueda.Visible = true;
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
            matriculaLabel.Visible = true;
            capacidadPPLabel.Visible = true;
            capacidadPSLabel.Visible = true;
            fechaConstruccionLabel.Visible = true;
            matriculaTrenLabel.Visible = true;

            matriculaTextBox.Visible = true;
            capacidadPPTextBox.Visible = true;
            capacidadPSTextBox.Visible = true;
            fechaConstruccionDateTimePicker.Visible = true;
            matriculaTrenTextBox.Visible = true;

            bAgregar2.Visible = true;
            bCancelar.Visible = true;


            bBuscarDni.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            matriculaLabel.Visible = true;
            capacidadPPLabel.Visible = true;
            capacidadPSLabel.Visible = true;
            fechaConstruccionLabel.Visible = true;
            matriculaTrenLabel.Visible = true;

            matriculaTextBox.Visible = true;
            capacidadPPTextBox.Visible = true;
            capacidadPSTextBox.Visible = true;
            fechaConstruccionDateTimePicker.Visible = true;
            matriculaTrenTextBox.Visible = true;
            bModificar2.Visible = true;
            bCancelar.Visible = true;


            bBuscarDni.Visible = false;
            bContar.Visible = false;
            bBorrar.Visible = false;
            bAgregar.Visible = false;
            bModificar.Visible = false;
        }

        public void botones()
        {
            bBuscarDni.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;

            lNombre.Visible = false;
            tbBusqueda.Visible = false;
            lBorrar.Visible = false;
            bCancelar.Visible = false;
            bBorrar2.Visible = false;
            bModificar2.Visible = false;
            bAgregar2.Visible = false;
            bBuscar.Visible = false;

            matriculaLabel.Visible = false;
            capacidadPPLabel.Visible = false;
            capacidadPSLabel.Visible = false;
            fechaConstruccionLabel.Visible = false;
            matriculaTrenLabel.Visible = false;

            matriculaTextBox.Visible = false;
            capacidadPPTextBox.Visible = false;
            capacidadPSTextBox.Visible = false;
            fechaConstruccionDateTimePicker.Visible = false;
            matriculaTrenTextBox.Visible = false;
            bAgregar2.Visible = false;
            bCancelar.Visible = false;
            bModificar2.Visible = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }

        private void bAgregar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.VagonesTableAdapter n = new RelacionesTableAdapters.VagonesTableAdapter();
            var fecha = fechaConstruccionDateTimePicker.Value.ToShortDateString();
            n.AgregarVagones(matriculaTextBox.Text, Convert.ToInt32(capacidadPSTextBox.Text), Convert.ToInt32(capacidadPPTextBox.Text), fecha, matriculaTrenTextBox.Text);
            botones();
            this.vagonesTableAdapter.Fill(this.relaciones.Vagones);
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            tbBusqueda.Visible = false;
            bBuscar.Visible = false;
            bBuscarDni.Visible = true;
            bContar.Visible = true;
            bBorrar.Visible = true;
            bAgregar.Visible = true;
            bModificar.Visible = true;
            if (lNombre.Visible == true)
            {
                DataTable tabla = new DataTable();
                RelacionesTableAdapters.VagonesTableAdapter n = new RelacionesTableAdapters.VagonesTableAdapter();
                String b = tbBusqueda.Text;
                tabla = n.buscarMatricula(b);
                vagonesDataGridView.DataSource = tabla;
            }

            lNombre.Visible = false;
            lBorrar.Visible = false;
            botones();
            this.vagonesTableAdapter.Fill(this.relaciones.Vagones);
        }

        private void bModificar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.VagonesTableAdapter n = new RelacionesTableAdapters.VagonesTableAdapter();
            var fecha = fechaConstruccionDateTimePicker.Value.ToShortDateString();
            n.ModificarVagones(Convert.ToInt32(capacidadPSTextBox.Text), Convert.ToInt32(capacidadPPTextBox.Text), fecha, matriculaTrenTextBox.Text, matriculaTextBox.Text);
            botones();
            this.vagonesTableAdapter.Fill(this.relaciones.Vagones);
        }

        private void bBorrar2_Click(object sender, EventArgs e)
        {
            RelacionesTableAdapters.VagonesTableAdapter n = new RelacionesTableAdapters.VagonesTableAdapter();
            String b = tbBusqueda.Text;
            n.BorrarVagones(b);
            botones();
            this.vagonesTableAdapter.Fill(this.relaciones.Vagones);
        }
    }
}
