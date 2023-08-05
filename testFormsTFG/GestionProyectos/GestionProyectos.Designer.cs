namespace testFormsTFG.GestionProyectos
{
    partial class GestionProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionProyectos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.test = new System.Windows.Forms.Label();
            this.getEvents = new System.Windows.Forms.Timer(this.components);
            this.treeViewProys = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbProys = new System.Windows.Forms.ComboBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFIni = new System.Windows.Forms.DateTimePicker();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelOps = new System.Windows.Forms.Panel();
            this.btnAceptarOp = new System.Windows.Forms.Button();
            this.labelDenomiOp = new System.Windows.Forms.Label();
            this.cbOperario = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMPOp = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbOperaciones = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCerrarPanelOps = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAñadirOp = new System.Windows.Forms.Button();
            this.btnEliminarOp = new System.Windows.Forms.Button();
            this.labelNumCompo = new System.Windows.Forms.Label();
            this.labelDescPieza = new System.Windows.Forms.Label();
            this.labelNomPieza = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCompo = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nUEVOCOMPONENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMNARCOMPONENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATOSDEPIEZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbDescPieza = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCodigoPieza = new System.Windows.Forms.TextBox();
            this.btnAceptarNuevaPieza = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCerrarPanel3 = new System.Windows.Forms.Button();
            this.btnAcepNuevoProy = new System.Windows.Forms.Button();
            this.btnCancNuevoproy = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.btnAceptarCalendar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCerraCalendar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelOps.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.Location = new System.Drawing.Point(14, 40);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(13, 17);
            this.test.TabIndex = 1;
            this.test.Text = "-";
            this.test.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // getEvents
            // 
            this.getEvents.Enabled = true;
            this.getEvents.Interval = 5000;
            this.getEvents.Tick += new System.EventHandler(this.getEvents_Tick);
            // 
            // treeViewProys
            // 
            this.treeViewProys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewProys.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewProys.FullRowSelect = true;
            this.treeViewProys.Location = new System.Drawing.Point(12, 207);
            this.treeViewProys.Name = "treeViewProys";
            this.treeViewProys.Size = new System.Drawing.Size(1214, 330);
            this.treeViewProys.TabIndex = 3;
            this.treeViewProys.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProys_AfterSelect);
            this.treeViewProys.DoubleClick += new System.EventHandler(this.treeViewProys_DoubleClick);
            this.treeViewProys.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewProys_MouseClick);
            this.treeViewProys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewProys_MouseDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1161, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "ELIMINAR";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1055, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 26);
            this.label10.TabIndex = 36;
            this.label10.Text = "NUEVO\r\nPROYECTO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(1164, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 60);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Location = new System.Drawing.Point(1063, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 60);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cbProys
            // 
            this.cbProys.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProys.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProys.FormattingEnabled = true;
            this.cbProys.Location = new System.Drawing.Point(227, 12);
            this.cbProys.Name = "cbProys";
            this.cbProys.Size = new System.Drawing.Size(176, 33);
            this.cbProys.TabIndex = 38;
            this.cbProys.SelectedIndexChanged += new System.EventHandler(this.cbProys_SelectedIndexChanged);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(5, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(216, 39);
            this.labelHeader.TabIndex = 39;
            this.labelHeader.Text = "PROYECTO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(462, 39);
            this.label12.TabIndex = 48;
            this.label12.Text = "ESTRUCTURA DE PIEZAS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dtpFIni);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.tbDesc);
            this.panel1.Controls.Add(this.tbCliente);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 99);
            this.panel1.TabIndex = 49;
            // 
            // dtpFIni
            // 
            this.dtpFIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFIni.Location = new System.Drawing.Point(652, 53);
            this.dtpFIni.Name = "dtpFIni";
            this.dtpFIni.Size = new System.Drawing.Size(134, 30);
            this.dtpFIni.TabIndex = 63;
            // 
            // tbNombre
            // 
            this.tbNombre.AccessibleDescription = "";
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(210, 9);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(184, 30);
            this.tbNombre.TabIndex = 65;
            // 
            // tbDesc
            // 
            this.tbDesc.AccessibleDescription = "";
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(210, 48);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(184, 30);
            this.tbDesc.TabIndex = 64;
            // 
            // tbCliente
            // 
            this.tbCliente.AccessibleDescription = "";
            this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(652, 9);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(134, 30);
            this.tbCliente.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(428, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 25);
            this.label11.TabIndex = 54;
            this.label11.Text = "FECHA DE INICIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "DESCRIPCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "CLIENTE";
            // 
            // panelOps
            // 
            this.panelOps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOps.BackColor = System.Drawing.Color.Silver;
            this.panelOps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOps.Controls.Add(this.btnAceptarOp);
            this.panelOps.Controls.Add(this.labelDenomiOp);
            this.panelOps.Controls.Add(this.cbOperario);
            this.panelOps.Controls.Add(this.label14);
            this.panelOps.Controls.Add(this.cbMPOp);
            this.panelOps.Controls.Add(this.label13);
            this.panelOps.Controls.Add(this.cbOperaciones);
            this.panelOps.Controls.Add(this.label8);
            this.panelOps.Controls.Add(this.label7);
            this.panelOps.Controls.Add(this.btnCerrarPanelOps);
            this.panelOps.Location = new System.Drawing.Point(237, 155);
            this.panelOps.Name = "panelOps";
            this.panelOps.Size = new System.Drawing.Size(711, 519);
            this.panelOps.TabIndex = 53;
            this.panelOps.Visible = false;
            // 
            // btnAceptarOp
            // 
            this.btnAceptarOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptarOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarOp.Location = new System.Drawing.Point(499, 427);
            this.btnAceptarOp.Name = "btnAceptarOp";
            this.btnAceptarOp.Size = new System.Drawing.Size(203, 76);
            this.btnAceptarOp.TabIndex = 61;
            this.btnAceptarOp.Text = "ACEPTAR";
            this.btnAceptarOp.UseVisualStyleBackColor = false;
            this.btnAceptarOp.Click += new System.EventHandler(this.btnAceptarOp_Click);
            // 
            // labelDenomiOp
            // 
            this.labelDenomiOp.AutoSize = true;
            this.labelDenomiOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenomiOp.ForeColor = System.Drawing.Color.Green;
            this.labelDenomiOp.Location = new System.Drawing.Point(30, 257);
            this.labelDenomiOp.Name = "labelDenomiOp";
            this.labelDenomiOp.Size = new System.Drawing.Size(91, 25);
            this.labelDenomiOp.TabIndex = 60;
            this.labelDenomiOp.Text = "DENOMI";
            // 
            // cbOperario
            // 
            this.cbOperario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOperario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperario.FormattingEnabled = true;
            this.cbOperario.Location = new System.Drawing.Point(33, 331);
            this.cbOperario.Name = "cbOperario";
            this.cbOperario.Size = new System.Drawing.Size(547, 33);
            this.cbOperario.TabIndex = 58;
            this.cbOperario.SelectedIndexChanged += new System.EventHandler(this.cbOperario_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 25);
            this.label14.TabIndex = 57;
            this.label14.Text = "OPERARIO ASIGNADO";
            // 
            // cbMPOp
            // 
            this.cbMPOp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMPOp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMPOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMPOp.FormattingEnabled = true;
            this.cbMPOp.Location = new System.Drawing.Point(33, 205);
            this.cbMPOp.Name = "cbMPOp";
            this.cbMPOp.Size = new System.Drawing.Size(371, 33);
            this.cbMPOp.TabIndex = 56;
            this.cbMPOp.SelectedIndexChanged += new System.EventHandler(this.cbMPOp_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(296, 25);
            this.label13.TabIndex = 55;
            this.label13.Text = "ARTÍCULO MATERIA PRIMA";
            // 
            // cbOperaciones
            // 
            this.cbOperaciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOperaciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperaciones.FormattingEnabled = true;
            this.cbOperaciones.Location = new System.Drawing.Point(33, 126);
            this.cbOperaciones.Name = "cbOperaciones";
            this.cbOperaciones.Size = new System.Drawing.Size(224, 33);
            this.cbOperaciones.TabIndex = 54;
            this.cbOperaciones.SelectedIndexChanged += new System.EventHandler(this.cbOperaciones_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "OPERACIÓN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(557, 39);
            this.label7.TabIndex = 52;
            this.label7.Text = "OPERACIÓN DE COMPONENTE";
            // 
            // btnCerrarPanelOps
            // 
            this.btnCerrarPanelOps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPanelOps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrarPanelOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPanelOps.Location = new System.Drawing.Point(648, 9);
            this.btnCerrarPanelOps.Name = "btnCerrarPanelOps";
            this.btnCerrarPanelOps.Size = new System.Drawing.Size(58, 50);
            this.btnCerrarPanelOps.TabIndex = 51;
            this.btnCerrarPanelOps.Text = "X";
            this.btnCerrarPanelOps.UseVisualStyleBackColor = false;
            this.btnCerrarPanelOps.Click += new System.EventHandler(this.btnCerrarPanelOps_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAñadirOp);
            this.panel2.Controls.Add(this.btnEliminarOp);
            this.panel2.Controls.Add(this.labelNumCompo);
            this.panel2.Controls.Add(this.labelDescPieza);
            this.panel2.Controls.Add(this.labelNomPieza);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvCompo);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(273, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 463);
            this.panel2.TabIndex = 54;
            this.panel2.Visible = false;
            // 
            // btnAñadirOp
            // 
            this.btnAñadirOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAñadirOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirOp.Location = new System.Drawing.Point(288, 386);
            this.btnAñadirOp.Name = "btnAñadirOp";
            this.btnAñadirOp.Size = new System.Drawing.Size(176, 68);
            this.btnAñadirOp.TabIndex = 57;
            this.btnAñadirOp.Text = "AÑADIR OPERACIÓN";
            this.btnAñadirOp.UseVisualStyleBackColor = false;
            this.btnAñadirOp.Click += new System.EventHandler(this.btnAñadirOp_Click);
            // 
            // btnEliminarOp
            // 
            this.btnEliminarOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarOp.Location = new System.Drawing.Point(470, 386);
            this.btnEliminarOp.Name = "btnEliminarOp";
            this.btnEliminarOp.Size = new System.Drawing.Size(176, 68);
            this.btnEliminarOp.TabIndex = 56;
            this.btnEliminarOp.Text = "ELIMINAR OPERACIÓN";
            this.btnEliminarOp.UseVisualStyleBackColor = false;
            this.btnEliminarOp.Click += new System.EventHandler(this.btnEliminarOp_Click);
            // 
            // labelNumCompo
            // 
            this.labelNumCompo.AutoSize = true;
            this.labelNumCompo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCompo.ForeColor = System.Drawing.Color.Green;
            this.labelNumCompo.Location = new System.Drawing.Point(195, 196);
            this.labelNumCompo.Name = "labelNumCompo";
            this.labelNumCompo.Size = new System.Drawing.Size(55, 31);
            this.labelNumCompo.TabIndex = 55;
            this.labelNumCompo.Text = "( - )";
            // 
            // labelDescPieza
            // 
            this.labelDescPieza.AutoSize = true;
            this.labelDescPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescPieza.ForeColor = System.Drawing.Color.Blue;
            this.labelDescPieza.Location = new System.Drawing.Point(15, 120);
            this.labelDescPieza.Name = "labelDescPieza";
            this.labelDescPieza.Size = new System.Drawing.Size(133, 31);
            this.labelDescPieza.TabIndex = 54;
            this.labelDescPieza.Text = "NOMBRE";
            // 
            // labelNomPieza
            // 
            this.labelNomPieza.AutoSize = true;
            this.labelNomPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomPieza.ForeColor = System.Drawing.Color.Blue;
            this.labelNomPieza.Location = new System.Drawing.Point(15, 67);
            this.labelNomPieza.Name = "labelNomPieza";
            this.labelNomPieza.Size = new System.Drawing.Size(133, 31);
            this.labelNomPieza.TabIndex = 53;
            this.labelNomPieza.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "COMPONENTES";
            // 
            // dgvCompo
            // 
            this.dgvCompo.AllowUserToAddRows = false;
            this.dgvCompo.AllowUserToDeleteRows = false;
            this.dgvCompo.AllowUserToOrderColumns = true;
            this.dgvCompo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCompo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCompo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompo.Location = new System.Drawing.Point(13, 230);
            this.dgvCompo.Name = "dgvCompo";
            this.dgvCompo.ReadOnly = true;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCompo.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCompo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompo.Size = new System.Drawing.Size(633, 150);
            this.dgvCompo.TabIndex = 51;
            this.dgvCompo.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(588, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(58, 50);
            this.btnCerrar.TabIndex = 50;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 39);
            this.label5.TabIndex = 49;
            this.label5.Text = "DATOS DE PIEZA";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOCOMPONENTEToolStripMenuItem,
            this.eLIMNARCOMPONENTEToolStripMenuItem,
            this.dATOSDEPIEZAToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // nUEVOCOMPONENTEToolStripMenuItem
            // 
            this.nUEVOCOMPONENTEToolStripMenuItem.Name = "nUEVOCOMPONENTEToolStripMenuItem";
            this.nUEVOCOMPONENTEToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.nUEVOCOMPONENTEToolStripMenuItem.Text = "NUEVA PIEZA";
            this.nUEVOCOMPONENTEToolStripMenuItem.Click += new System.EventHandler(this.nUEVOCOMPONENTEToolStripMenuItem_Click);
            // 
            // eLIMNARCOMPONENTEToolStripMenuItem
            // 
            this.eLIMNARCOMPONENTEToolStripMenuItem.Name = "eLIMNARCOMPONENTEToolStripMenuItem";
            this.eLIMNARCOMPONENTEToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.eLIMNARCOMPONENTEToolStripMenuItem.Text = "ELIMINAR PIEZA";
            this.eLIMNARCOMPONENTEToolStripMenuItem.Click += new System.EventHandler(this.eLIMNARCOMPONENTEToolStripMenuItem_Click);
            // 
            // dATOSDEPIEZAToolStripMenuItem
            // 
            this.dATOSDEPIEZAToolStripMenuItem.Name = "dATOSDEPIEZAToolStripMenuItem";
            this.dATOSDEPIEZAToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.dATOSDEPIEZAToolStripMenuItem.Text = "DATOS DE PIEZA";
            this.dATOSDEPIEZAToolStripMenuItem.Click += new System.EventHandler(this.dATOSDEPIEZAToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbDescPieza);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.tbCodigoPieza);
            this.panel3.Controls.Add(this.btnAceptarNuevaPieza);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.btnCerrarPanel3);
            this.panel3.Location = new System.Drawing.Point(237, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(706, 399);
            this.panel3.TabIndex = 62;
            this.panel3.Visible = false;
            // 
            // tbDescPieza
            // 
            this.tbDescPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescPieza.Location = new System.Drawing.Point(28, 230);
            this.tbDescPieza.Name = "tbDescPieza";
            this.tbDescPieza.Size = new System.Drawing.Size(508, 38);
            this.tbDescPieza.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 25);
            this.label15.TabIndex = 63;
            this.label15.Text = "DESCRIPCIÓN";
            // 
            // tbCodigoPieza
            // 
            this.tbCodigoPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoPieza.Location = new System.Drawing.Point(28, 115);
            this.tbCodigoPieza.Name = "tbCodigoPieza";
            this.tbCodigoPieza.Size = new System.Drawing.Size(251, 38);
            this.tbCodigoPieza.TabIndex = 62;
            // 
            // btnAceptarNuevaPieza
            // 
            this.btnAceptarNuevaPieza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarNuevaPieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptarNuevaPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarNuevaPieza.Location = new System.Drawing.Point(497, 308);
            this.btnAceptarNuevaPieza.Name = "btnAceptarNuevaPieza";
            this.btnAceptarNuevaPieza.Size = new System.Drawing.Size(203, 76);
            this.btnAceptarNuevaPieza.TabIndex = 61;
            this.btnAceptarNuevaPieza.Text = "ACEPTAR";
            this.btnAceptarNuevaPieza.UseVisualStyleBackColor = false;
            this.btnAceptarNuevaPieza.Click += new System.EventHandler(this.btnAceptarNuevaPieza_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(202, 25);
            this.label18.TabIndex = 53;
            this.label18.Text = "CÓDIGO DE PIEZA";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(256, 39);
            this.label19.TabIndex = 52;
            this.label19.Text = "NUEVA PIEZA";
            // 
            // btnCerrarPanel3
            // 
            this.btnCerrarPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrarPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPanel3.Location = new System.Drawing.Point(642, 9);
            this.btnCerrarPanel3.Name = "btnCerrarPanel3";
            this.btnCerrarPanel3.Size = new System.Drawing.Size(58, 50);
            this.btnCerrarPanel3.TabIndex = 51;
            this.btnCerrarPanel3.Text = "X";
            this.btnCerrarPanel3.UseVisualStyleBackColor = false;
            this.btnCerrarPanel3.Click += new System.EventHandler(this.btnCerrarPanel3_Click);
            // 
            // btnAcepNuevoProy
            // 
            this.btnAcepNuevoProy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcepNuevoProy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAcepNuevoProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcepNuevoProy.Location = new System.Drawing.Point(902, 12);
            this.btnAcepNuevoProy.Name = "btnAcepNuevoProy";
            this.btnAcepNuevoProy.Size = new System.Drawing.Size(138, 76);
            this.btnAcepNuevoProy.TabIndex = 63;
            this.btnAcepNuevoProy.Text = "ACEPTAR";
            this.btnAcepNuevoProy.UseVisualStyleBackColor = false;
            this.btnAcepNuevoProy.Visible = false;
            this.btnAcepNuevoProy.Click += new System.EventHandler(this.btnAcepNuevoProy_Click);
            // 
            // btnCancNuevoproy
            // 
            this.btnCancNuevoproy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancNuevoproy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancNuevoproy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancNuevoproy.Location = new System.Drawing.Point(902, 99);
            this.btnCancNuevoproy.Name = "btnCancNuevoproy";
            this.btnCancNuevoproy.Size = new System.Drawing.Size(138, 76);
            this.btnCancNuevoproy.TabIndex = 64;
            this.btnCancNuevoproy.Text = "CANCELAR";
            this.btnCancNuevoproy.UseVisualStyleBackColor = false;
            this.btnCancNuevoproy.Visible = false;
            this.btnCancNuevoproy.Click += new System.EventHandler(this.btnCancNuevoproy_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(862, 554);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(364, 105);
            this.btnCalendar.TabIndex = 65;
            this.btnCalendar.Text = "FECHA DE ENTREGA";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // panelCalendar
            // 
            this.panelCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCalendar.BackColor = System.Drawing.Color.Silver;
            this.panelCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCalendar.Controls.Add(this.label1);
            this.panelCalendar.Controls.Add(this.dtpCalendar);
            this.panelCalendar.Controls.Add(this.btnAceptarCalendar);
            this.panelCalendar.Controls.Add(this.label17);
            this.panelCalendar.Controls.Add(this.btnCerraCalendar);
            this.panelCalendar.Location = new System.Drawing.Point(238, 218);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(706, 263);
            this.panelCalendar.TabIndex = 66;
            this.panelCalendar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "NUEVO EVENTO EN GOOGLE CALENDAR";
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendar.Location = new System.Drawing.Point(27, 119);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.Size = new System.Drawing.Size(466, 38);
            this.dtpCalendar.TabIndex = 62;
            this.dtpCalendar.DropDown += new System.EventHandler(this.dtpCalendar_DropDown);
            // 
            // btnAceptarCalendar
            // 
            this.btnAceptarCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptarCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCalendar.Location = new System.Drawing.Point(498, 165);
            this.btnAceptarCalendar.Name = "btnAceptarCalendar";
            this.btnAceptarCalendar.Size = new System.Drawing.Size(203, 76);
            this.btnAceptarCalendar.TabIndex = 61;
            this.btnAceptarCalendar.Text = "ACEPTAR";
            this.btnAceptarCalendar.UseVisualStyleBackColor = false;
            this.btnAceptarCalendar.Click += new System.EventHandler(this.btnAceptarCalendar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(459, 39);
            this.label17.TabIndex = 52;
            this.label17.Text = "ENTREGA DE PROYECTO";
            // 
            // btnCerraCalendar
            // 
            this.btnCerraCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerraCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerraCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerraCalendar.Location = new System.Drawing.Point(642, 9);
            this.btnCerraCalendar.Name = "btnCerraCalendar";
            this.btnCerraCalendar.Size = new System.Drawing.Size(58, 50);
            this.btnCerraCalendar.TabIndex = 51;
            this.btnCerraCalendar.Text = "X";
            this.btnCerraCalendar.UseVisualStyleBackColor = false;
            this.btnCerraCalendar.Click += new System.EventHandler(this.btnCerraCalendar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(249, 25);
            this.label16.TabIndex = 67;
            this.label16.Text = "PRÓXIMAS ENTREGAS";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.test);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(12, 543);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 148);
            this.panel4.TabIndex = 68;
            // 
            // GestionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 696);
            this.Controls.Add(this.panelCalendar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelOps);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.cbProys);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.treeViewProys);
            this.Controls.Add(this.btnCancNuevoproy);
            this.Controls.Add(this.btnAcepNuevoProy);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.panel4);
            this.Name = "GestionProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Proyectos";
            this.Load += new System.EventHandler(this.GestionProyectos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOps.ResumeLayout(false);
            this.panelOps.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelCalendar.ResumeLayout(false);
            this.panelCalendar.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Timer getEvents;
        private System.Windows.Forms.TreeView treeViewProys;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbProys;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelOps;
        private System.Windows.Forms.Button btnAceptarOp;
        private System.Windows.Forms.Label labelDenomiOp;
        private System.Windows.Forms.ComboBox cbOperario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMPOp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbOperaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCerrarPanelOps;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAñadirOp;
        private System.Windows.Forms.Button btnEliminarOp;
        private System.Windows.Forms.Label labelNumCompo;
        private System.Windows.Forms.Label labelDescPieza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCompo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUEVOCOMPONENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMNARCOMPONENTEToolStripMenuItem;
        private System.Windows.Forms.Label labelNomPieza;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbCodigoPieza;
        private System.Windows.Forms.Button btnAceptarNuevaPieza;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCerrarPanel3;
        private System.Windows.Forms.TextBox tbDescPieza;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.DateTimePicker dtpFIni;
        private System.Windows.Forms.Button btnAcepNuevoProy;
        private System.Windows.Forms.Button btnCancNuevoproy;
        private System.Windows.Forms.ToolStripMenuItem dATOSDEPIEZAToolStripMenuItem;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCalendar;
        private System.Windows.Forms.Button btnAceptarCalendar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCerraCalendar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
    }
}