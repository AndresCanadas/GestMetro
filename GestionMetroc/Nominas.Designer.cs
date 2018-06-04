namespace GestionMetroc
{
    partial class Nominas
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
            this.nominasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominasTableAdapter = new GestionMetroc.RelacionesTableAdapters.NominasTableAdapter();
            this.tableAdapterManager = new GestionMetroc.RelacionesTableAdapters.TableAdapterManager();
            this.nominasDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.periodoLabel = new System.Windows.Forms.Label();
            this.periodoTextBox = new System.Windows.Forms.TextBox();
            this.dniEmpleadoLabel = new System.Windows.Forms.Label();
            this.dniEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.sueldoBrutoLabel = new System.Windows.Forms.Label();
            this.sueldoBrutoTextBox = new System.Windows.Forms.TextBox();
            this.descuentoSSLabel = new System.Windows.Forms.Label();
            this.descuentoSSTextBox = new System.Windows.Forms.TextBox();
            this.descuentoIRPFLabel = new System.Windows.Forms.Label();
            this.descuentoIRPFTextBox = new System.Windows.Forms.TextBox();
            this.plusTrienosLabel = new System.Windows.Forms.Label();
            this.plusTrienosTextBox = new System.Windows.Forms.TextBox();
            this.plusProductividadLabel = new System.Windows.Forms.Label();
            this.plusProductividadTextBox = new System.Windows.Forms.TextBox();
            this.sueldoNetoLabel = new System.Windows.Forms.Label();
            this.sueldoNetoTextBox = new System.Windows.Forms.TextBox();
            this.tipoContratoLabel = new System.Windows.Forms.Label();
            this.tipoContratoTextBox = new System.Windows.Forms.TextBox();
            this.precioHoraLabel = new System.Windows.Forms.Label();
            this.precioHoraTextBox = new System.Windows.Forms.TextBox();
            this.totalHorasLabel = new System.Windows.Forms.Label();
            this.totalHorasTextBox = new System.Windows.Forms.TextBox();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bContar = new System.Windows.Forms.Button();
            this.bBuscarSueldo = new System.Windows.Forms.Button();
            this.bBuscarDni = new System.Windows.Forms.Button();
            this.lBorrar = new System.Windows.Forms.Label();
            this.lEstacion = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.bModificar2 = new System.Windows.Forms.Button();
            this.bAgregar2 = new System.Windows.Forms.Button();
            this.bBorrar2 = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relaciones
            // 
            this.relaciones.DataSetName = "Relaciones";
            this.relaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominasBindingSource
            // 
            this.nominasBindingSource.DataMember = "Nominas";
            this.nominasBindingSource.DataSource = this.relaciones;
            // 
            // nominasTableAdapter
            // 
            this.nominasTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NominasTableAdapter = this.nominasTableAdapter;
            this.tableAdapterManager.TecnicosTableAdapter = null;
            this.tableAdapterManager.TornosTableAdapter = null;
            this.tableAdapterManager.TrenesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionMetroc.RelacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VagonesTableAdapter = null;
            // 
            // nominasDataGridView
            // 
            this.nominasDataGridView.AutoGenerateColumns = false;
            this.nominasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nominasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.nominasDataGridView.DataSource = this.nominasBindingSource;
            this.nominasDataGridView.Location = new System.Drawing.Point(12, 416);
            this.nominasDataGridView.Name = "nominasDataGridView";
            this.nominasDataGridView.Size = new System.Drawing.Size(1342, 288);
            this.nominasDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Periodo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DniEmpleado";
            this.dataGridViewTextBoxColumn4.HeaderText = "DniEmpleado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SueldoBruto";
            this.dataGridViewTextBoxColumn5.HeaderText = "SueldoBruto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DescuentoSS";
            this.dataGridViewTextBoxColumn6.HeaderText = "DescuentoSS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DescuentoIRPF";
            this.dataGridViewTextBoxColumn7.HeaderText = "DescuentoIRPF";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PlusTrienos";
            this.dataGridViewTextBoxColumn8.HeaderText = "PlusTrienos";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PlusProductividad";
            this.dataGridViewTextBoxColumn9.HeaderText = "PlusProductividad";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SueldoNeto";
            this.dataGridViewTextBoxColumn10.HeaderText = "SueldoNeto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TipoContrato";
            this.dataGridViewTextBoxColumn11.HeaderText = "TipoContrato";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PrecioHora";
            this.dataGridViewTextBoxColumn12.HeaderText = "PrecioHora";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TotalHoras";
            this.dataGridViewTextBoxColumn13.HeaderText = "TotalHoras";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(525, 15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Id:";
            this.idLabel.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(629, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.Visible = false;
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(525, 42);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(40, 13);
            this.fechaLabel.TabIndex = 4;
            this.fechaLabel.Text = "Fecha:";
            this.fechaLabel.Visible = false;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nominasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(629, 38);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 5;
            this.fechaDateTimePicker.Visible = false;
            // 
            // periodoLabel
            // 
            this.periodoLabel.AutoSize = true;
            this.periodoLabel.Location = new System.Drawing.Point(525, 67);
            this.periodoLabel.Name = "periodoLabel";
            this.periodoLabel.Size = new System.Drawing.Size(46, 13);
            this.periodoLabel.TabIndex = 6;
            this.periodoLabel.Text = "Periodo:";
            this.periodoLabel.Visible = false;
            // 
            // periodoTextBox
            // 
            this.periodoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "Periodo", true));
            this.periodoTextBox.Location = new System.Drawing.Point(629, 64);
            this.periodoTextBox.Name = "periodoTextBox";
            this.periodoTextBox.Size = new System.Drawing.Size(200, 20);
            this.periodoTextBox.TabIndex = 7;
            this.periodoTextBox.Visible = false;
            // 
            // dniEmpleadoLabel
            // 
            this.dniEmpleadoLabel.AutoSize = true;
            this.dniEmpleadoLabel.Location = new System.Drawing.Point(525, 93);
            this.dniEmpleadoLabel.Name = "dniEmpleadoLabel";
            this.dniEmpleadoLabel.Size = new System.Drawing.Size(76, 13);
            this.dniEmpleadoLabel.TabIndex = 8;
            this.dniEmpleadoLabel.Text = "Dni Empleado:";
            this.dniEmpleadoLabel.Visible = false;
            // 
            // dniEmpleadoTextBox
            // 
            this.dniEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "DniEmpleado", true));
            this.dniEmpleadoTextBox.Location = new System.Drawing.Point(629, 90);
            this.dniEmpleadoTextBox.Name = "dniEmpleadoTextBox";
            this.dniEmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniEmpleadoTextBox.TabIndex = 9;
            this.dniEmpleadoTextBox.Visible = false;
            // 
            // sueldoBrutoLabel
            // 
            this.sueldoBrutoLabel.AutoSize = true;
            this.sueldoBrutoLabel.Location = new System.Drawing.Point(525, 119);
            this.sueldoBrutoLabel.Name = "sueldoBrutoLabel";
            this.sueldoBrutoLabel.Size = new System.Drawing.Size(71, 13);
            this.sueldoBrutoLabel.TabIndex = 10;
            this.sueldoBrutoLabel.Text = "Sueldo Bruto:";
            this.sueldoBrutoLabel.Visible = false;
            // 
            // sueldoBrutoTextBox
            // 
            this.sueldoBrutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "SueldoBruto", true));
            this.sueldoBrutoTextBox.Location = new System.Drawing.Point(629, 116);
            this.sueldoBrutoTextBox.Name = "sueldoBrutoTextBox";
            this.sueldoBrutoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sueldoBrutoTextBox.TabIndex = 11;
            this.sueldoBrutoTextBox.Visible = false;
            // 
            // descuentoSSLabel
            // 
            this.descuentoSSLabel.AutoSize = true;
            this.descuentoSSLabel.Location = new System.Drawing.Point(525, 145);
            this.descuentoSSLabel.Name = "descuentoSSLabel";
            this.descuentoSSLabel.Size = new System.Drawing.Size(79, 13);
            this.descuentoSSLabel.TabIndex = 12;
            this.descuentoSSLabel.Text = "Descuento SS:";
            this.descuentoSSLabel.Visible = false;
            // 
            // descuentoSSTextBox
            // 
            this.descuentoSSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "DescuentoSS", true));
            this.descuentoSSTextBox.Location = new System.Drawing.Point(629, 142);
            this.descuentoSSTextBox.Name = "descuentoSSTextBox";
            this.descuentoSSTextBox.Size = new System.Drawing.Size(200, 20);
            this.descuentoSSTextBox.TabIndex = 13;
            this.descuentoSSTextBox.Visible = false;
            // 
            // descuentoIRPFLabel
            // 
            this.descuentoIRPFLabel.AutoSize = true;
            this.descuentoIRPFLabel.Location = new System.Drawing.Point(525, 171);
            this.descuentoIRPFLabel.Name = "descuentoIRPFLabel";
            this.descuentoIRPFLabel.Size = new System.Drawing.Size(89, 13);
            this.descuentoIRPFLabel.TabIndex = 14;
            this.descuentoIRPFLabel.Text = "Descuento IRPF:";
            this.descuentoIRPFLabel.Visible = false;
            // 
            // descuentoIRPFTextBox
            // 
            this.descuentoIRPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "DescuentoIRPF", true));
            this.descuentoIRPFTextBox.Location = new System.Drawing.Point(629, 168);
            this.descuentoIRPFTextBox.Name = "descuentoIRPFTextBox";
            this.descuentoIRPFTextBox.Size = new System.Drawing.Size(200, 20);
            this.descuentoIRPFTextBox.TabIndex = 15;
            this.descuentoIRPFTextBox.Visible = false;
            // 
            // plusTrienosLabel
            // 
            this.plusTrienosLabel.AutoSize = true;
            this.plusTrienosLabel.Location = new System.Drawing.Point(525, 197);
            this.plusTrienosLabel.Name = "plusTrienosLabel";
            this.plusTrienosLabel.Size = new System.Drawing.Size(68, 13);
            this.plusTrienosLabel.TabIndex = 16;
            this.plusTrienosLabel.Text = "Plus Trienos:";
            this.plusTrienosLabel.Visible = false;
            // 
            // plusTrienosTextBox
            // 
            this.plusTrienosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "PlusTrienos", true));
            this.plusTrienosTextBox.Location = new System.Drawing.Point(629, 194);
            this.plusTrienosTextBox.Name = "plusTrienosTextBox";
            this.plusTrienosTextBox.Size = new System.Drawing.Size(200, 20);
            this.plusTrienosTextBox.TabIndex = 17;
            this.plusTrienosTextBox.Visible = false;
            // 
            // plusProductividadLabel
            // 
            this.plusProductividadLabel.AutoSize = true;
            this.plusProductividadLabel.Location = new System.Drawing.Point(525, 223);
            this.plusProductividadLabel.Name = "plusProductividadLabel";
            this.plusProductividadLabel.Size = new System.Drawing.Size(98, 13);
            this.plusProductividadLabel.TabIndex = 18;
            this.plusProductividadLabel.Text = "Plus Productividad:";
            this.plusProductividadLabel.Visible = false;
            // 
            // plusProductividadTextBox
            // 
            this.plusProductividadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "PlusProductividad", true));
            this.plusProductividadTextBox.Location = new System.Drawing.Point(629, 220);
            this.plusProductividadTextBox.Name = "plusProductividadTextBox";
            this.plusProductividadTextBox.Size = new System.Drawing.Size(200, 20);
            this.plusProductividadTextBox.TabIndex = 19;
            this.plusProductividadTextBox.Visible = false;
            // 
            // sueldoNetoLabel
            // 
            this.sueldoNetoLabel.AutoSize = true;
            this.sueldoNetoLabel.Location = new System.Drawing.Point(525, 249);
            this.sueldoNetoLabel.Name = "sueldoNetoLabel";
            this.sueldoNetoLabel.Size = new System.Drawing.Size(69, 13);
            this.sueldoNetoLabel.TabIndex = 20;
            this.sueldoNetoLabel.Text = "Sueldo Neto:";
            this.sueldoNetoLabel.Visible = false;
            // 
            // sueldoNetoTextBox
            // 
            this.sueldoNetoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "SueldoNeto", true));
            this.sueldoNetoTextBox.Location = new System.Drawing.Point(629, 246);
            this.sueldoNetoTextBox.Name = "sueldoNetoTextBox";
            this.sueldoNetoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sueldoNetoTextBox.TabIndex = 21;
            this.sueldoNetoTextBox.Visible = false;
            // 
            // tipoContratoLabel
            // 
            this.tipoContratoLabel.AutoSize = true;
            this.tipoContratoLabel.Location = new System.Drawing.Point(525, 275);
            this.tipoContratoLabel.Name = "tipoContratoLabel";
            this.tipoContratoLabel.Size = new System.Drawing.Size(74, 13);
            this.tipoContratoLabel.TabIndex = 22;
            this.tipoContratoLabel.Text = "Tipo Contrato:";
            this.tipoContratoLabel.Visible = false;
            // 
            // tipoContratoTextBox
            // 
            this.tipoContratoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "TipoContrato", true));
            this.tipoContratoTextBox.Location = new System.Drawing.Point(629, 272);
            this.tipoContratoTextBox.Name = "tipoContratoTextBox";
            this.tipoContratoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipoContratoTextBox.TabIndex = 23;
            this.tipoContratoTextBox.Visible = false;
            // 
            // precioHoraLabel
            // 
            this.precioHoraLabel.AutoSize = true;
            this.precioHoraLabel.Location = new System.Drawing.Point(525, 301);
            this.precioHoraLabel.Name = "precioHoraLabel";
            this.precioHoraLabel.Size = new System.Drawing.Size(66, 13);
            this.precioHoraLabel.TabIndex = 24;
            this.precioHoraLabel.Text = "Precio Hora:";
            this.precioHoraLabel.Visible = false;
            // 
            // precioHoraTextBox
            // 
            this.precioHoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "PrecioHora", true));
            this.precioHoraTextBox.Location = new System.Drawing.Point(629, 298);
            this.precioHoraTextBox.Name = "precioHoraTextBox";
            this.precioHoraTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioHoraTextBox.TabIndex = 25;
            this.precioHoraTextBox.Visible = false;
            // 
            // totalHorasLabel
            // 
            this.totalHorasLabel.AutoSize = true;
            this.totalHorasLabel.Location = new System.Drawing.Point(525, 327);
            this.totalHorasLabel.Name = "totalHorasLabel";
            this.totalHorasLabel.Size = new System.Drawing.Size(65, 13);
            this.totalHorasLabel.TabIndex = 26;
            this.totalHorasLabel.Text = "Total Horas:";
            this.totalHorasLabel.Visible = false;
            // 
            // totalHorasTextBox
            // 
            this.totalHorasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "TotalHoras", true));
            this.totalHorasTextBox.Location = new System.Drawing.Point(629, 324);
            this.totalHorasTextBox.Name = "totalHorasTextBox";
            this.totalHorasTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalHorasTextBox.TabIndex = 27;
            this.totalHorasTextBox.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(959, 5);
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
            this.bAgregar.Location = new System.Drawing.Point(835, 5);
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
            this.bBorrar.Location = new System.Drawing.Point(711, 5);
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
            this.bContar.Location = new System.Drawing.Point(591, 5);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(107, 53);
            this.bContar.TabIndex = 91;
            this.bContar.Text = "Contar nominas";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.bContar_Click);
            // 
            // bBuscarSueldo
            // 
            this.bBuscarSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarSueldo.Location = new System.Drawing.Point(467, 5);
            this.bBuscarSueldo.Name = "bBuscarSueldo";
            this.bBuscarSueldo.Size = new System.Drawing.Size(107, 53);
            this.bBuscarSueldo.TabIndex = 90;
            this.bBuscarSueldo.Text = "Buscar por sueldo neto";
            this.bBuscarSueldo.UseVisualStyleBackColor = true;
            this.bBuscarSueldo.Click += new System.EventHandler(this.bBuscarSueldo_Click);
            // 
            // bBuscarDni
            // 
            this.bBuscarDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarDni.Location = new System.Drawing.Point(323, 5);
            this.bBuscarDni.Name = "bBuscarDni";
            this.bBuscarDni.Size = new System.Drawing.Size(127, 53);
            this.bBuscarDni.TabIndex = 89;
            this.bBuscarDni.Text = "Buscar por Dni empleado";
            this.bBuscarDni.UseVisualStyleBackColor = true;
            this.bBuscarDni.Click += new System.EventHandler(this.bBuscarDni_Click);
            // 
            // lBorrar
            // 
            this.lBorrar.AutoSize = true;
            this.lBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.Location = new System.Drawing.Point(676, 275);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(114, 20);
            this.lBorrar.TabIndex = 98;
            this.lBorrar.Text = "Borrar por ID";
            this.lBorrar.Visible = false;
            // 
            // lEstacion
            // 
            this.lEstacion.AutoSize = true;
            this.lEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstacion.Location = new System.Drawing.Point(619, 275);
            this.lEstacion.Name = "lEstacion";
            this.lEstacion.Size = new System.Drawing.Size(220, 20);
            this.lEstacion.TabIndex = 97;
            this.lEstacion.Text = "Busqueda por sueldo neto";
            this.lEstacion.Visible = false;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(649, 275);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(157, 20);
            this.lNombre.TabIndex = 96;
            this.lNombre.Text = "Busqueda por DNI";
            this.lNombre.Visible = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(642, 311);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 26);
            this.tbBusqueda.TabIndex = 95;
            this.tbBusqueda.Visible = false;
            // 
            // bModificar2
            // 
            this.bModificar2.Location = new System.Drawing.Point(642, 353);
            this.bModificar2.Name = "bModificar2";
            this.bModificar2.Size = new System.Drawing.Size(75, 23);
            this.bModificar2.TabIndex = 107;
            this.bModificar2.Text = "Modificar";
            this.bModificar2.UseVisualStyleBackColor = true;
            this.bModificar2.Visible = false;
            this.bModificar2.Click += new System.EventHandler(this.bModificar2_Click);
            // 
            // bAgregar2
            // 
            this.bAgregar2.Location = new System.Drawing.Point(642, 353);
            this.bAgregar2.Name = "bAgregar2";
            this.bAgregar2.Size = new System.Drawing.Size(75, 23);
            this.bAgregar2.TabIndex = 106;
            this.bAgregar2.Text = "Agregar";
            this.bAgregar2.UseVisualStyleBackColor = true;
            this.bAgregar2.Visible = false;
            this.bAgregar2.Click += new System.EventHandler(this.bAgregar2_Click);
            // 
            // bBorrar2
            // 
            this.bBorrar2.Location = new System.Drawing.Point(642, 353);
            this.bBorrar2.Name = "bBorrar2";
            this.bBorrar2.Size = new System.Drawing.Size(75, 23);
            this.bBorrar2.TabIndex = 105;
            this.bBorrar2.Text = "Borrar";
            this.bBorrar2.UseVisualStyleBackColor = true;
            this.bBorrar2.Visible = false;
            this.bBorrar2.Click += new System.EventHandler(this.bBorrar2_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(742, 353);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 104;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(642, 353);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 103;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // Nominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 716);
            this.Controls.Add(this.bModificar2);
            this.Controls.Add(this.bAgregar2);
            this.Controls.Add(this.bBorrar2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.lEstacion);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.bBuscarSueldo);
            this.Controls.Add(this.bBuscarDni);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.periodoLabel);
            this.Controls.Add(this.periodoTextBox);
            this.Controls.Add(this.dniEmpleadoLabel);
            this.Controls.Add(this.dniEmpleadoTextBox);
            this.Controls.Add(this.sueldoBrutoLabel);
            this.Controls.Add(this.sueldoBrutoTextBox);
            this.Controls.Add(this.descuentoSSLabel);
            this.Controls.Add(this.descuentoSSTextBox);
            this.Controls.Add(this.descuentoIRPFLabel);
            this.Controls.Add(this.descuentoIRPFTextBox);
            this.Controls.Add(this.plusTrienosLabel);
            this.Controls.Add(this.plusTrienosTextBox);
            this.Controls.Add(this.plusProductividadLabel);
            this.Controls.Add(this.plusProductividadTextBox);
            this.Controls.Add(this.sueldoNetoLabel);
            this.Controls.Add(this.sueldoNetoTextBox);
            this.Controls.Add(this.tipoContratoLabel);
            this.Controls.Add(this.tipoContratoTextBox);
            this.Controls.Add(this.precioHoraLabel);
            this.Controls.Add(this.precioHoraTextBox);
            this.Controls.Add(this.totalHorasLabel);
            this.Controls.Add(this.totalHorasTextBox);
            this.Controls.Add(this.nominasDataGridView);
            this.Name = "Nominas";
            this.Text = "Nominas";
            this.Load += new System.EventHandler(this.Nominas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaciones relaciones;
        private System.Windows.Forms.BindingSource nominasBindingSource;
        private RelacionesTableAdapters.NominasTableAdapter nominasTableAdapter;
        private RelacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nominasDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Label periodoLabel;
        private System.Windows.Forms.TextBox periodoTextBox;
        private System.Windows.Forms.Label dniEmpleadoLabel;
        private System.Windows.Forms.TextBox dniEmpleadoTextBox;
        private System.Windows.Forms.Label sueldoBrutoLabel;
        private System.Windows.Forms.TextBox sueldoBrutoTextBox;
        private System.Windows.Forms.Label descuentoSSLabel;
        private System.Windows.Forms.TextBox descuentoSSTextBox;
        private System.Windows.Forms.Label descuentoIRPFLabel;
        private System.Windows.Forms.TextBox descuentoIRPFTextBox;
        private System.Windows.Forms.Label plusTrienosLabel;
        private System.Windows.Forms.TextBox plusTrienosTextBox;
        private System.Windows.Forms.Label plusProductividadLabel;
        private System.Windows.Forms.TextBox plusProductividadTextBox;
        private System.Windows.Forms.Label sueldoNetoLabel;
        private System.Windows.Forms.TextBox sueldoNetoTextBox;
        private System.Windows.Forms.Label tipoContratoLabel;
        private System.Windows.Forms.TextBox tipoContratoTextBox;
        private System.Windows.Forms.Label precioHoraLabel;
        private System.Windows.Forms.TextBox precioHoraTextBox;
        private System.Windows.Forms.Label totalHorasLabel;
        private System.Windows.Forms.TextBox totalHorasTextBox;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bBuscarSueldo;
        private System.Windows.Forms.Button bBuscarDni;
        private System.Windows.Forms.Label lBorrar;
        private System.Windows.Forms.Label lEstacion;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button bModificar2;
        private System.Windows.Forms.Button bAgregar2;
        private System.Windows.Forms.Button bBorrar2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBuscar;
    }
}