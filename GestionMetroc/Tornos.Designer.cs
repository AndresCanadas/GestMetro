namespace GestionMetroc
{
    partial class Tornos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.idLabel = new System.Windows.Forms.Label();
            this.npeLabel = new System.Windows.Forms.Label();
            this.npsLabel = new System.Windows.Forms.Label();
            this.estacionLabel = new System.Windows.Forms.Label();
            this.relaciones = new GestionMetroc.Relaciones();
            this.tornosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tornosTableAdapter = new GestionMetroc.RelacionesTableAdapters.TornosTableAdapter();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            this.tornosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.npeTextBox = new System.Windows.Forms.TextBox();
            this.npsTextBox = new System.Windows.Forms.TextBox();
            this.estacionTextBox = new System.Windows.Forms.TextBox();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bModificar2 = new System.Windows.Forms.Button();
            this.bAgregar2 = new System.Windows.Forms.Button();
            this.bBorrar2 = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.lBorrar = new System.Windows.Forms.Label();
            this.lEstacion = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tornosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tornosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(313, 145);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Id:";
            this.idLabel.Visible = false;
            // 
            // npeLabel
            // 
            this.npeLabel.AutoSize = true;
            this.npeLabel.Location = new System.Drawing.Point(313, 171);
            this.npeLabel.Name = "npeLabel";
            this.npeLabel.Size = new System.Drawing.Size(30, 13);
            this.npeLabel.TabIndex = 4;
            this.npeLabel.Text = "Npe:";
            this.npeLabel.Visible = false;
            // 
            // npsLabel
            // 
            this.npsLabel.AutoSize = true;
            this.npsLabel.Location = new System.Drawing.Point(313, 197);
            this.npsLabel.Name = "npsLabel";
            this.npsLabel.Size = new System.Drawing.Size(29, 13);
            this.npsLabel.TabIndex = 6;
            this.npsLabel.Text = "Nps:";
            this.npsLabel.Visible = false;
            // 
            // estacionLabel
            // 
            this.estacionLabel.AutoSize = true;
            this.estacionLabel.Location = new System.Drawing.Point(313, 223);
            this.estacionLabel.Name = "estacionLabel";
            this.estacionLabel.Size = new System.Drawing.Size(51, 13);
            this.estacionLabel.TabIndex = 8;
            this.estacionLabel.Text = "Estacion:";
            this.estacionLabel.Visible = false;
            // 
            // relaciones
            // 
            this.relaciones.DataSetName = "Relaciones";
            this.relaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tornosBindingSource
            // 
            this.tornosBindingSource.DataMember = "Tornos";
            this.tornosBindingSource.DataSource = this.relaciones;
            // 
            // tornosTableAdapter
            // 
            this.tornosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConductoresTableAdapter = null;
            this.tableAdapterManager.CuidadosTableAdapter = null;
            this.tableAdapterManager.EstacionTableAdapter = null;
            this.tableAdapterManager.HangarTableAdapter = null;
            this.tableAdapterManager.IncidenciasTableAdapter = null;
            this.tableAdapterManager.JefeEstacionTableAdapter = null;
            this.tableAdapterManager.LineasTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.TecnicosTableAdapter = null;
            this.tableAdapterManager.TornosTableAdapter = this.tornosTableAdapter;
            this.tableAdapterManager.TrenesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionMetroc.RelacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VagonesTableAdapter = null;
            // 
            // tornosDataGridView
            // 
            this.tornosDataGridView.AutoGenerateColumns = false;
            this.tornosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tornosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tornosDataGridView.DataSource = this.tornosBindingSource;
            this.tornosDataGridView.Location = new System.Drawing.Point(178, 303);
            this.tornosDataGridView.Name = "tornosDataGridView";
            this.tornosDataGridView.Size = new System.Drawing.Size(439, 213);
            this.tornosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Npe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Npe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nps";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nps";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estacion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tornosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(370, 142);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.Visible = false;
            // 
            // npeTextBox
            // 
            this.npeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tornosBindingSource, "Npe", true));
            this.npeTextBox.Location = new System.Drawing.Point(370, 168);
            this.npeTextBox.Name = "npeTextBox";
            this.npeTextBox.Size = new System.Drawing.Size(100, 20);
            this.npeTextBox.TabIndex = 5;
            this.npeTextBox.Visible = false;
            // 
            // npsTextBox
            // 
            this.npsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tornosBindingSource, "Nps", true));
            this.npsTextBox.Location = new System.Drawing.Point(370, 194);
            this.npsTextBox.Name = "npsTextBox";
            this.npsTextBox.Size = new System.Drawing.Size(100, 20);
            this.npsTextBox.TabIndex = 7;
            this.npsTextBox.Visible = false;
            // 
            // estacionTextBox
            // 
            this.estacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tornosBindingSource, "Estacion", true));
            this.estacionTextBox.Location = new System.Drawing.Point(370, 220);
            this.estacionTextBox.Name = "estacionTextBox";
            this.estacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.estacionTextBox.TabIndex = 9;
            this.estacionTextBox.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(588, 30);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(107, 53);
            this.bModificar.TabIndex = 100;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(464, 30);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(107, 53);
            this.bAgregar.TabIndex = 99;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(340, 30);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(107, 53);
            this.bBorrar.TabIndex = 98;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bContar
            // 
            this.bContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContar.Location = new System.Drawing.Point(220, 30);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 97;
            this.bContar.Text = "Contar tornos";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click);
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarNombre.Location = new System.Drawing.Point(97, 30);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(107, 53);
            this.bBuscarNombre.TabIndex = 95;
            this.bBuscarNombre.Text = "Buscar por estación";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bModificar2
            // 
            this.bModificar2.Location = new System.Drawing.Point(289, 251);
            this.bModificar2.Name = "bModificar2";
            this.bModificar2.Size = new System.Drawing.Size(75, 23);
            this.bModificar2.TabIndex = 120;
            this.bModificar2.Text = "Modificar";
            this.bModificar2.UseVisualStyleBackColor = true;
            this.bModificar2.Visible = false;
            this.bModificar2.Click += new System.EventHandler(this.bModificar2_Click);
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(336, 251);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 119;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.bAgregar2_Click);
            // 
            // bBorrar2
            // 
            this.bBorrar2.Location = new System.Drawing.Point(336, 251);
            this.bBorrar2.Name = "bBorrar2";
            this.bBorrar2.Size = new System.Drawing.Size(75, 23);
            this.bBorrar2.TabIndex = 118;
            this.bBorrar2.Text = "Borrar";
            this.bBorrar2.UseVisualStyleBackColor = true;
            this.bBorrar2.Visible = false;
            this.bBorrar2.Click += new System.EventHandler(this.bBorrar2_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(417, 251);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 117;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(366, 180);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 116;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // lEstacion
            // 
            this.lEstacion.AutoSize = true;
            this.lEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstacion.Location = new System.Drawing.Point(345, 180);
            this.lEstacion.Name = "lEstacion";
            this.lEstacion.Size = new System.Drawing.Size(157, 20);
            this.lEstacion.TabIndex = 115;
            this.lEstacion.Text = "Busqueda por DNI";
            this.lEstacion.Visible = false;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(327, 180);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(194, 20);
            this.lNombre.TabIndex = 114;
            this.lNombre.Text = "Busqueda por estacion";
            this.lNombre.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(327, 210);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 113;
            this.tbBusqueda.Visible = false;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(336, 251);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 112;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // Tornos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.bModificar2);
            this.Controls.Add(this.bAgregar2);
            this.Controls.Add(this.bBorrar2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.lEstacion);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.bBuscarNombre);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.npeLabel);
            this.Controls.Add(this.npeTextBox);
            this.Controls.Add(this.npsLabel);
            this.Controls.Add(this.npsTextBox);
            this.Controls.Add(this.estacionLabel);
            this.Controls.Add(this.estacionTextBox);
            this.Controls.Add(this.tornosDataGridView);
            this.Name = "Tornos";
            this.Text = "Tornos";
            this.Load += new System.EventHandler(this.Tornos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tornosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tornosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource tornosBindingSource;
        private RelacionesTableAdapters.TornosTableAdapter tornosTableAdapter;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tornosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox npeTextBox;
        private System.Windows.Forms.TextBox npsTextBox;
        private System.Windows.Forms.TextBox estacionTextBox;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bModificar2;
        private System.Windows.Forms.Button bAgregar2;
        private System.Windows.Forms.Button bBorrar2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label lBorrar;
        private System.Windows.Forms.Label lEstacion;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label npeLabel;
        private System.Windows.Forms.Label npsLabel;
        private System.Windows.Forms.Label estacionLabel;
    }
}