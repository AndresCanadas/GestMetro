namespace GestionMetroc
{
    partial class Tecnicos
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
            this.tecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecnicosTableAdapter = new GestionMetroc.RelacionesTableAdapters.TecnicosTableAdapter();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            this.tecnicosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniLabel = new System.Windows.Forms.Label();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosLabel = new System.Windows.Forms.Label();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoLabel = new System.Windows.Forms.Label();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaEntradaLabel = new System.Windows.Forms.Label();
            this.fechaEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipoTrabajoLabel = new System.Windows.Forms.Label();
            this.tipoTrabajoTextBox = new System.Windows.Forms.TextBox();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarEstacion = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relaciones
            // 
            this.relaciones.DataSetName = "Relaciones";
            this.relaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tecnicosBindingSource
            // 
            this.tecnicosBindingSource.DataMember = "Tecnicos";
            this.tecnicosBindingSource.DataSource = this.relaciones;
            // 
            // tecnicosTableAdapter
            // 
            this.tecnicosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TecnicosTableAdapter = this.tecnicosTableAdapter;
            this.tableAdapterManager.TornosTableAdapter = null;
            this.tableAdapterManager.TrenesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionMetroc.RelacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VagonesTableAdapter = null;
            // 
            // tecnicosDataGridView
            // 
            this.tecnicosDataGridView.AutoGenerateColumns = false;
            this.tecnicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tecnicosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tecnicosDataGridView.DataSource = this.tecnicosBindingSource;
            this.tecnicosDataGridView.Location = new System.Drawing.Point(29, 307);
            this.tecnicosDataGridView.Name = "tecnicosDataGridView";
            this.tecnicosDataGridView.Size = new System.Drawing.Size(943, 220);
            this.tecnicosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Dni";
            this.dataGridViewTextBoxColumn1.HeaderText = "Dni";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn7.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FechaEntrada";
            this.dataGridViewTextBoxColumn8.HeaderText = "FechaEntrada";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TipoTrabajo";
            this.dataGridViewTextBoxColumn9.HeaderText = "TipoTrabajo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(342, 15);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(26, 13);
            this.dniLabel.TabIndex = 2;
            this.dniLabel.Text = "Dni:";
            this.dniLabel.Visible = false;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tecnicosBindingSource, "Dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(444, 12);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniTextBox.TabIndex = 3;
            this.dniTextBox.Visible = false;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(342, 41);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre:";
            this.nombreLabel.Visible = false;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tecnicosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(444, 38);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 5;
            this.nombreTextBox.Visible = false;
            // 
            // apellidosLabel
            // 
            this.apellidosLabel.AutoSize = true;
            this.apellidosLabel.Location = new System.Drawing.Point(342, 67);
            this.apellidosLabel.Name = "apellidosLabel";
            this.apellidosLabel.Size = new System.Drawing.Size(52, 13);
            this.apellidosLabel.TabIndex = 6;
            this.apellidosLabel.Text = "Apellidos:";
            this.apellidosLabel.Visible = false;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tecnicosBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(444, 64);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidosTextBox.TabIndex = 7;
            this.apellidosTextBox.Visible = false;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(342, 93);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(55, 13);
            this.direccionLabel.TabIndex = 8;
            this.direccionLabel.Text = "Direccion:";
            this.direccionLabel.Visible = false;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tecnicosBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(444, 90);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 9;
            this.direccionTextBox.Visible = false;
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(342, 119);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(52, 13);
            this.telefonoLabel.TabIndex = 10;
            this.telefonoLabel.Text = "Telefono:";
            this.telefonoLabel.Visible = false;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tecnicosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(444, 116);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 11;
            this.telefonoTextBox.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(342, 145);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tecnicosBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(444, 142);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.Visible = false;
            // 
            // fechaNacimientoLabel
            // 
            this.fechaNacimientoLabel.AutoSize = true;
            this.fechaNacimientoLabel.Location = new System.Drawing.Point(342, 172);
            this.fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            this.fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            this.fechaNacimientoLabel.TabIndex = 14;
            this.fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            this.fechaNacimientoLabel.Visible = false;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tecnicosBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(444, 168);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 15;
            this.fechaNacimientoDateTimePicker.Visible = false;
            // 
            // fechaEntradaLabel
            // 
            this.fechaEntradaLabel.AutoSize = true;
            this.fechaEntradaLabel.Location = new System.Drawing.Point(342, 198);
            this.fechaEntradaLabel.Name = "fechaEntradaLabel";
            this.fechaEntradaLabel.Size = new System.Drawing.Size(80, 13);
            this.fechaEntradaLabel.TabIndex = 16;
            this.fechaEntradaLabel.Text = "Fecha Entrada:";
            this.fechaEntradaLabel.Visible = false;
            // 
            // fechaEntradaDateTimePicker
            // 
            this.fechaEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tecnicosBindingSource, "FechaEntrada", true));
            this.fechaEntradaDateTimePicker.Location = new System.Drawing.Point(444, 194);
            this.fechaEntradaDateTimePicker.Name = "fechaEntradaDateTimePicker";
            this.fechaEntradaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntradaDateTimePicker.TabIndex = 17;
            this.fechaEntradaDateTimePicker.Visible = false;
            // 
            // tipoTrabajoLabel
            // 
            this.tipoTrabajoLabel.AutoSize = true;
            this.tipoTrabajoLabel.Location = new System.Drawing.Point(342, 223);
            this.tipoTrabajoLabel.Name = "tipoTrabajoLabel";
            this.tipoTrabajoLabel.Size = new System.Drawing.Size(70, 13);
            this.tipoTrabajoLabel.TabIndex = 18;
            this.tipoTrabajoLabel.Text = "Tipo Trabajo:";
            this.tipoTrabajoLabel.Visible = false;
            // 
            // tipoTrabajoTextBox
            // 
            this.tipoTrabajoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tecnicosBindingSource, "TipoTrabajo", true));
            this.tipoTrabajoTextBox.Location = new System.Drawing.Point(444, 220);
            this.tipoTrabajoTextBox.Name = "tipoTrabajoTextBox";
            this.tipoTrabajoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipoTrabajoTextBox.TabIndex = 19;
            this.tipoTrabajoTextBox.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(774, 12);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(107, 53);
            this.bModificar.TabIndex = 94;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(650, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(107, 53);
            this.bAgregar.TabIndex = 93;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(526, 12);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(107, 53);
            this.bBorrar.TabIndex = 92;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bContar
            // 
            this.bContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContar.Location = new System.Drawing.Point(406, 12);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 91;
            this.bContar.Text = "Contar ténicos";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click);
            // 
            // bBuscarEstacion
            // 
            this.bBuscarEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarEstacion.Location = new System.Drawing.Point(282, 12);
            this.bBuscarEstacion.Name = "bBuscarEstacion";
            this.bBuscarEstacion.Size = new System.Drawing.Size(107, 53);
            this.bBuscarEstacion.TabIndex = 90;
            this.bBuscarEstacion.Text = "Buscar por DNI";
            this.bBuscarEstacion.UseVisualStyleBackColor = true;
            this.bBuscarEstacion.Click += new System.EventHandler(this.bBuscarEstacion_Click);
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarNombre.Location = new System.Drawing.Point(158, 12);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(107, 53);
            this.bBuscarNombre.TabIndex = 89;
            this.bBuscarNombre.Text = "Buscar por nombre";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bModificar2
            // 
            this.bModificar2.Location = new System.Drawing.Point(377, 249);
            this.bModificar2.Name = "bModificar2";
            this.bModificar2.Size = new System.Drawing.Size(75, 23);
            this.bModificar2.TabIndex = 111;
            this.bModificar2.Text = "Modificar";
            this.bModificar2.UseVisualStyleBackColor = true;
            this.bModificar2.Visible = false;
            this.bModificar2.Click += new System.EventHandler(this.bModificar2_Click);
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(406, 249);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 110;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.bAgregar2_Click);
            // 
            // bBorrar2
            // 
            this.bBorrar2.Location = new System.Drawing.Point(406, 264);
            this.bBorrar2.Name = "bBorrar2";
            this.bBorrar2.Size = new System.Drawing.Size(75, 23);
            this.bBorrar2.TabIndex = 109;
            this.bBorrar2.Text = "Borrar";
            this.bBorrar2.UseVisualStyleBackColor = true;
            this.bBorrar2.Visible = false;
            this.bBorrar2.Click += new System.EventHandler(this.bBorrar2_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(548, 249);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 108;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(497, 178);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 107;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // lEstacion
            // 
            this.lEstacion.AutoSize = true;
            this.lEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstacion.Location = new System.Drawing.Point(476, 178);
            this.lEstacion.Name = "lEstacion";
            this.lEstacion.Size = new System.Drawing.Size(157, 20);
            this.lEstacion.TabIndex = 106;
            this.lEstacion.Text = "Busqueda por DNI";
            this.lEstacion.Visible = false;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(458, 178);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(186, 20);
            this.lNombre.TabIndex = 105;
            this.lNombre.Text = "Busqueda por nombre";
            this.lNombre.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(458, 208);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 104;
            this.tbBusqueda.Visible = false;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(467, 249);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 103;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // Tecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 548);
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
            this.Controls.Add(this.bBuscarEstacion);
            this.Controls.Add(this.bBuscarNombre);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(this.fechaEntradaLabel);
            this.Controls.Add(this.fechaEntradaDateTimePicker);
            this.Controls.Add(this.tipoTrabajoLabel);
            this.Controls.Add(this.tipoTrabajoTextBox);
            this.Controls.Add(this.tecnicosDataGridView);
            this.Name = "Tecnicos";
            this.Text = "Tecnicos";
            this.Load += new System.EventHandler(this.Tecnicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource tecnicosBindingSource;
        private RelacionesTableAdapters.TecnicosTableAdapter tecnicosTableAdapter;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tecnicosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label apellidosLabel;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label fechaNacimientoLabel;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.Label fechaEntradaLabel;
        private System.Windows.Forms.DateTimePicker fechaEntradaDateTimePicker;
        private System.Windows.Forms.Label tipoTrabajoLabel;
        private System.Windows.Forms.TextBox tipoTrabajoTextBox;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarEstacion;
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
    }
}