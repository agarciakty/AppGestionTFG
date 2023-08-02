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
            this.button1 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.getEvents = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.treeViewProys = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbProys = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFIni = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelOps = new System.Windows.Forms.Panel();
            this.btnAceptarOp = new System.Windows.Forms.Button();
            this.labelDenomiOp = new System.Windows.Forms.Label();
            this.labelCodigoOp = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panelOps.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.Location = new System.Drawing.Point(12, 540);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(28, 39);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeViewProys
            // 
            this.treeViewProys.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewProys.FullRowSelect = true;
            this.treeViewProys.Location = new System.Drawing.Point(12, 207);
            this.treeViewProys.Name = "treeViewProys";
            this.treeViewProys.Size = new System.Drawing.Size(1214, 330);
            this.treeViewProys.TabIndex = 3;
            this.treeViewProys.DoubleClick += new System.EventHandler(this.treeViewProys_DoubleClick);
            this.treeViewProys.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewProys_MouseClick);
            this.treeViewProys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewProys_MouseDown);
            // 
            // label9
            // 
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
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Location = new System.Drawing.Point(1063, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 60);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 39);
            this.label1.TabIndex = 39;
            this.label1.Text = "PROYECTO";
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
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelFIni);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.labelCliente);
            this.panel1.Controls.Add(this.labelDesc);
            this.panel1.Controls.Add(this.labelNom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 99);
            this.panel1.TabIndex = 49;
            // 
            // labelFIni
            // 
            this.labelFIni.AutoSize = true;
            this.labelFIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFIni.Location = new System.Drawing.Point(654, 53);
            this.labelFIni.Name = "labelFIni";
            this.labelFIni.Size = new System.Drawing.Size(98, 25);
            this.labelFIni.TabIndex = 55;
            this.labelFIni.Text = "NOMBRE";
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
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(654, 12);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(98, 25);
            this.labelCliente.TabIndex = 53;
            this.labelCliente.Text = "NOMBRE";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(205, 53);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(98, 25);
            this.labelDesc.TabIndex = 52;
            this.labelDesc.Text = "NOMBRE";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(205, 12);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(98, 25);
            this.labelNom.TabIndex = 51;
            this.labelNom.Text = "NOMBRE";
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
            this.panelOps.BackColor = System.Drawing.Color.Silver;
            this.panelOps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOps.Controls.Add(this.btnAceptarOp);
            this.panelOps.Controls.Add(this.labelDenomiOp);
            this.panelOps.Controls.Add(this.labelCodigoOp);
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
            this.labelDenomiOp.Location = new System.Drawing.Point(336, 254);
            this.labelDenomiOp.Name = "labelDenomiOp";
            this.labelDenomiOp.Size = new System.Drawing.Size(91, 25);
            this.labelDenomiOp.TabIndex = 60;
            this.labelDenomiOp.Text = "DENOMI";
            // 
            // labelCodigoOp
            // 
            this.labelCodigoOp.AutoSize = true;
            this.labelCodigoOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoOp.ForeColor = System.Drawing.Color.Green;
            this.labelCodigoOp.Location = new System.Drawing.Point(28, 254);
            this.labelCodigoOp.Name = "labelCodigoOp";
            this.labelCodigoOp.Size = new System.Drawing.Size(93, 25);
            this.labelCodigoOp.TabIndex = 59;
            this.labelCodigoOp.Text = "CODIGO";
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
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOCOMPONENTEToolStripMenuItem,
            this.eLIMNARCOMPONENTEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // nUEVOCOMPONENTEToolStripMenuItem
            // 
            this.nUEVOCOMPONENTEToolStripMenuItem.Name = "nUEVOCOMPONENTEToolStripMenuItem";
            this.nUEVOCOMPONENTEToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.nUEVOCOMPONENTEToolStripMenuItem.Text = "NUEVO COMPONENTE";
            this.nUEVOCOMPONENTEToolStripMenuItem.Click += new System.EventHandler(this.nUEVOCOMPONENTEToolStripMenuItem_Click);
            // 
            // eLIMNARCOMPONENTEToolStripMenuItem
            // 
            this.eLIMNARCOMPONENTEToolStripMenuItem.Name = "eLIMNARCOMPONENTEToolStripMenuItem";
            this.eLIMNARCOMPONENTEToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.eLIMNARCOMPONENTEToolStripMenuItem.Text = "ELIMNAR COMPONENTE";
            this.eLIMNARCOMPONENTEToolStripMenuItem.Click += new System.EventHandler(this.eLIMNARCOMPONENTEToolStripMenuItem_Click);
            // 
            // GestionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 696);
            this.Controls.Add(this.panelOps);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProys);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.treeViewProys);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button1);
            this.Name = "GestionProyectos";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Timer getEvents;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeViewProys;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbProys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFIni;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelOps;
        private System.Windows.Forms.Button btnAceptarOp;
        private System.Windows.Forms.Label labelDenomiOp;
        private System.Windows.Forms.Label labelCodigoOp;
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
        private System.Windows.Forms.Label labelNomPieza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCompo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUEVOCOMPONENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMNARCOMPONENTEToolStripMenuItem;
    }
}