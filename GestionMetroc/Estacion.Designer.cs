namespace GestionMetroc
{
    partial class Estacion
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
            this.lBorrar = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.lIdLinea = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarLinea = new System.Windows.Forms.Button();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.estacionDataGridView = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idLineaLabel = new System.Windows.Forms.Label();
            this.idLineaTextBox = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBorrar2 = new System.Windows.Forms.Button();
            this.bAgregar2 = new System.Windows.Forms.Button();
            this.estacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaciones = new GestionMetroc.Relaciones();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            this.estacionTableAdapter = new GestionMetroc.RelacionesTableAdapters.EstacionTableAdapter();
            this.bModificar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(361, 206);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 67;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(659, 45);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(107, 53);
            this.bModificar.TabIndex = 66;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(535, 45);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(107, 53);
            this.bAgregar.TabIndex = 65;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(411, 45);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(107, 53);
            this.bBorrar.TabIndex = 64;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // lIdLinea
            // 
            this.lIdLinea.AutoSize = true;
            this.lIdLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdLinea.Location = new System.Drawing.Point(314, 206);
            this.lIdLinea.Name = "lIdLinea";
            this.lIdLinea.Size = new System.Drawing.Size(186, 20);
            this.lIdLinea.TabIndex = 63;
            this.lIdLinea.Text = "Busqueda por IdLinea";
            this.lIdLinea.Visible = false;
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombre.Location = new System.Drawing.Point(314, 206);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(186, 20);
            this.lnombre.TabIndex = 62;
            this.lnombre.Text = "Busqueda por nombre";
            this.lnombre.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(318, 245);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 61;
            this.tbBusqueda.Visible = false;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(327, 288);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 60;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bContar
            // 
            this.bContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContar.Location = new System.Drawing.Point(286, 45);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 59;
            this.bContar.Text = "Contar estaciones";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click);
            // 
            // bBuscarLinea
            // 
            this.bBuscarLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarLinea.Location = new System.Drawing.Point(161, 45);
            this.bBuscarLinea.Name = "bBuscarLinea";
            this.bBuscarLinea.Size = new System.Drawing.Size(107, 53);
            this.bBuscarLinea.TabIndex = 58;
            this.bBuscarLinea.Text = "Buscar por Id linea";
            this.bBuscarLinea.UseVisualStyleBackColor = true;
            this.bBuscarLinea.Click += new System.EventHandler(this.bBuscarJefe_Click_1);
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarNombre.Location = new System.Drawing.Point(37, 45);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(107, 53);
            this.bBuscarNombre.TabIndex = 57;
            this.bBuscarNombre.Text = "Buscar por nombre";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarEstacion_Click_1);
            // 
            // estacionDataGridView
            // 
            this.estacionDataGridView.AutoGenerateColumns = false;
            this.estacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.estacionDataGridView.DataSource = this.estacionBindingSource;
            this.estacionDataGridView.Location = new System.Drawing.Point(232, 340);
            this.estacionDataGridView.Name = "estacionDataGridView";
            this.estacionDataGridView.Size = new System.Drawing.Size(344, 220);
            this.estacionDataGridView.TabIndex = 67;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(302, 196);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 67;
            this.idLabel.Text = "Id:";
            this.idLabel.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(356, 193);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 68;
            this.idTextBox.Visible = false;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(302, 222);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 69;
            this.nombreLabel.Text = "Nombre:";
            this.nombreLabel.Visible = false;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(356, 219);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 70;
            this.nombreTextBox.Visible = false;
            // 
            // idLineaLabel
            // 
            this.idLineaLabel.AutoSize = true;
            this.idLineaLabel.Location = new System.Drawing.Point(302, 248);
            this.idLineaLabel.Name = "idLineaLabel";
            this.idLineaLabel.Size = new System.Drawing.Size(48, 13);
            this.idLineaLabel.TabIndex = 71;
            this.idLineaLabel.Text = "Id Linea:";
            this.idLineaLabel.Visible = false;
            // 
            // idLineaTextBox
            // 
            this.idLineaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionBindingSource, "IdLinea", true));
            this.idLineaTextBox.Location = new System.Drawing.Point(356, 245);
            this.idLineaTextBox.Name = "idLineaTextBox";
            this.idLineaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idLineaTextBox.TabIndex = 72;
            this.idLineaTextBox.Visible = false;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(411, 288);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 73;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bBorrar2
            // 
            this.bBorrar2.Location = new System.Drawing.Point(327, 288);
            this.bBorrar2.Name = "bBorrar2";
            this.bBorrar2.Size = new System.Drawing.Size(75, 23);
            this.bBorrar2.TabIndex = 74;
            this.bBorrar2.Text = "Borrar";
            this.bBorrar2.UseVisualStyleBackColor = true;
            this.bBorrar2.Visible = false;
            this.bBorrar2.Click += new System.EventHandler(this.bBorrar2_Click);
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(327, 288);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 75;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.bAgregar2_Click);
            // 
            // estacionBindingSource
            // 
            this.estacionBindingSource.DataMember = "Estacion";
            this.estacionBindingSource.DataSource = this.relaciones;
            // 
            // relaciones
            // 
            this.relaciones.DataSetName = "Relaciones";
            this.relaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdLinea";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdLinea";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConductoresTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CuidadosTableAdapter = null;
            this.tableAdapterManager.EstacionTableAdapter = null;
            this.tableAdapterManager.HangarTableAdapter = null;
            this.tableAdapterManager.IncidenciasTableAdapter = null;
            this.tableAdapterManager.JefeEstacionTableAdapter = null;
            this.tableAdapterManager.LineasTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.TecnicosTableAdapter = null;
            this.tableAdapterManager.TornosTableAdapter = null;
            this.tableAdapterManager.TrenesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionMetroc.RelacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VagonesTableAdapter = null;
            // 
            // estacionTableAdapter
            // 
            this.estacionTableAdapter.ClearBeforeFill = true;
            // 
            // bModificar2
            // 
            this.bModificar2.Location = new System.Drawing.Point(327, 288);
            this.bModificar2.Name = "bModificar2";
            this.bModificar2.Size = new System.Drawing.Size(75, 23);
            this.bModificar2.TabIndex = 76;
            this.bModificar2.Text = "Modificar";
            this.bModificar2.UseVisualStyleBackColor = true;
            this.bModificar2.Visible = false;
            this.bModificar2.Click += new System.EventHandler(this.bModificar2_Click);
            // 
            // Estacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 580);
            this.Controls.Add(this.bModificar2);
            this.Controls.Add(this.bAgregar2);
            this.Controls.Add(this.bBorrar2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.idLineaLabel);
            this.Controls.Add(this.idLineaTextBox);
            this.Controls.Add(this.estacionDataGridView);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.lIdLinea);
            this.Controls.Add(this.lnombre);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.bBuscarLinea);
            this.Controls.Add(this.bBuscarNombre);
            this.Name = "Estacion";
            this.Text = "Estacion";
            this.Load += new System.EventHandler(this.Estacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource estacionBindingSource;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Label lIdLinea;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarLinea;
        private System.Windows.Forms.Button bBuscarNombre;
        private RelacionesTableAdapters.EstacionTableAdapter estacionTableAdapter;
        private System.Windows.Forms.DataGridView estacionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label idLineaLabel;
        private System.Windows.Forms.TextBox idLineaTextBox;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBorrar2;
        private System.Windows.Forms.Button bAgregar2;
        private System.Windows.Forms.Button bModificar2;
    }
}