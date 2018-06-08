namespace GestionMetroc
{
    partial class Vagones
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
            this.vagonesDataGridView = new System.Windows.Forms.DataGridView();
            this.matriculaLabel = new System.Windows.Forms.Label();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.capacidadPSLabel = new System.Windows.Forms.Label();
            this.capacidadPSTextBox = new System.Windows.Forms.TextBox();
            this.capacidadPPLabel = new System.Windows.Forms.Label();
            this.capacidadPPTextBox = new System.Windows.Forms.TextBox();
            this.fechaConstruccionLabel = new System.Windows.Forms.Label();
            this.fechaConstruccionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.matriculaTrenLabel = new System.Windows.Forms.Label();
            this.matriculaTrenTextBox = new System.Windows.Forms.TextBox();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarDni = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.bModificar2 = new System.Windows.Forms.Button();
            this.bAgregar2 = new System.Windows.Forms.Button();
            this.bBorrar2 = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.lBorrar = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.vagonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaciones = new GestionMetroc.Relaciones();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagonesTableAdapter = new GestionMetroc.RelacionesTableAdapters.VagonesTableAdapter();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vagonesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // vagonesDataGridView
            // 
            this.vagonesDataGridView.AutoGenerateColumns = false;
            this.vagonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vagonesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vagonesDataGridView.DataSource = this.vagonesBindingSource;
            this.vagonesDataGridView.Location = new System.Drawing.Point(129, 264);
            this.vagonesDataGridView.Name = "vagonesDataGridView";
            this.vagonesDataGridView.Size = new System.Drawing.Size(542, 220);
            this.vagonesDataGridView.TabIndex = 1;
            // 
            // matriculaLabel
            // 
            this.matriculaLabel.AutoSize = true;
            this.matriculaLabel.Location = new System.Drawing.Point(204, 74);
            this.matriculaLabel.Name = "matriculaLabel";
            this.matriculaLabel.Size = new System.Drawing.Size(53, 13);
            this.matriculaLabel.TabIndex = 2;
            this.matriculaLabel.Text = "Matricula:";
            this.matriculaLabel.Visible = false;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vagonesBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(315, 71);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(200, 20);
            this.matriculaTextBox.TabIndex = 3;
            this.matriculaTextBox.Visible = false;
            // 
            // capacidadPSLabel
            // 
            this.capacidadPSLabel.AutoSize = true;
            this.capacidadPSLabel.Location = new System.Drawing.Point(204, 100);
            this.capacidadPSLabel.Name = "capacidadPSLabel";
            this.capacidadPSLabel.Size = new System.Drawing.Size(78, 13);
            this.capacidadPSLabel.TabIndex = 4;
            this.capacidadPSLabel.Text = "Capacidad PS:";
            this.capacidadPSLabel.Visible = false;
            // 
            // capacidadPSTextBox
            // 
            this.capacidadPSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vagonesBindingSource, "CapacidadPS", true));
            this.capacidadPSTextBox.Location = new System.Drawing.Point(315, 97);
            this.capacidadPSTextBox.Name = "capacidadPSTextBox";
            this.capacidadPSTextBox.Size = new System.Drawing.Size(200, 20);
            this.capacidadPSTextBox.TabIndex = 5;
            this.capacidadPSTextBox.Visible = false;
            // 
            // capacidadPPLabel
            // 
            this.capacidadPPLabel.AutoSize = true;
            this.capacidadPPLabel.Location = new System.Drawing.Point(204, 126);
            this.capacidadPPLabel.Name = "capacidadPPLabel";
            this.capacidadPPLabel.Size = new System.Drawing.Size(78, 13);
            this.capacidadPPLabel.TabIndex = 6;
            this.capacidadPPLabel.Text = "Capacidad PP:";
            this.capacidadPPLabel.Visible = false;
            // 
            // capacidadPPTextBox
            // 
            this.capacidadPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vagonesBindingSource, "CapacidadPP", true));
            this.capacidadPPTextBox.Location = new System.Drawing.Point(315, 123);
            this.capacidadPPTextBox.Name = "capacidadPPTextBox";
            this.capacidadPPTextBox.Size = new System.Drawing.Size(200, 20);
            this.capacidadPPTextBox.TabIndex = 7;
            this.capacidadPPTextBox.Visible = false;
            // 
            // fechaConstruccionLabel
            // 
            this.fechaConstruccionLabel.AutoSize = true;
            this.fechaConstruccionLabel.Location = new System.Drawing.Point(204, 153);
            this.fechaConstruccionLabel.Name = "fechaConstruccionLabel";
            this.fechaConstruccionLabel.Size = new System.Drawing.Size(105, 13);
            this.fechaConstruccionLabel.TabIndex = 8;
            this.fechaConstruccionLabel.Text = "Fecha Construccion:";
            this.fechaConstruccionLabel.Visible = false;
            // 
            // fechaConstruccionDateTimePicker
            // 
            this.fechaConstruccionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vagonesBindingSource, "FechaConstruccion", true));
            this.fechaConstruccionDateTimePicker.Location = new System.Drawing.Point(315, 149);
            this.fechaConstruccionDateTimePicker.Name = "fechaConstruccionDateTimePicker";
            this.fechaConstruccionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaConstruccionDateTimePicker.TabIndex = 9;
            this.fechaConstruccionDateTimePicker.Visible = false;
            // 
            // matriculaTrenLabel
            // 
            this.matriculaTrenLabel.AutoSize = true;
            this.matriculaTrenLabel.Location = new System.Drawing.Point(204, 178);
            this.matriculaTrenLabel.Name = "matriculaTrenLabel";
            this.matriculaTrenLabel.Size = new System.Drawing.Size(78, 13);
            this.matriculaTrenLabel.TabIndex = 10;
            this.matriculaTrenLabel.Text = "Matricula Tren:";
            this.matriculaTrenLabel.Visible = false;
            // 
            // matriculaTrenTextBox
            // 
            this.matriculaTrenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vagonesBindingSource, "MatriculaTren", true));
            this.matriculaTrenTextBox.Location = new System.Drawing.Point(315, 175);
            this.matriculaTrenTextBox.Name = "matriculaTrenTextBox";
            this.matriculaTrenTextBox.Size = new System.Drawing.Size(200, 20);
            this.matriculaTrenTextBox.TabIndex = 11;
            this.matriculaTrenTextBox.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(593, 12);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(107, 53);
            this.bModificar.TabIndex = 106;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(465, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(107, 53);
            this.bAgregar.TabIndex = 105;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(352, 12);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(107, 53);
            this.bBorrar.TabIndex = 104;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bContar
            // 
            this.bContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContar.Location = new System.Drawing.Point(225, 12);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 103;
            this.bContar.Text = "Contar trenes";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click);
            // 
            // bBuscarDni
            // 
            this.bBuscarDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarDni.Location = new System.Drawing.Point(80, 12);
            this.bBuscarDni.Name = "bBuscarDni";
            this.bBuscarDni.Size = new System.Drawing.Size(127, 53);
            this.bBuscarDni.TabIndex = 101;
            this.bBuscarDni.Text = "Buscar por matricula";
            this.bBuscarDni.UseVisualStyleBackColor = true;
            this.bBuscarDni.Click += new System.EventHandler(this.bBuscarDni_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(316, 128);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(199, 20);
            this.lNombre.TabIndex = 125;
            this.lNombre.Text = "Busqueda por matrícula";
            this.lNombre.Visible = false;
            // 
            // bModificar2
            // 
            this.bModificar2.Location = new System.Drawing.Point(330, 206);
            this.bModificar2.Name = "bModificar2";
            this.bModificar2.Size = new System.Drawing.Size(75, 23);
            this.bModificar2.TabIndex = 124;
            this.bModificar2.Text = "Modificar";
            this.bModificar2.UseVisualStyleBackColor = true;
            this.bModificar2.Visible = false;
            this.bModificar2.Click += new System.EventHandler(this.bModificar2_Click);
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(330, 206);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 123;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.bAgregar2_Click);
            // 
            // bBorrar2
            // 
            this.bBorrar2.Location = new System.Drawing.Point(330, 206);
            this.bBorrar2.Name = "bBorrar2";
            this.bBorrar2.Size = new System.Drawing.Size(75, 23);
            this.bBorrar2.TabIndex = 122;
            this.bBorrar2.Text = "Borrar";
            this.bBorrar2.UseVisualStyleBackColor = true;
            this.bBorrar2.Visible = false;
            this.bBorrar2.Click += new System.EventHandler(this.bBorrar2_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(430, 206);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 121;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(330, 206);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 120;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(362, 128);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 119;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(330, 164);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 117;
            this.tbBusqueda.Visible = false;
            // 
            // vagonesBindingSource
            // 
            this.vagonesBindingSource.DataMember = "Vagones";
            this.vagonesBindingSource.DataSource = this.relaciones;
            // 
            // relaciones
            // 
            this.relaciones.DataSetName = "Relaciones";
            this.relaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CapacidadPS";
            this.dataGridViewTextBoxColumn2.HeaderText = "CapacidadPS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CapacidadPP";
            this.dataGridViewTextBoxColumn3.HeaderText = "CapacidadPP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaConstruccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaConstruccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MatriculaTren";
            this.dataGridViewTextBoxColumn5.HeaderText = "MatriculaTren";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // vagonesTableAdapter
            // 
            this.vagonesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TornosTableAdapter = null;
            this.tableAdapterManager.TrenesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionMetroc.RelacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VagonesTableAdapter = this.vagonesTableAdapter;
            // 
            // Vagones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bModificar2);
            this.Controls.Add(this.bAgregar2);
            this.Controls.Add(this.bBorrar2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.bBuscarDni);
            this.Controls.Add(this.matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(this.capacidadPSLabel);
            this.Controls.Add(this.capacidadPSTextBox);
            this.Controls.Add(this.capacidadPPLabel);
            this.Controls.Add(this.capacidadPPTextBox);
            this.Controls.Add(this.fechaConstruccionLabel);
            this.Controls.Add(this.fechaConstruccionDateTimePicker);
            this.Controls.Add(this.matriculaTrenLabel);
            this.Controls.Add(this.matriculaTrenTextBox);
            this.Controls.Add(this.vagonesDataGridView);
            this.Name = "Vagones";
            this.Text = "Vagones";
            this.Load += new System.EventHandler(this.Vagones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vagonesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource vagonesBindingSource;
        private RelacionesTableAdapters.VagonesTableAdapter vagonesTableAdapter;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vagonesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label matriculaLabel;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.Label capacidadPSLabel;
        private System.Windows.Forms.TextBox capacidadPSTextBox;
        private System.Windows.Forms.Label capacidadPPLabel;
        private System.Windows.Forms.TextBox capacidadPPTextBox;
        private System.Windows.Forms.Label fechaConstruccionLabel;
        private System.Windows.Forms.DateTimePicker fechaConstruccionDateTimePicker;
        private System.Windows.Forms.Label matriculaTrenLabel;
        private System.Windows.Forms.TextBox matriculaTrenTextBox;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarDni;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bModificar2;
        private System.Windows.Forms.Button bAgregar2;
        private System.Windows.Forms.Button bBorrar2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label lBorrar;
        private System.Windows.Forms.TextBox tbBusqueda;
    }
}