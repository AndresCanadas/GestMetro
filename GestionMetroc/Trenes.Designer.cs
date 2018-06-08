namespace GestionMetroc
{
    partial class Trenes
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
            this.relaciones = new GestionMetroc.Relaciones();
            this.trenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trenesTableAdapter = new GestionMetroc.RelacionesTableAdapters.TrenesTableAdapter();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            this.trenesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaLabel = new System.Windows.Forms.Label();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.dniConductorLabel = new System.Windows.Forms.Label();
            this.dniConductorTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.fechaConstruccionLabel = new System.Windows.Forms.Label();
            this.fechaConstruccionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.potenciaLabel = new System.Windows.Forms.Label();
            this.potenciaTextBox = new System.Windows.Forms.TextBox();
            this.velocidadMaxLabel = new System.Windows.Forms.Label();
            this.velocidadMaxTextBox = new System.Windows.Forms.TextBox();
            this.frenosSeLabel = new System.Windows.Forms.Label();
            this.frenosSeTextBox = new System.Windows.Forms.TextBox();
            this.sistemaAALabel = new System.Windows.Forms.Label();
            this.sistemaAATextBox = new System.Windows.Forms.TextBox();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarSueldo = new System.Windows.Forms.Button();
            this.bBuscarDni = new System.Windows.Forms.Button();
            this.bModificar2 = new System.Windows.Forms.Button();
            this.bAgregar2 = new System.Windows.Forms.Button();
            this.bBorrar2 = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.lBorrar = new System.Windows.Forms.Label();
            this.lEstacion = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relaciones
            // 
            this.relaciones.DataSetName = "Relaciones";
            this.relaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trenesBindingSource
            // 
            this.trenesBindingSource.DataMember = "Trenes";
            this.trenesBindingSource.DataSource = this.relaciones;
            // 
            // trenesTableAdapter
            // 
            this.trenesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TrenesTableAdapter = this.trenesTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionMetroc.RelacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VagonesTableAdapter = null;
            // 
            // trenesDataGridView
            // 
            this.trenesDataGridView.AutoGenerateColumns = false;
            this.trenesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trenesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.trenesDataGridView.DataSource = this.trenesBindingSource;
            this.trenesDataGridView.Location = new System.Drawing.Point(32, 324);
            this.trenesDataGridView.Name = "trenesDataGridView";
            this.trenesDataGridView.Size = new System.Drawing.Size(945, 225);
            this.trenesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Matricula";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaConstruccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaConstruccion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Potencia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Potencia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "VelocidadMax";
            this.dataGridViewTextBoxColumn7.HeaderText = "VelocidadMax";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FrenosSe";
            this.dataGridViewTextBoxColumn8.HeaderText = "FrenosSe";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SistemaAA";
            this.dataGridViewTextBoxColumn9.HeaderText = "SistemaAA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // matriculaLabel
            // 
            this.matriculaLabel.AutoSize = true;
            this.matriculaLabel.Location = new System.Drawing.Point(330, 25);
            this.matriculaLabel.Name = "matriculaLabel";
            this.matriculaLabel.Size = new System.Drawing.Size(53, 13);
            this.matriculaLabel.TabIndex = 2;
            this.matriculaLabel.Text = "Matricula:";
            this.matriculaLabel.Visible = false;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trenesBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(441, 22);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(200, 20);
            this.matriculaTextBox.TabIndex = 3;
            this.matriculaTextBox.Visible = false;
            // 
            // dniConductorLabel
            // 
            this.dniConductorLabel.AutoSize = true;
            this.dniConductorLabel.Location = new System.Drawing.Point(330, 51);
            this.dniConductorLabel.Name = "dniConductorLabel";
            this.dniConductorLabel.Size = new System.Drawing.Size(78, 13);
            this.dniConductorLabel.TabIndex = 4;
            this.dniConductorLabel.Text = "Dni Conductor:";
            this.dniConductorLabel.Visible = false;
            // 
            // dniConductorTextBox
            // 
            this.dniConductorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trenesBindingSource, "DniConductor", true));
            this.dniConductorTextBox.Location = new System.Drawing.Point(441, 48);
            this.dniConductorTextBox.Name = "dniConductorTextBox";
            this.dniConductorTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniConductorTextBox.TabIndex = 5;
            this.dniConductorTextBox.Visible = false;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(330, 77);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 6;
            this.nombreLabel.Text = "Nombre:";
            this.nombreLabel.Visible = false;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trenesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(441, 74);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 7;
            this.nombreTextBox.Visible = false;
            // 
            // modeloLabel
            // 
            this.modeloLabel.AutoSize = true;
            this.modeloLabel.Location = new System.Drawing.Point(330, 103);
            this.modeloLabel.Name = "modeloLabel";
            this.modeloLabel.Size = new System.Drawing.Size(45, 13);
            this.modeloLabel.TabIndex = 8;
            this.modeloLabel.Text = "Modelo:";
            this.modeloLabel.Visible = false;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trenesBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(441, 100);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(200, 20);
            this.modeloTextBox.TabIndex = 9;
            this.modeloTextBox.Visible = false;
            // 
            // fechaConstruccionLabel
            // 
            this.fechaConstruccionLabel.AutoSize = true;
            this.fechaConstruccionLabel.Location = new System.Drawing.Point(330, 130);
            this.fechaConstruccionLabel.Name = "fechaConstruccionLabel";
            this.fechaConstruccionLabel.Size = new System.Drawing.Size(105, 13);
            this.fechaConstruccionLabel.TabIndex = 10;
            this.fechaConstruccionLabel.Text = "Fecha Construccion:";
            this.fechaConstruccionLabel.Visible = false;
            // 
            // fechaConstruccionDateTimePicker
            // 
            this.fechaConstruccionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trenesBindingSource, "FechaConstruccion", true));
            this.fechaConstruccionDateTimePicker.Location = new System.Drawing.Point(441, 126);
            this.fechaConstruccionDateTimePicker.Name = "fechaConstruccionDateTimePicker";
            this.fechaConstruccionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaConstruccionDateTimePicker.TabIndex = 11;
            this.fechaConstruccionDateTimePicker.Visible = false;
            // 
            // potenciaLabel
            // 
            this.potenciaLabel.AutoSize = true;
            this.potenciaLabel.Location = new System.Drawing.Point(330, 155);
            this.potenciaLabel.Name = "potenciaLabel";
            this.potenciaLabel.Size = new System.Drawing.Size(52, 13);
            this.potenciaLabel.TabIndex = 12;
            this.potenciaLabel.Text = "Potencia:";
            this.potenciaLabel.Visible = false;
            // 
            // potenciaTextBox
            // 
            this.potenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trenesBindingSource, "Potencia", true));
            this.potenciaTextBox.Location = new System.Drawing.Point(441, 152);
            this.potenciaTextBox.Name = "potenciaTextBox";
            this.potenciaTextBox.Size = new System.Drawing.Size(200, 20);
            this.potenciaTextBox.TabIndex = 13;
            this.potenciaTextBox.Visible = false;
            // 
            // velocidadMaxLabel
            // 
            this.velocidadMaxLabel.AutoSize = true;
            this.velocidadMaxLabel.Location = new System.Drawing.Point(330, 181);
            this.velocidadMaxLabel.Name = "velocidadMaxLabel";
            this.velocidadMaxLabel.Size = new System.Drawing.Size(80, 13);
            this.velocidadMaxLabel.TabIndex = 14;
            this.velocidadMaxLabel.Text = "Velocidad Max:";
            this.velocidadMaxLabel.Visible = false;
            // 
            // velocidadMaxTextBox
            // 
            this.velocidadMaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trenesBindingSource, "VelocidadMax", true));
            this.velocidadMaxTextBox.Location = new System.Drawing.Point(441, 178);
            this.velocidadMaxTextBox.Name = "velocidadMaxTextBox";
            this.velocidadMaxTextBox.Size = new System.Drawing.Size(200, 20);
            this.velocidadMaxTextBox.TabIndex = 15;
            this.velocidadMaxTextBox.Visible = false;
            // 
            // frenosSeLabel
            // 
            this.frenosSeLabel.AutoSize = true;
            this.frenosSeLabel.Location = new System.Drawing.Point(330, 207);
            this.frenosSeLabel.Name = "frenosSeLabel";
            this.frenosSeLabel.Size = new System.Drawing.Size(58, 13);
            this.frenosSeLabel.TabIndex = 16;
            this.frenosSeLabel.Text = "Frenos Se:";
            this.frenosSeLabel.Visible = false;
            // 
            // frenosSeTextBox
            // 
            this.frenosSeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trenesBindingSource, "FrenosSe", true));
            this.frenosSeTextBox.Location = new System.Drawing.Point(441, 204);
            this.frenosSeTextBox.Name = "frenosSeTextBox";
            this.frenosSeTextBox.Size = new System.Drawing.Size(200, 20);
            this.frenosSeTextBox.TabIndex = 17;
            this.frenosSeTextBox.Visible = false;
            // 
            // sistemaAALabel
            // 
            this.sistemaAALabel.AutoSize = true;
            this.sistemaAALabel.Location = new System.Drawing.Point(330, 233);
            this.sistemaAALabel.Name = "sistemaAALabel";
            this.sistemaAALabel.Size = new System.Drawing.Size(64, 13);
            this.sistemaAALabel.TabIndex = 18;
            this.sistemaAALabel.Text = "Sistema AA:";
            this.sistemaAALabel.Visible = false;
            // 
            // sistemaAATextBox
            // 
            this.sistemaAATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trenesBindingSource, "SistemaAA", true));
            this.sistemaAATextBox.Location = new System.Drawing.Point(441, 230);
            this.sistemaAATextBox.Name = "sistemaAATextBox";
            this.sistemaAATextBox.Size = new System.Drawing.Size(200, 20);
            this.sistemaAATextBox.TabIndex = 19;
            this.sistemaAATextBox.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(767, 12);
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
            this.bAgregar.Location = new System.Drawing.Point(643, 12);
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
            this.bBorrar.Location = new System.Drawing.Point(519, 12);
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
            this.bContar.Location = new System.Drawing.Point(399, 12);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 97;
            this.bContar.Text = "Contar trenes";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click);
            // 
            // bBuscarSueldo
            // 
            this.bBuscarSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarSueldo.Location = new System.Drawing.Point(276, 11);
            this.bBuscarSueldo.Name = "bBuscarSueldo";
            this.bBuscarSueldo.Size = new System.Drawing.Size(107, 53);
            this.bBuscarSueldo.TabIndex = 96;
            this.bBuscarSueldo.Text = "Buscar por potencia";
            this.bBuscarSueldo.UseVisualStyleBackColor = true;
            this.bBuscarSueldo.Click += new System.EventHandler(this.bBuscarSueldo_Click);
            // 
            // bBuscarDni
            // 
            this.bBuscarDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarDni.Location = new System.Drawing.Point(131, 12);
            this.bBuscarDni.Name = "bBuscarDni";
            this.bBuscarDni.Size = new System.Drawing.Size(127, 53);
            this.bBuscarDni.TabIndex = 95;
            this.bBuscarDni.Text = "Buscar por matricula";
            this.bBuscarDni.UseVisualStyleBackColor = true;
            this.bBuscarDni.Click += new System.EventHandler(this.bBuscarDni_Click);
            // 
            // bModificar2
            // 
            this.bModificar2.Location = new System.Drawing.Point(450, 272);
            this.bModificar2.Name = "bModificar2";
            this.bModificar2.Size = new System.Drawing.Size(75, 23);
            this.bModificar2.TabIndex = 115;
            this.bModificar2.Text = "Modificar";
            this.bModificar2.UseVisualStyleBackColor = true;
            this.bModificar2.Visible = false;
            this.bModificar2.Click += new System.EventHandler(this.bModificar2_Click);
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(450, 272);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 114;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.bAgregar2_Click);
            // 
            // bBorrar2
            // 
            this.bBorrar2.Location = new System.Drawing.Point(450, 272);
            this.bBorrar2.Name = "bBorrar2";
            this.bBorrar2.Size = new System.Drawing.Size(75, 23);
            this.bBorrar2.TabIndex = 113;
            this.bBorrar2.Text = "Borrar";
            this.bBorrar2.UseVisualStyleBackColor = true;
            this.bBorrar2.Visible = false;
            this.bBorrar2.Click += new System.EventHandler(this.bBorrar2_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(550, 272);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 112;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(450, 272);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 111;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(480, 200);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 110;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // lEstacion
            // 
            this.lEstacion.AutoSize = true;
            this.lEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstacion.Location = new System.Drawing.Point(427, 194);
            this.lEstacion.Name = "lEstacion";
            this.lEstacion.Size = new System.Drawing.Size(195, 20);
            this.lEstacion.TabIndex = 109;
            this.lEstacion.Text = "Busqueda por potencia";
            this.lEstacion.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(450, 230);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 108;
            this.tbBusqueda.Visible = false;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(437, 200);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(199, 20);
            this.lNombre.TabIndex = 116;
            this.lNombre.Text = "Busqueda por matrícula";
            this.lNombre.Visible = false;
            // 
            // Trenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 569);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bModificar2);
            this.Controls.Add(this.bAgregar2);
            this.Controls.Add(this.bBorrar2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.lEstacion);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.bBuscarSueldo);
            this.Controls.Add(this.bBuscarDni);
            this.Controls.Add(this.matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(this.dniConductorLabel);
            this.Controls.Add(this.dniConductorTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(this.fechaConstruccionLabel);
            this.Controls.Add(this.fechaConstruccionDateTimePicker);
            this.Controls.Add(this.potenciaLabel);
            this.Controls.Add(this.potenciaTextBox);
            this.Controls.Add(this.velocidadMaxLabel);
            this.Controls.Add(this.velocidadMaxTextBox);
            this.Controls.Add(this.frenosSeLabel);
            this.Controls.Add(this.frenosSeTextBox);
            this.Controls.Add(this.sistemaAALabel);
            this.Controls.Add(this.sistemaAATextBox);
            this.Controls.Add(this.trenesDataGridView);
            this.Name = "Trenes";
            this.Text = "Trenes";
            this.Load += new System.EventHandler(this.Trenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource trenesBindingSource;
        private RelacionesTableAdapters.TrenesTableAdapter trenesTableAdapter;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView trenesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label matriculaLabel;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.Label dniConductorLabel;
        private System.Windows.Forms.TextBox dniConductorTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label modeloLabel;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.Label fechaConstruccionLabel;
        private System.Windows.Forms.DateTimePicker fechaConstruccionDateTimePicker;
        private System.Windows.Forms.Label potenciaLabel;
        private System.Windows.Forms.TextBox potenciaTextBox;
        private System.Windows.Forms.Label velocidadMaxLabel;
        private System.Windows.Forms.TextBox velocidadMaxTextBox;
        private System.Windows.Forms.Label frenosSeLabel;
        private System.Windows.Forms.TextBox frenosSeTextBox;
        private System.Windows.Forms.Label sistemaAALabel;
        private System.Windows.Forms.TextBox sistemaAATextBox;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarSueldo;
        private System.Windows.Forms.Button bBuscarDni;
        private System.Windows.Forms.Button bModificar2;
        private System.Windows.Forms.Button bAgregar2;
        private System.Windows.Forms.Button bBorrar2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label lBorrar;
        private System.Windows.Forms.Label lEstacion;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label lNombre;
    }
}