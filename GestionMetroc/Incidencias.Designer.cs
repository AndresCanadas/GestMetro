namespace GestionMetroc
{
    partial class Incidencias
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
            this.incidenciasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaciones = new GestionMetroc.Relaciones();
            this.lBorrar = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.lJefe = new System.Windows.Forms.Label();
            this.lEstacion = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarJefe = new System.Windows.Forms.Button();
            this.bBuscarEstacion = new System.Windows.Forms.Button();
            this.incidenciasTableAdapter = new GestionMetroc.RelacionesTableAdapters.IncidenciasTableAdapter();
            this.incidenciasTableAdapter1 = new GestionMetroc.RelacionesTableAdapters.IncidenciasTableAdapter();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            this.bBorrar2 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.nombreEstacionTextBox = new System.Windows.Forms.TextBox();
            this.caracteristicasTextBox = new System.Windows.Forms.TextBox();
            this.valoracionTextBox = new System.Windows.Forms.TextBox();
            this.dniJefeTextBox = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.LabelHora = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelCarac = new System.Windows.Forms.Label();
            this.LabelValoracion = new System.Windows.Forms.Label();
            this.LabelDni = new System.Windows.Forms.Label();
            this.bAgregar2 = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // incidenciasDataGridView
            // 
            this.incidenciasDataGridView.AutoGenerateColumns = false;
            this.incidenciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidenciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.incidenciasDataGridView.DataSource = this.incidenciasBindingSource;
            this.incidenciasDataGridView.Location = new System.Drawing.Point(21, 276);
            this.incidenciasDataGridView.Name = "incidenciasDataGridView";
            this.incidenciasDataGridView.Size = new System.Drawing.Size(748, 237);
            this.incidenciasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreEstacion";
            this.dataGridViewTextBoxColumn4.HeaderText = "NombreEstacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Caracteristicas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Caracteristicas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Valoracion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valoracion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DniJefe";
            this.dataGridViewTextBoxColumn7.HeaderText = "DniJefe";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // incidenciasBindingSource
            // 
            this.incidenciasBindingSource.DataMember = "Incidencias";
            this.incidenciasBindingSource.DataSource = this.relaciones;
            // 
            // relaciones
            // 
            this.relaciones.DataSetName = "Relaciones";
            this.relaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(359, 132);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 56;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(611, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(107, 53);
            this.bAgregar.TabIndex = 54;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(487, 12);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(107, 53);
            this.bBorrar.TabIndex = 53;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click_1);
            // 
            // lJefe
            // 
            this.lJefe.AutoSize = true;
            this.lJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJefe.Location = new System.Drawing.Point(327, 132);
            this.lJefe.Name = "lJefe";
            this.lJefe.Size = new System.Drawing.Size(156, 20);
            this.lJefe.TabIndex = 52;
            this.lJefe.Text = "Busqueda por jefe";
            this.lJefe.Visible = false;
            // 
            // lEstacion
            // 
            this.lEstacion.AutoSize = true;
            this.lEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstacion.Location = new System.Drawing.Point(327, 132);
            this.lEstacion.Name = "lEstacion";
            this.lEstacion.Size = new System.Drawing.Size(194, 20);
            this.lEstacion.TabIndex = 51;
            this.lEstacion.Text = "Busqueda por estación";
            this.lEstacion.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(331, 171);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 50;
            this.tbBusqueda.Visible = false;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(342, 217);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 49;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click_1);
            // 
            // bContar
            // 
            this.bContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContar.Location = new System.Drawing.Point(363, 12);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 48;
            this.bContar.Text = "Contar incidencias";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click_1);
            // 
            // bBuscarJefe
            // 
            this.bBuscarJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarJefe.Location = new System.Drawing.Point(239, 12);
            this.bBuscarJefe.Name = "bBuscarJefe";
            this.bBuscarJefe.Size = new System.Drawing.Size(107, 53);
            this.bBuscarJefe.TabIndex = 47;
            this.bBuscarJefe.Text = "Buscar por jefe";
            this.bBuscarJefe.UseVisualStyleBackColor = true;
            this.bBuscarJefe.Click += new System.EventHandler(this.bBuscarJefe_Click);
            // 
            // bBuscarEstacion
            // 
            this.bBuscarEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarEstacion.Location = new System.Drawing.Point(115, 12);
            this.bBuscarEstacion.Name = "bBuscarEstacion";
            this.bBuscarEstacion.Size = new System.Drawing.Size(107, 53);
            this.bBuscarEstacion.TabIndex = 46;
            this.bBuscarEstacion.Text = "Buscar por estacion";
            this.bBuscarEstacion.UseVisualStyleBackColor = true;
            this.bBuscarEstacion.Click += new System.EventHandler(this.bBuscarEstacion_Click);
            // 
            // incidenciasTableAdapter
            // 
            this.incidenciasTableAdapter.ClearBeforeFill = true;
            // 
            // incidenciasTableAdapter1
            // 
            this.incidenciasTableAdapter1.ClearBeforeFill = true;
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
            // bBorrar2
            // 
            this.bBorrar2.Location = new System.Drawing.Point(342, 217);
            this.bBorrar2.Name = "bBorrar2";
            this.bBorrar2.Size = new System.Drawing.Size(75, 23);
            this.bBorrar2.TabIndex = 57;
            this.bBorrar2.Text = "Borrar";
            this.bBorrar2.UseVisualStyleBackColor = true;
            this.bBorrar2.Visible = false;
            this.bBorrar2.Click += new System.EventHandler(this.bBorrar2_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(324, 26);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 58;
            this.idTextBox.Visible = false;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.incidenciasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(324, 52);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 60;
            this.fechaDateTimePicker.Visible = false;
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "Hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(324, 78);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaTextBox.TabIndex = 62;
            this.horaTextBox.Visible = false;
            // 
            // nombreEstacionTextBox
            // 
            this.nombreEstacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "NombreEstacion", true));
            this.nombreEstacionTextBox.Location = new System.Drawing.Point(324, 104);
            this.nombreEstacionTextBox.Name = "nombreEstacionTextBox";
            this.nombreEstacionTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreEstacionTextBox.TabIndex = 64;
            this.nombreEstacionTextBox.Visible = false;
            // 
            // caracteristicasTextBox
            // 
            this.caracteristicasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "Caracteristicas", true));
            this.caracteristicasTextBox.Location = new System.Drawing.Point(324, 130);
            this.caracteristicasTextBox.Name = "caracteristicasTextBox";
            this.caracteristicasTextBox.Size = new System.Drawing.Size(200, 20);
            this.caracteristicasTextBox.TabIndex = 66;
            this.caracteristicasTextBox.Visible = false;
            // 
            // valoracionTextBox
            // 
            this.valoracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "Valoracion", true));
            this.valoracionTextBox.Location = new System.Drawing.Point(324, 156);
            this.valoracionTextBox.Name = "valoracionTextBox";
            this.valoracionTextBox.Size = new System.Drawing.Size(200, 20);
            this.valoracionTextBox.TabIndex = 68;
            this.valoracionTextBox.Visible = false;
            // 
            // dniJefeTextBox
            // 
            this.dniJefeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciasBindingSource, "DniJefe", true));
            this.dniJefeTextBox.Location = new System.Drawing.Point(324, 182);
            this.dniJefeTextBox.Name = "dniJefeTextBox";
            this.dniJefeTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniJefeTextBox.TabIndex = 70;
            this.dniJefeTextBox.Visible = false;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(228, 33);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(19, 13);
            this.LabelId.TabIndex = 71;
            this.LabelId.Text = "Id:";
            this.LabelId.Visible = false;
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(228, 53);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(40, 13);
            this.LabelFecha.TabIndex = 72;
            this.LabelFecha.Text = "Fecha:";
            this.LabelFecha.Visible = false;
            // 
            // LabelHora
            // 
            this.LabelHora.AutoSize = true;
            this.LabelHora.Location = new System.Drawing.Point(491, 106);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(33, 13);
            this.LabelHora.TabIndex = 73;
            this.LabelHora.Text = "Hora:";
            this.LabelHora.Visible = false;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(228, 104);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(91, 13);
            this.LabelNombre.TabIndex = 74;
            this.LabelNombre.Text = "Nombre Estación:";
            this.LabelNombre.Visible = false;
            // 
            // LabelCarac
            // 
            this.LabelCarac.AutoSize = true;
            this.LabelCarac.Location = new System.Drawing.Point(228, 130);
            this.LabelCarac.Name = "LabelCarac";
            this.LabelCarac.Size = new System.Drawing.Size(81, 13);
            this.LabelCarac.TabIndex = 75;
            this.LabelCarac.Text = "Características:";
            this.LabelCarac.Visible = false;
            // 
            // LabelValoracion
            // 
            this.LabelValoracion.AutoSize = true;
            this.LabelValoracion.Location = new System.Drawing.Point(228, 156);
            this.LabelValoracion.Name = "LabelValoracion";
            this.LabelValoracion.Size = new System.Drawing.Size(60, 13);
            this.LabelValoracion.TabIndex = 76;
            this.LabelValoracion.Text = "Valoración:";
            this.LabelValoracion.Visible = false;
            // 
            // LabelDni
            // 
            this.LabelDni.AutoSize = true;
            this.LabelDni.Location = new System.Drawing.Point(228, 182);
            this.LabelDni.Name = "LabelDni";
            this.LabelDni.Size = new System.Drawing.Size(49, 13);
            this.LabelDni.TabIndex = 77;
            this.LabelDni.Text = "Dni Jefe:";
            this.LabelDni.Visible = false;
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(342, 217);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 78;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.bAgregar2_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(423, 217);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 79;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 533);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAgregar2);
            this.Controls.Add(this.LabelDni);
            this.Controls.Add(this.LabelValoracion);
            this.Controls.Add(this.LabelCarac);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelHora);
            this.Controls.Add(this.LabelFecha);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(this.nombreEstacionTextBox);
            this.Controls.Add(this.caracteristicasTextBox);
            this.Controls.Add(this.valoracionTextBox);
            this.Controls.Add(this.dniJefeTextBox);
            this.Controls.Add(this.bBorrar2);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.lJefe);
            this.Controls.Add(this.lEstacion);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.bBuscarJefe);
            this.Controls.Add(this.bBuscarEstacion);
            this.Controls.Add(this.incidenciasDataGridView);
            this.Name = "Incidencias";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.Incidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource incidenciasBindingSource;
        private RelacionesTableAdapters.IncidenciasTableAdapter incidenciasTableAdapter;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView incidenciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private RelacionesTableAdapters.IncidenciasTableAdapter incidenciasTableAdapter1;
        private System.Windows.Forms.Label lBorrar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Label lJefe;
        private System.Windows.Forms.Label lEstacion;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarJefe;
        private System.Windows.Forms.Button bBuscarEstacion;
        private System.Windows.Forms.Button bBorrar2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox nombreEstacionTextBox;
        private System.Windows.Forms.TextBox caracteristicasTextBox;
        private System.Windows.Forms.TextBox valoracionTextBox;
        private System.Windows.Forms.TextBox dniJefeTextBox;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.Label LabelHora;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelCarac;
        private System.Windows.Forms.Label LabelValoracion;
        private System.Windows.Forms.Label LabelDni;
        private System.Windows.Forms.Button bAgregar2;
        private System.Windows.Forms.Button bCancelar;
    }
}