namespace GestionMetroc
{
    partial class Hangar
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
            this.hangarDataGridView = new System.Windows.Forms.DataGridView();
            this.lBorrar = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.lMatricula = new System.Windows.Forms.Label();
            this.lConductor = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarMatricula = new System.Windows.Forms.Button();
            this.bBuscarConductor = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBorrar2 = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dniConductorLabel = new System.Windows.Forms.Label();
            this.dniConductorTextBox = new System.Windows.Forms.TextBox();
            this.plazaLabel = new System.Windows.Forms.Label();
            this.plazaTextBox = new System.Windows.Forms.TextBox();
            this.fechaEntradaLabel = new System.Windows.Forms.Label();
            this.fechaEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaEntradaLabel = new System.Windows.Forms.Label();
            this.horaEntradaTextBox = new System.Windows.Forms.TextBox();
            this.fechaSalidaLabel = new System.Windows.Forms.Label();
            this.fechaSalidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaSalidaLabel = new System.Windows.Forms.Label();
            this.horaSalidaTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTrenLabel = new System.Windows.Forms.Label();
            this.matriculaTrenTextBox = new System.Windows.Forms.TextBox();
            this.bAgregar2 = new System.Windows.Forms.Button();
            this.hangarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaciones = new GestionMetroc.Relaciones();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangarTableAdapter = new GestionMetroc.RelacionesTableAdapters.HangarTableAdapter();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            this.hangarTableAdapter1 = new GestionMetroc.RelacionesTableAdapters.HangarTableAdapter();
            this.bModificar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hangarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // hangarDataGridView
            // 
            this.hangarDataGridView.AutoGenerateColumns = false;
            this.hangarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hangarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.hangarDataGridView.DataSource = this.hangarBindingSource;
            this.hangarDataGridView.Location = new System.Drawing.Point(42, 290);
            this.hangarDataGridView.Name = "hangarDataGridView";
            this.hangarDataGridView.Size = new System.Drawing.Size(843, 310);
            this.hangarDataGridView.TabIndex = 1;
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(407, 168);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 78;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(720, 28);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(107, 53);
            this.bModificar.TabIndex = 77;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(596, 28);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(107, 53);
            this.bAgregar.TabIndex = 76;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(472, 28);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(107, 53);
            this.bBorrar.TabIndex = 75;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click_1);
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatricula.Location = new System.Drawing.Point(369, 168);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(199, 20);
            this.lMatricula.TabIndex = 74;
            this.lMatricula.Text = "Busqueda por matricula";
            this.lMatricula.Visible = false;
            // 
            // lConductor
            // 
            this.lConductor.AutoSize = true;
            this.lConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConductor.Location = new System.Drawing.Point(369, 168);
            this.lConductor.Name = "lConductor";
            this.lConductor.Size = new System.Drawing.Size(206, 20);
            this.lConductor.TabIndex = 73;
            this.lConductor.Text = "Busqueda por conductor";
            this.lConductor.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(373, 204);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 72;
            this.tbBusqueda.Visible = false;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(379, 246);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 71;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click_1);
            // 
            // bContar
            // 
            this.bContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContar.Location = new System.Drawing.Point(347, 28);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 70;
            this.bContar.Text = "Contar hangar";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click_1);
            // 
            // bBuscarMatricula
            // 
            this.bBuscarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarMatricula.Location = new System.Drawing.Point(223, 28);
            this.bBuscarMatricula.Name = "bBuscarMatricula";
            this.bBuscarMatricula.Size = new System.Drawing.Size(107, 53);
            this.bBuscarMatricula.TabIndex = 69;
            this.bBuscarMatricula.Text = "Buscar por matricula";
            this.bBuscarMatricula.UseVisualStyleBackColor = true;
            this.bBuscarMatricula.Click += new System.EventHandler(this.bBuscarLinea_Click);
            // 
            // bBuscarConductor
            // 
            this.bBuscarConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarConductor.Location = new System.Drawing.Point(99, 28);
            this.bBuscarConductor.Name = "bBuscarConductor";
            this.bBuscarConductor.Size = new System.Drawing.Size(107, 53);
            this.bBuscarConductor.TabIndex = 68;
            this.bBuscarConductor.Text = "Buscar por conductor";
            this.bBuscarConductor.UseVisualStyleBackColor = true;
            this.bBuscarConductor.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(472, 246);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 79;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bBorrar2
            // 
            this.bBorrar2.Location = new System.Drawing.Point(379, 246);
            this.bBorrar2.Name = "bBorrar2";
            this.bBorrar2.Size = new System.Drawing.Size(75, 23);
            this.bBorrar2.TabIndex = 80;
            this.bBorrar2.Text = "Borrar";
            this.bBorrar2.UseVisualStyleBackColor = true;
            this.bBorrar2.Visible = false;
            this.bBorrar2.Click += new System.EventHandler(this.bBorrar2_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(282, 31);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 80;
            this.idLabel.Text = "Id:";
            this.idLabel.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangarBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(368, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 81;
            this.idTextBox.Visible = false;
            // 
            // dniConductorLabel
            // 
            this.dniConductorLabel.AutoSize = true;
            this.dniConductorLabel.Location = new System.Drawing.Point(282, 57);
            this.dniConductorLabel.Name = "dniConductorLabel";
            this.dniConductorLabel.Size = new System.Drawing.Size(78, 13);
            this.dniConductorLabel.TabIndex = 82;
            this.dniConductorLabel.Text = "Dni Conductor:";
            this.dniConductorLabel.Visible = false;
            // 
            // dniConductorTextBox
            // 
            this.dniConductorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangarBindingSource, "DniConductor", true));
            this.dniConductorTextBox.Location = new System.Drawing.Point(368, 54);
            this.dniConductorTextBox.Name = "dniConductorTextBox";
            this.dniConductorTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniConductorTextBox.TabIndex = 83;
            this.dniConductorTextBox.Visible = false;
            // 
            // plazaLabel
            // 
            this.plazaLabel.AutoSize = true;
            this.plazaLabel.Location = new System.Drawing.Point(282, 83);
            this.plazaLabel.Name = "plazaLabel";
            this.plazaLabel.Size = new System.Drawing.Size(36, 13);
            this.plazaLabel.TabIndex = 84;
            this.plazaLabel.Text = "Plaza:";
            this.plazaLabel.Visible = false;
            // 
            // plazaTextBox
            // 
            this.plazaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangarBindingSource, "Plaza", true));
            this.plazaTextBox.Location = new System.Drawing.Point(368, 80);
            this.plazaTextBox.Name = "plazaTextBox";
            this.plazaTextBox.Size = new System.Drawing.Size(200, 20);
            this.plazaTextBox.TabIndex = 85;
            this.plazaTextBox.Visible = false;
            // 
            // fechaEntradaLabel
            // 
            this.fechaEntradaLabel.AutoSize = true;
            this.fechaEntradaLabel.Location = new System.Drawing.Point(282, 110);
            this.fechaEntradaLabel.Name = "fechaEntradaLabel";
            this.fechaEntradaLabel.Size = new System.Drawing.Size(80, 13);
            this.fechaEntradaLabel.TabIndex = 86;
            this.fechaEntradaLabel.Text = "Fecha Entrada:";
            this.fechaEntradaLabel.Visible = false;
            // 
            // fechaEntradaDateTimePicker
            // 
            this.fechaEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hangarBindingSource, "FechaEntrada", true));
            this.fechaEntradaDateTimePicker.Location = new System.Drawing.Point(368, 106);
            this.fechaEntradaDateTimePicker.Name = "fechaEntradaDateTimePicker";
            this.fechaEntradaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntradaDateTimePicker.TabIndex = 87;
            this.fechaEntradaDateTimePicker.Visible = false;
            // 
            // horaEntradaLabel
            // 
            this.horaEntradaLabel.AutoSize = true;
            this.horaEntradaLabel.Location = new System.Drawing.Point(282, 135);
            this.horaEntradaLabel.Name = "horaEntradaLabel";
            this.horaEntradaLabel.Size = new System.Drawing.Size(73, 13);
            this.horaEntradaLabel.TabIndex = 88;
            this.horaEntradaLabel.Text = "Hora Entrada:";
            this.horaEntradaLabel.Visible = false;
            // 
            // horaEntradaTextBox
            // 
            this.horaEntradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangarBindingSource, "HoraEntrada", true));
            this.horaEntradaTextBox.Location = new System.Drawing.Point(368, 132);
            this.horaEntradaTextBox.Name = "horaEntradaTextBox";
            this.horaEntradaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaEntradaTextBox.TabIndex = 89;
            this.horaEntradaTextBox.Visible = false;
            // 
            // fechaSalidaLabel
            // 
            this.fechaSalidaLabel.AutoSize = true;
            this.fechaSalidaLabel.Location = new System.Drawing.Point(282, 162);
            this.fechaSalidaLabel.Name = "fechaSalidaLabel";
            this.fechaSalidaLabel.Size = new System.Drawing.Size(72, 13);
            this.fechaSalidaLabel.TabIndex = 90;
            this.fechaSalidaLabel.Text = "Fecha Salida:";
            this.fechaSalidaLabel.Visible = false;
            // 
            // fechaSalidaDateTimePicker
            // 
            this.fechaSalidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hangarBindingSource, "FechaSalida", true));
            this.fechaSalidaDateTimePicker.Location = new System.Drawing.Point(368, 158);
            this.fechaSalidaDateTimePicker.Name = "fechaSalidaDateTimePicker";
            this.fechaSalidaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaSalidaDateTimePicker.TabIndex = 91;
            this.fechaSalidaDateTimePicker.Visible = false;
            // 
            // horaSalidaLabel
            // 
            this.horaSalidaLabel.AutoSize = true;
            this.horaSalidaLabel.Location = new System.Drawing.Point(282, 187);
            this.horaSalidaLabel.Name = "horaSalidaLabel";
            this.horaSalidaLabel.Size = new System.Drawing.Size(65, 13);
            this.horaSalidaLabel.TabIndex = 92;
            this.horaSalidaLabel.Text = "Hora Salida:";
            this.horaSalidaLabel.Visible = false;
            // 
            // horaSalidaTextBox
            // 
            this.horaSalidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangarBindingSource, "HoraSalida", true));
            this.horaSalidaTextBox.Location = new System.Drawing.Point(368, 184);
            this.horaSalidaTextBox.Name = "horaSalidaTextBox";
            this.horaSalidaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaSalidaTextBox.TabIndex = 93;
            this.horaSalidaTextBox.Visible = false;
            // 
            // matriculaTrenLabel
            // 
            this.matriculaTrenLabel.AutoSize = true;
            this.matriculaTrenLabel.Location = new System.Drawing.Point(282, 213);
            this.matriculaTrenLabel.Name = "matriculaTrenLabel";
            this.matriculaTrenLabel.Size = new System.Drawing.Size(78, 13);
            this.matriculaTrenLabel.TabIndex = 94;
            this.matriculaTrenLabel.Text = "Matricula Tren:";
            this.matriculaTrenLabel.Visible = false;
            // 
            // matriculaTrenTextBox
            // 
            this.matriculaTrenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangarBindingSource, "MatriculaTren", true));
            this.matriculaTrenTextBox.Location = new System.Drawing.Point(368, 210);
            this.matriculaTrenTextBox.Name = "matriculaTrenTextBox";
            this.matriculaTrenTextBox.Size = new System.Drawing.Size(200, 20);
            this.matriculaTrenTextBox.TabIndex = 95;
            this.matriculaTrenTextBox.Visible = false;
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(379, 246);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 96;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.bAgregar2_Click);
            // 
            // hangarBindingSource
            // 
            this.hangarBindingSource.DataMember = "Hangar";
            this.hangarBindingSource.DataSource = this.relaciones;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DniConductor";
            this.dataGridViewTextBoxColumn2.HeaderText = "DniConductor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Plaza";
            this.dataGridViewTextBoxColumn3.HeaderText = "Plaza";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaEntrada";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaEntrada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HoraEntrada";
            this.dataGridViewTextBoxColumn5.HeaderText = "HoraEntrada";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaSalida";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaSalida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HoraSalida";
            this.dataGridViewTextBoxColumn7.HeaderText = "HoraSalida";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MatriculaTren";
            this.dataGridViewTextBoxColumn8.HeaderText = "MatriculaTren";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // hangarTableAdapter
            // 
            this.hangarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConductoresTableAdapter = null;
            this.tableAdapterManager.CuidadosTableAdapter = null;
            this.tableAdapterManager.EstacionTableAdapter = null;
            this.tableAdapterManager.HangarTableAdapter = this.hangarTableAdapter;
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
            // hangarTableAdapter1
            // 
            this.hangarTableAdapter1.ClearBeforeFill = true;
            // 
            // bModificar2
            // 
            this.bModificar2.Location = new System.Drawing.Point(379, 246);
            this.bModificar2.Name = "bModificar2";
            this.bModificar2.Size = new System.Drawing.Size(75, 23);
            this.bModificar2.TabIndex = 97;
            this.bModificar2.Text = "Modificar";
            this.bModificar2.UseVisualStyleBackColor = true;
            this.bModificar2.Visible = false;
            this.bModificar2.Click += new System.EventHandler(this.bModificar2_Click);
            // 
            // Hangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 622);
            this.Controls.Add(this.bModificar2);
            this.Controls.Add(this.bAgregar2);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.dniConductorLabel);
            this.Controls.Add(this.dniConductorTextBox);
            this.Controls.Add(this.plazaLabel);
            this.Controls.Add(this.plazaTextBox);
            this.Controls.Add(this.fechaEntradaLabel);
            this.Controls.Add(this.fechaEntradaDateTimePicker);
            this.Controls.Add(this.horaEntradaLabel);
            this.Controls.Add(this.horaEntradaTextBox);
            this.Controls.Add(this.fechaSalidaLabel);
            this.Controls.Add(this.fechaSalidaDateTimePicker);
            this.Controls.Add(this.horaSalidaLabel);
            this.Controls.Add(this.horaSalidaTextBox);
            this.Controls.Add(this.matriculaTrenLabel);
            this.Controls.Add(this.matriculaTrenTextBox);
            this.Controls.Add(this.bBorrar2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.lMatricula);
            this.Controls.Add(this.lConductor);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.bBuscarMatricula);
            this.Controls.Add(this.bBuscarConductor);
            this.Controls.Add(this.hangarDataGridView);
            this.Name = "Hangar";
            this.Text = "Hangar";
            this.Load += new System.EventHandler(this.Hangar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource hangarBindingSource;
        private RelacionesTableAdapters.HangarTableAdapter hangarTableAdapter;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView hangarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private RelacionesTableAdapters.HangarTableAdapter hangarTableAdapter1;
        private System.Windows.Forms.Label lBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.Label lConductor;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarMatricula;
        private System.Windows.Forms.Button bBuscarConductor;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBorrar2;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label dniConductorLabel;
        private System.Windows.Forms.TextBox dniConductorTextBox;
        private System.Windows.Forms.Label plazaLabel;
        private System.Windows.Forms.TextBox plazaTextBox;
        private System.Windows.Forms.Label fechaEntradaLabel;
        private System.Windows.Forms.DateTimePicker fechaEntradaDateTimePicker;
        private System.Windows.Forms.Label horaEntradaLabel;
        private System.Windows.Forms.TextBox horaEntradaTextBox;
        private System.Windows.Forms.Label fechaSalidaLabel;
        private System.Windows.Forms.DateTimePicker fechaSalidaDateTimePicker;
        private System.Windows.Forms.Label horaSalidaLabel;
        private System.Windows.Forms.TextBox horaSalidaTextBox;
        private System.Windows.Forms.Label matriculaTrenLabel;
        private System.Windows.Forms.TextBox matriculaTrenTextBox;
        private System.Windows.Forms.Button bAgregar2;
        private System.Windows.Forms.Button bModificar2;
    }
}