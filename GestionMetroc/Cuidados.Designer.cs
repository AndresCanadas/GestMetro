namespace GestionMetroc
{
    partial class Cuidados
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
            this.cuidadosDataGridView = new System.Windows.Forms.DataGridView();
            this.lBorrar = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.lTecnico = new System.Windows.Forms.Label();
            this.lMatricula = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarTecnico = new System.Windows.Forms.Button();
            this.bBuscarMatricula = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
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
            this.tipoAtencionLabel = new System.Windows.Forms.Label();
            this.tipoAtencionTextBox = new System.Windows.Forms.TextBox();
            this.dniTecnicoLabel = new System.Windows.Forms.Label();
            this.dniTecnicoTextBox = new System.Windows.Forms.TextBox();
            this.caracteristicasLabel = new System.Windows.Forms.Label();
            this.caracteristicasTextBox = new System.Windows.Forms.TextBox();
            this.valoracionLabel = new System.Windows.Forms.Label();
            this.valoracionTextBox = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAgregar2 = new System.Windows.Forms.Button();
            this.cuidadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaciones = new GestionMetroc.Relaciones();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuidadosTableAdapter = new GestionMetroc.RelacionesTableAdapters.CuidadosTableAdapter();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            this.cuidadosTableAdapter1 = new GestionMetroc.RelacionesTableAdapters.CuidadosTableAdapter();
            this.bModificar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cuidadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuidadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cuidadosDataGridView
            // 
            this.cuidadosDataGridView.AutoGenerateColumns = false;
            this.cuidadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuidadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.cuidadosDataGridView.DataSource = this.cuidadosBindingSource;
            this.cuidadosDataGridView.Location = new System.Drawing.Point(25, 384);
            this.cuidadosDataGridView.Name = "cuidadosDataGridView";
            this.cuidadosDataGridView.Size = new System.Drawing.Size(1051, 278);
            this.cuidadosDataGridView.TabIndex = 1;
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(507, 240);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 45;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(827, 25);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(107, 53);
            this.bModificar.TabIndex = 44;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(703, 25);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(107, 53);
            this.bAgregar.TabIndex = 43;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(579, 25);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(107, 53);
            this.bBorrar.TabIndex = 42;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click_1);
            // 
            // lTecnico
            // 
            this.lTecnico.AutoSize = true;
            this.lTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTecnico.Location = new System.Drawing.Point(472, 240);
            this.lTecnico.Name = "lTecnico";
            this.lTecnico.Size = new System.Drawing.Size(184, 20);
            this.lTecnico.TabIndex = 41;
            this.lTecnico.Text = "Busqueda por técnico";
            this.lTecnico.Visible = false;
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatricula.Location = new System.Drawing.Point(472, 240);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(199, 20);
            this.lMatricula.TabIndex = 40;
            this.lMatricula.Text = "Busqueda por matrícula";
            this.lMatricula.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(476, 275);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 39;
            this.tbBusqueda.Visible = false;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(482, 320);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 38;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click_1);
            // 
            // bContar
            // 
            this.bContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContar.Location = new System.Drawing.Point(450, 25);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 37;
            this.bContar.Text = "Contar cuidados";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click_1);
            // 
            // bBuscarTecnico
            // 
            this.bBuscarTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarTecnico.Location = new System.Drawing.Point(326, 25);
            this.bBuscarTecnico.Name = "bBuscarTecnico";
            this.bBuscarTecnico.Size = new System.Drawing.Size(107, 53);
            this.bBuscarTecnico.TabIndex = 36;
            this.bBuscarTecnico.Text = "Buscar por técnico";
            this.bBuscarTecnico.UseVisualStyleBackColor = true;
            this.bBuscarTecnico.Click += new System.EventHandler(this.bBuscarTecnico_Click);
            // 
            // bBuscarMatricula
            // 
            this.bBuscarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarMatricula.Location = new System.Drawing.Point(202, 25);
            this.bBuscarMatricula.Name = "bBuscarMatricula";
            this.bBuscarMatricula.Size = new System.Drawing.Size(107, 53);
            this.bBuscarMatricula.TabIndex = 35;
            this.bBuscarMatricula.Text = "Buscar por matricula";
            this.bBuscarMatricula.UseVisualStyleBackColor = true;
            this.bBuscarMatricula.Click += new System.EventHandler(this.bBuscarMatricula_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(385, 61);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 45;
            this.idLabel.Text = "Id:";
            this.idLabel.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuidadosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(471, 58);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 46;
            this.idTextBox.Visible = false;
            // 
            // fechaEntradaLabel
            // 
            this.fechaEntradaLabel.AutoSize = true;
            this.fechaEntradaLabel.Location = new System.Drawing.Point(385, 88);
            this.fechaEntradaLabel.Name = "fechaEntradaLabel";
            this.fechaEntradaLabel.Size = new System.Drawing.Size(80, 13);
            this.fechaEntradaLabel.TabIndex = 47;
            this.fechaEntradaLabel.Text = "Fecha Entrada:";
            this.fechaEntradaLabel.Visible = false;
            // 
            // fechaEntradaDateTimePicker
            // 
            this.fechaEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cuidadosBindingSource, "FechaEntrada", true));
            this.fechaEntradaDateTimePicker.Location = new System.Drawing.Point(471, 84);
            this.fechaEntradaDateTimePicker.Name = "fechaEntradaDateTimePicker";
            this.fechaEntradaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntradaDateTimePicker.TabIndex = 48;
            this.fechaEntradaDateTimePicker.Visible = false;
            // 
            // horaEntradaLabel
            // 
            this.horaEntradaLabel.AutoSize = true;
            this.horaEntradaLabel.Location = new System.Drawing.Point(385, 113);
            this.horaEntradaLabel.Name = "horaEntradaLabel";
            this.horaEntradaLabel.Size = new System.Drawing.Size(73, 13);
            this.horaEntradaLabel.TabIndex = 49;
            this.horaEntradaLabel.Text = "Hora Entrada:";
            this.horaEntradaLabel.Visible = false;
            // 
            // horaEntradaTextBox
            // 
            this.horaEntradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuidadosBindingSource, "HoraEntrada", true));
            this.horaEntradaTextBox.Location = new System.Drawing.Point(471, 110);
            this.horaEntradaTextBox.Name = "horaEntradaTextBox";
            this.horaEntradaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaEntradaTextBox.TabIndex = 50;
            this.horaEntradaTextBox.Visible = false;
            // 
            // fechaSalidaLabel
            // 
            this.fechaSalidaLabel.AutoSize = true;
            this.fechaSalidaLabel.Location = new System.Drawing.Point(385, 140);
            this.fechaSalidaLabel.Name = "fechaSalidaLabel";
            this.fechaSalidaLabel.Size = new System.Drawing.Size(72, 13);
            this.fechaSalidaLabel.TabIndex = 51;
            this.fechaSalidaLabel.Text = "Fecha Salida:";
            this.fechaSalidaLabel.Visible = false;
            // 
            // fechaSalidaDateTimePicker
            // 
            this.fechaSalidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cuidadosBindingSource, "FechaSalida", true));
            this.fechaSalidaDateTimePicker.Location = new System.Drawing.Point(471, 136);
            this.fechaSalidaDateTimePicker.Name = "fechaSalidaDateTimePicker";
            this.fechaSalidaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaSalidaDateTimePicker.TabIndex = 52;
            this.fechaSalidaDateTimePicker.Visible = false;
            // 
            // horaSalidaLabel
            // 
            this.horaSalidaLabel.AutoSize = true;
            this.horaSalidaLabel.Location = new System.Drawing.Point(385, 165);
            this.horaSalidaLabel.Name = "horaSalidaLabel";
            this.horaSalidaLabel.Size = new System.Drawing.Size(65, 13);
            this.horaSalidaLabel.TabIndex = 53;
            this.horaSalidaLabel.Text = "Hora Salida:";
            this.horaSalidaLabel.Visible = false;
            // 
            // horaSalidaTextBox
            // 
            this.horaSalidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuidadosBindingSource, "HoraSalida", true));
            this.horaSalidaTextBox.Location = new System.Drawing.Point(471, 162);
            this.horaSalidaTextBox.Name = "horaSalidaTextBox";
            this.horaSalidaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaSalidaTextBox.TabIndex = 54;
            this.horaSalidaTextBox.Visible = false;
            // 
            // matriculaTrenLabel
            // 
            this.matriculaTrenLabel.AutoSize = true;
            this.matriculaTrenLabel.Location = new System.Drawing.Point(385, 191);
            this.matriculaTrenLabel.Name = "matriculaTrenLabel";
            this.matriculaTrenLabel.Size = new System.Drawing.Size(78, 13);
            this.matriculaTrenLabel.TabIndex = 55;
            this.matriculaTrenLabel.Text = "Matricula Tren:";
            this.matriculaTrenLabel.Visible = false;
            // 
            // matriculaTrenTextBox
            // 
            this.matriculaTrenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuidadosBindingSource, "MatriculaTren", true));
            this.matriculaTrenTextBox.Location = new System.Drawing.Point(471, 188);
            this.matriculaTrenTextBox.Name = "matriculaTrenTextBox";
            this.matriculaTrenTextBox.Size = new System.Drawing.Size(200, 20);
            this.matriculaTrenTextBox.TabIndex = 56;
            this.matriculaTrenTextBox.Visible = false;
            // 
            // tipoAtencionLabel
            // 
            this.tipoAtencionLabel.AutoSize = true;
            this.tipoAtencionLabel.Location = new System.Drawing.Point(385, 217);
            this.tipoAtencionLabel.Name = "tipoAtencionLabel";
            this.tipoAtencionLabel.Size = new System.Drawing.Size(76, 13);
            this.tipoAtencionLabel.TabIndex = 57;
            this.tipoAtencionLabel.Text = "Tipo Atencion:";
            this.tipoAtencionLabel.Visible = false;
            // 
            // tipoAtencionTextBox
            // 
            this.tipoAtencionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuidadosBindingSource, "TipoAtencion", true));
            this.tipoAtencionTextBox.Location = new System.Drawing.Point(471, 214);
            this.tipoAtencionTextBox.Name = "tipoAtencionTextBox";
            this.tipoAtencionTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipoAtencionTextBox.TabIndex = 58;
            this.tipoAtencionTextBox.Visible = false;
            // 
            // dniTecnicoLabel
            // 
            this.dniTecnicoLabel.AutoSize = true;
            this.dniTecnicoLabel.Location = new System.Drawing.Point(385, 243);
            this.dniTecnicoLabel.Name = "dniTecnicoLabel";
            this.dniTecnicoLabel.Size = new System.Drawing.Size(68, 13);
            this.dniTecnicoLabel.TabIndex = 59;
            this.dniTecnicoLabel.Text = "Dni Tecnico:";
            this.dniTecnicoLabel.Visible = false;
            // 
            // dniTecnicoTextBox
            // 
            this.dniTecnicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuidadosBindingSource, "DniTecnico", true));
            this.dniTecnicoTextBox.Location = new System.Drawing.Point(471, 240);
            this.dniTecnicoTextBox.Name = "dniTecnicoTextBox";
            this.dniTecnicoTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniTecnicoTextBox.TabIndex = 60;
            this.dniTecnicoTextBox.Visible = false;
            // 
            // caracteristicasLabel
            // 
            this.caracteristicasLabel.AutoSize = true;
            this.caracteristicasLabel.Location = new System.Drawing.Point(385, 269);
            this.caracteristicasLabel.Name = "caracteristicasLabel";
            this.caracteristicasLabel.Size = new System.Drawing.Size(79, 13);
            this.caracteristicasLabel.TabIndex = 61;
            this.caracteristicasLabel.Text = "Caracteristicas:";
            this.caracteristicasLabel.Visible = false;
            // 
            // caracteristicasTextBox
            // 
            this.caracteristicasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuidadosBindingSource, "Caracteristicas", true));
            this.caracteristicasTextBox.Location = new System.Drawing.Point(471, 266);
            this.caracteristicasTextBox.Name = "caracteristicasTextBox";
            this.caracteristicasTextBox.Size = new System.Drawing.Size(200, 20);
            this.caracteristicasTextBox.TabIndex = 62;
            this.caracteristicasTextBox.Visible = false;
            // 
            // valoracionLabel
            // 
            this.valoracionLabel.AutoSize = true;
            this.valoracionLabel.Location = new System.Drawing.Point(385, 295);
            this.valoracionLabel.Name = "valoracionLabel";
            this.valoracionLabel.Size = new System.Drawing.Size(60, 13);
            this.valoracionLabel.TabIndex = 63;
            this.valoracionLabel.Text = "Valoracion:";
            this.valoracionLabel.Visible = false;
            // 
            // valoracionTextBox
            // 
            this.valoracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuidadosBindingSource, "Valoracion", true));
            this.valoracionTextBox.Location = new System.Drawing.Point(471, 292);
            this.valoracionTextBox.Name = "valoracionTextBox";
            this.valoracionTextBox.Size = new System.Drawing.Size(200, 20);
            this.valoracionTextBox.TabIndex = 64;
            this.valoracionTextBox.Visible = false;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(577, 320);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 65;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(482, 320);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 66;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.bAgregar2_Click);
            // 
            // cuidadosBindingSource
            // 
            this.cuidadosBindingSource.DataMember = "Cuidados";
            this.cuidadosBindingSource.DataSource = this.relaciones;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FechaEntrada";
            this.dataGridViewTextBoxColumn2.HeaderText = "FechaEntrada";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoraEntrada";
            this.dataGridViewTextBoxColumn3.HeaderText = "HoraEntrada";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaSalida";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaSalida";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HoraSalida";
            this.dataGridViewTextBoxColumn5.HeaderText = "HoraSalida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MatriculaTren";
            this.dataGridViewTextBoxColumn6.HeaderText = "MatriculaTren";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TipoAtencion";
            this.dataGridViewTextBoxColumn7.HeaderText = "TipoAtencion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DniTecnico";
            this.dataGridViewTextBoxColumn8.HeaderText = "DniTecnico";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Caracteristicas";
            this.dataGridViewTextBoxColumn9.HeaderText = "Caracteristicas";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Valoracion";
            this.dataGridViewTextBoxColumn10.HeaderText = "Valoracion";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // cuidadosTableAdapter
            // 
            this.cuidadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConductoresTableAdapter = null;
            this.tableAdapterManager.CuidadosTableAdapter = this.cuidadosTableAdapter;
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
            // cuidadosTableAdapter1
            // 
            this.cuidadosTableAdapter1.ClearBeforeFill = true;
            // 
            // bModificar2
            // 
            this.bModificar2.Location = new System.Drawing.Point(482, 320);
            this.bModificar2.Name = "bModificar2";
            this.bModificar2.Size = new System.Drawing.Size(75, 23);
            this.bModificar2.TabIndex = 67;
            this.bModificar2.Text = "Modificar";
            this.bModificar2.UseVisualStyleBackColor = true;
            this.bModificar2.Visible = false;
            this.bModificar2.Click += new System.EventHandler(this.bModificar2_Click);
            // 
            // Cuidados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 687);
            this.Controls.Add(this.bModificar2);
            this.Controls.Add(this.bAgregar2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
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
            this.Controls.Add(this.tipoAtencionLabel);
            this.Controls.Add(this.tipoAtencionTextBox);
            this.Controls.Add(this.dniTecnicoLabel);
            this.Controls.Add(this.dniTecnicoTextBox);
            this.Controls.Add(this.caracteristicasLabel);
            this.Controls.Add(this.caracteristicasTextBox);
            this.Controls.Add(this.valoracionLabel);
            this.Controls.Add(this.valoracionTextBox);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.lTecnico);
            this.Controls.Add(this.lMatricula);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.bBuscarTecnico);
            this.Controls.Add(this.bBuscarMatricula);
            this.Controls.Add(this.cuidadosDataGridView);
            this.Name = "Cuidados";
            this.Text = "Cuidados";
            this.Load += new System.EventHandler(this.Cuidados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuidadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuidadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource cuidadosBindingSource;
        private RelacionesTableAdapters.CuidadosTableAdapter cuidadosTableAdapter;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cuidadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private RelacionesTableAdapters.CuidadosTableAdapter cuidadosTableAdapter1;
        private System.Windows.Forms.Label lBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Label lTecnico;
        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarTecnico;
        private System.Windows.Forms.Button bBuscarMatricula;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker fechaEntradaDateTimePicker;
        private System.Windows.Forms.TextBox horaEntradaTextBox;
        private System.Windows.Forms.DateTimePicker fechaSalidaDateTimePicker;
        private System.Windows.Forms.TextBox horaSalidaTextBox;
        private System.Windows.Forms.TextBox matriculaTrenTextBox;
        private System.Windows.Forms.TextBox tipoAtencionTextBox;
        private System.Windows.Forms.TextBox dniTecnicoTextBox;
        private System.Windows.Forms.TextBox caracteristicasTextBox;
        private System.Windows.Forms.TextBox valoracionTextBox;
        private System.Windows.Forms.Label valoracionLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label fechaEntradaLabel;
        private System.Windows.Forms.Label horaEntradaLabel;
        private System.Windows.Forms.Label fechaSalidaLabel;
        private System.Windows.Forms.Label horaSalidaLabel;
        private System.Windows.Forms.Label matriculaTrenLabel;
        private System.Windows.Forms.Label tipoAtencionLabel;
        private System.Windows.Forms.Label dniTecnicoLabel;
        private System.Windows.Forms.Label caracteristicasLabel;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAgregar2;
        private System.Windows.Forms.Button bModificar2;
    }
}