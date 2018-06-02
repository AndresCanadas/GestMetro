using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMetroc
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void estacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaciones);

        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaciones.Estacion' Puede moverla o quitarla según sea necesario.
            this.estacionTableAdapter.Fill(this.relaciones.Estacion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable tabla = new DataTable();
            RelacionesTableAdapters.EstacionTableAdapter Estaciones = new RelacionesTableAdapters.EstacionTableAdapter();
            String prueba = tbNombre.Text;
            String prueba2 = tbNombre.Text;
            int pruebita2 = Convert.ToInt32(idLineaTextBox.Text);
            //String nombre = nombreTextBox.Text;

            Estaciones.Delete(idTextBox.Text, nombreTextBox.Text, pruebita2);

            estacionDataGridView.DataSource = tabla;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
