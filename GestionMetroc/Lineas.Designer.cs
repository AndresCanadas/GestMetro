namespace GestionMetroc
{
    partial class Lineas
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
            this.lineasDataGridView = new System.Windows.Forms.DataGridView();
            this.lBorrar = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.lineasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaciones = new GestionMetroc.Relaciones();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineasTableAdapter = new GestionMetroc.RelacionesTableAdapters.LineasTableAdapter();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            this.lineasTableAdapter1 = new GestionMetroc.RelacionesTableAdapters.LineasTableAdapter();
            this.bAgregar2 = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBorrar2 = new System.Windows.Forms.Button();
            this.bModificar2 = new System.Windows.Forms.Button();
            this.lNuevoNombre = new System.Windows.Forms.Label();
            this.tbNombreNuevo = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lineasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lineasDataGridView
            // 
            this.lineasDataGridView.AutoGenerateColumns = false;
            this.lineasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lineasDataGridView.DataSource = this.lineasBindingSource;
            this.lineasDataGridView.Location = new System.Drawing.Point(280, 261);
            this.lineasDataGridView.Name = "lineasDataGridView";
            this.lineasDataGridView.Size = new System.Drawing.Size(243, 246);
            this.lineasDataGridView.TabIndex = 1;
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(345, 143);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 100;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(596, 25);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(107, 53);
            this.bModificar.TabIndex = 99;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(472, 25);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(107, 53);
            this.bAgregar.TabIndex = 98;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(348, 25);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(107, 53);
            this.bBorrar.TabIndex = 97;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(300, 146);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(186, 20);
            this.lNombre.TabIndex = 95;
            this.lNombre.Text = "Busqueda por nombre";
            this.lNombre.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(311, 179);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 94;
            this.tbBusqueda.Visible = false;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(367, 217);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 93;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bContar
            // 
            this.bContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContar.Location = new System.Drawing.Point(231, 25);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 92;
            this.bContar.Text = "Contar lineas";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click);
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarNombre.Location = new System.Drawing.Point(107, 25);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(107, 53);
            this.bBuscarNombre.TabIndex = 90;
            this.bBuscarNombre.Text = "Buscar por nombre";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // lineasBindingSource
            // 
            this.lineasBindingSource.DataMember = "Lineas";
            this.lineasBindingSource.DataSource = this.relaciones;
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
            // lineasTableAdapter
            // 
            this.lineasTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LineasTableAdapter = this.lineasTableAdapter;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.TecnicosTableAdapter = null;
            this.tableAdapterManager.TornosTableAdapter = null;
            this.tableAdapterManager.TrenesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionMetroc.RelacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VagonesTableAdapter = null;
            // 
            // lineasTableAdapter1
            // 
            this.lineasTableAdapter1.ClearBeforeFill = true;
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(311, 217);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 104;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.BAgregar2_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(414, 217);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 107;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bBorrar2
            // 
            this.bBorrar2.Location = new System.Drawing.Point(309, 217);
            this.bBorrar2.Name = "bBorrar2";
            this.bBorrar2.Size = new System.Drawing.Size(75, 23);
            this.bBorrar2.TabIndex = 108;
            this.bBorrar2.Text = "Borrar";
            this.bBorrar2.UseVisualStyleBackColor = true;
            this.bBorrar2.Visible = false;
            this.bBorrar2.Click += new System.EventHandler(this.bBorrar2_Click);
            // 
            // bModificar2
            // 
            this.bModificar2.Location = new System.Drawing.Point(311, 217);
            this.bModificar2.Name = "bModificar2";
            this.bModificar2.Size = new System.Drawing.Size(75, 23);
            this.bModificar2.TabIndex = 109;
            this.bModificar2.Text = "Modificar";
            this.bModificar2.UseVisualStyleBackColor = true;
            this.bModificar2.Visible = false;
            this.bModificar2.Click += new System.EventHandler(this.bModificar2_Click);
            // 
            // lNuevoNombre
            // 
            this.lNuevoNombre.AutoSize = true;
            this.lNuevoNombre.Location = new System.Drawing.Point(277, 182);
            this.lNuevoNombre.Name = "lNuevoNombre";
            this.lNuevoNombre.Size = new System.Drawing.Size(80, 13);
            this.lNuevoNombre.TabIndex = 113;
            this.lNuevoNombre.Text = "Nuevo nombre:";
            this.lNuevoNombre.Visible = false;
            // 
            // tbNombreNuevo
            // 
            this.tbNombreNuevo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineasBindingSource, "Nombre", true));
            this.tbNombreNuevo.Location = new System.Drawing.Point(359, 179);
            this.tbNombreNuevo.Name = "tbNombreNuevo";
            this.tbNombreNuevo.Size = new System.Drawing.Size(100, 20);
            this.tbNombreNuevo.TabIndex = 111;
            this.tbNombreNuevo.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(334, 130);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 105;
            this.idLabel.Text = "Id:";
            this.idLabel.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(359, 127);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 101;
            this.idTextBox.Visible = false;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(306, 156);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 106;
            this.nombreLabel.Text = "Nombre:";
            this.nombreLabel.Visible = false;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(359, 153);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 103;
            this.nombreTextBox.Visible = false;
            // 
            // Lineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.lNuevoNombre);
            this.Controls.Add(this.tbNombreNuevo);
            this.Controls.Add(this.bModificar2);
            this.Controls.Add(this.bBorrar2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.bAgregar2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.bBuscarNombre);
            this.Controls.Add(this.lineasDataGridView);
            this.Name = "Lineas";
            this.Text = "Lineas";
            this.Load += new System.EventHandler(this.Lineas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource lineasBindingSource;
        private RelacionesTableAdapters.LineasTableAdapter lineasTableAdapter;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lineasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private RelacionesTableAdapters.LineasTableAdapter lineasTableAdapter1;
        private System.Windows.Forms.Label lBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bAgregar2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBorrar2;
        private System.Windows.Forms.Button bModificar2;
        private System.Windows.Forms.Label lNuevoNombre;
        private System.Windows.Forms.TextBox tbNombreNuevo;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}